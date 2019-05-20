using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Labs;

namespace UI.ViewModels
{
	public class MainWindowViewModel
	{
		public ObservableCollection<Spaceship> Spaceships { get; set; }
		public ObservableCollection<IStormtrooper> Stormtroopers { get; set; }

		public MainWindowViewModel()
		{
			Spaceships = new ObservableCollection<Spaceship>
			{
				CommandCenter.Instance.Fleet.GetSpaceshipFactory()
					.CreateSpaceship("Vulture FX", SpaceshipType.Combat),
				CommandCenter.Instance.Fleet.GetSpaceshipFactory()
					.CreateSpaceship("Dekon SSX", SpaceshipType.Defense),
				CommandCenter.Instance.Fleet.GetSpaceshipFactory()
					.CreateSpaceship("Xenax 200S", SpaceshipType.Transport),
			};

			Stormtroopers = new ObservableCollection<IStormtrooper>
			{
				CommandCenter.Instance.Fleet.GetStormtrooperFactory()
					.CreateStormtrooper("Fergo Lag", Spaceships[0]),
				CommandCenter.Instance.Fleet.GetStormtrooperFactory()
					.CreateStormtrooper("Sargus Kar Kyk", Spaceships[1]),
				CommandCenter.Instance.Fleet.GetStormtrooperFactory()
					.CreateStormtrooper("Dex Kex", Spaceships[2]),
			};
		}
	}
}
