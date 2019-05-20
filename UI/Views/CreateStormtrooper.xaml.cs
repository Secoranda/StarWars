using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using UI.ViewModels;

namespace UI.Views
{
	/// <summary>
	/// Interaction logic for CreateStormtrooper.xaml
	/// </summary>
	public partial class CreateStormtrooper : Window
	{
		public CreateStormtrooper()
		{
			InitializeComponent();
			Spaceships.ItemsSource = ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships.Select(x => x.Name);
		}

		private void Create_OnClick(object sender, RoutedEventArgs e)
		{
			if (StormtrooperIdentifier.Text.Length > 0 && Spaceships.SelectedValue != null)
			{
				Close();
			}
		}
	}
}
