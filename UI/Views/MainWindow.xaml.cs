using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Labs;
using UI.ViewModels;
using UI.Views;

namespace UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private CreateSpaceship _createSpaceshipWindow;
		private CreateStormtrooper _createStormtrooperWindow;
        private WarCheck _seeTechDetails;
        private SpaceshipDetails _seeSpaceSDetails;
       

        public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainWindowViewModel();
		}

		private void CreateSpaceshipWindowOnClosed(object sender, EventArgs e)
		{
			var spName = _createSpaceshipWindow.SpaceshipName.Text;
			var spType = (SpaceshipType) _createSpaceshipWindow.Types.SelectedValue;
			var newSpaceship = CommandCenter.Instance.Fleet.GetSpaceshipFactory().CreateSpaceship(spName, spType);
			((MainWindowViewModel)DataContext).Spaceships.Add(newSpaceship);
		}
    

        private void CreateSpaceship_OnClick(object sender, RoutedEventArgs e)
		{
			_createSpaceshipWindow = new CreateSpaceship();
			_createSpaceshipWindow.Closed += CreateSpaceshipWindowOnClosed;
			_createSpaceshipWindow.Show();
		}

		private void CreateStormtrooper_OnClick(object sender, RoutedEventArgs e)
		{
			_createStormtrooperWindow = new CreateStormtrooper();
			_createStormtrooperWindow.Closed += CreateStormtrooperWindowOnClosed;
			_createStormtrooperWindow.Show();
		}

		private void CreateStormtrooperWindowOnClosed(object sender, EventArgs e)
		{
			var stId = _createStormtrooperWindow.StormtrooperIdentifier.Text;
			var stSp = (string)_createStormtrooperWindow.Spaceships.SelectedValue;
			var newStormtrooper = CommandCenter.Instance.Fleet.GetStormtrooperFactory()
				.CreateStormtrooper(stId, ((MainWindowViewModel)DataContext)
					.Spaceships.FirstOrDefault(x => x.Name == stSp));
			((MainWindowViewModel)DataContext).Stormtroopers.Add(newStormtrooper);
		}

        private void ButSpace_Click(object sender, RoutedEventArgs e)
        {
            _seeTechDetails = new WarCheck();         
            _seeTechDetails.Show();
        }

        private void SpaceDetails_Click(object sender, RoutedEventArgs e)
        {
            _seeSpaceSDetails = new SpaceshipDetails();
            _seeSpaceSDetails.Show();
        }

        private void StormtrooperFighting_Click(object sender, RoutedEventArgs e)
        {
			var fighting = new Views.StormtrooperFighting();
			fighting.Show();
        }
       
    }
}
