using Labs;
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
    /// Interaction logic for WarCheck.xaml
    /// </summary>
    public partial class WarCheck : Window
    {
        public static Random rand = new Random();
        private WarResult _result;
        private readonly bool _access;
        private List<Spaceship> namesallow = new List<Spaceship>();
        private List<Spaceship> namesnallow = new List<Spaceship>();
        public WarCheck()
        {
            InitializeComponent();

            foreach (var a in ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships)
            {
                _access = rand.NextDouble() >= 0.5;
                new SpaceshipFlightFacade(a).StartFlight(_access);
                if (_access)
                {
                    namesallow.Add(a);
                    Allow.ItemsSource = namesallow.Select(x => x.Name) ;

                }
                else
                {
                    namesnallow.Add(a);
                    NAllow.ItemsSource = namesnallow.Select(x => x.Name);
                }
                    
            }

        }

        private void Depart_Click(object sender, RoutedEventArgs e)
        {
            _result = new WarResult();
            
            _result.Show();
        }


    }
}
