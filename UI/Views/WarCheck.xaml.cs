using Labs;
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
using System.Windows.Shapes;
using UI.ViewModels;


namespace UI.Views
{
    /// <summary>
    /// Interaction logic for WarCheck.xaml
    /// </summary>
    public partial class WarCheck : Window
    {
        public static Random rand = new Random();
        private readonly bool _access;
        private List<Spaceship> namesallow = new List<Spaceship>();
        private List<Spaceship> namesnallow = new List<Spaceship>();
        public ObservableCollection<string> ActionsSpaceship { get; set; }

        public WarCheck()
        {
            InitializeComponent();
            ActionsSpaceship = new ObservableCollection<string>();
            InitSpace();
            foreach (var a in ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships)
            {
                _access = rand.NextDouble() >= 0.5;
                new SpaceshipFlightFacade(a).StartFlight(_access);
                if (_access)
                {
                    namesallow.Add(a);
                    Allow.ItemsSource = namesallow.Select(x => x.Name);

                }
                else
                {
                    namesnallow.Add(a);
                    NAllow.ItemsSource = namesnallow.Select(x => x.Name);
                }

            }

        }

        private void InitSpace()
        {
            Allow.ItemsSource =
                ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships.Select(x =>
                   x.Name);
        }

        private void Depart_Click(object sender, RoutedEventArgs e)
        {
            if (Allow.SelectedItem != null)
            {
                var depart =
               ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships.FirstOrDefault(x =>
                       x.Name == Allow.SelectedItem.ToString());
                ActionsSpaceship.Add(depart.Fly());
                Middle.ItemsSource = ActionsSpaceship;
            }
        }

        private void Retreat_Click(object sender, RoutedEventArgs e)
        {
            if (Allow.SelectedItem != null)
            {
                var retreat =
              ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships.FirstOrDefault(x =>
                       x.Name == Allow.SelectedItem.ToString());
               
                ActionsSpaceship.Add((retreat as ARetreat).Retreat());
                Middle.ItemsSource = ActionsSpaceship;
            }
        }


    }
}
