using System;
using System.Windows;
using System.Windows.Controls;
using Labs;

namespace UI.Views
{
	/// <summary>
	/// Interaction logic for CreateSpaceship.xaml
	/// </summary>
	public partial class CreateSpaceship : Window
	{

		public CreateSpaceship()
		{
			InitializeComponent();
			Types.ItemsSource = Enum.GetValues(typeof(SpaceshipType));
			Types.SelectedItem = SpaceshipType.Combat;
		}

		private void Create_OnClick(object sender, RoutedEventArgs e)
		{
			if (SpaceshipName.Text.Length > 0)
			{
				Close();
			}
		}
	}
}
