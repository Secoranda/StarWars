using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Labs;
using UI.ViewModels;

namespace UI.Views
{
    /// <summary>
    /// Interaction logic for StormtrooperFighting.xaml
    /// </summary>
    public partial class StormtrooperFighting : Window
	{
		public ObservableCollection<string> Actions { get; set; }

		public StormtrooperFighting()
		{
			InitializeComponent();
			InitStormtroopers();
			Actions = new ObservableCollection<string>();
		}

		private void InitStormtroopers()
		{
			Stormtroopers.ItemsSource =
				((MainWindowViewModel) Application.Current.MainWindow.DataContext).Stormtroopers.Select(x =>
					x.Identifier);
		}

		private void MeleeAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel) Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new Labs.StormtrooperFighting(new MeleeToRangeAdapter(new MeleeWeapon()))));
				ActionsListView.ItemsSource = Actions;
			}
		}

		private void RangeAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel)Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new Labs.StormtrooperFighting(new RangeWeapon())));
				ActionsListView.ItemsSource = Actions;
			}
		}

		private void SpecialAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel)Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new StormtrooperSpecialAttackDecorator(new Labs.StormtrooperFighting(new RangeWeapon()))));
				ActionsListView.ItemsSource = Actions;
			}
		}

        private void Retreat_Click(object sender, RoutedEventArgs e)
        {
            if (Stormtroopers.SelectedItem != null)
            {
                var st =
                    ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
                        x.Identifier == Stormtroopers.SelectedItem.ToString());
                Actions.Add((st as ARetreat).Retreat());
                ActionsListView.ItemsSource = Actions;
            }

        }
    }
}
