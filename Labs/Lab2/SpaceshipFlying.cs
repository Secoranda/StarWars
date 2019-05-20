using System;

namespace Labs
{
	public partial class Spaceship
	{
		public void Fly()
		{
			Console.WriteLine($"{Name} is departing in 3. 2. 1. Go.");
		}
	}

	public class SpaceshipFlightFacade
	{
		private readonly Spaceship _spaceship;

		public SpaceshipFlightFacade(Spaceship spaceship)
		{
			_spaceship = spaceship;
		}

		public void StartFlight(bool access)
		{
			FlightProxy proxy = new FlightProxy(access);
			proxy.StartFlight(_spaceship);
		}
	}

	public class FlightProxy
	{
		private readonly bool _access;

		public FlightProxy(bool access)
		{
			_access = access;
		}

		public void StartFlight(Spaceship spaceship)
		{
			if (_access)
				spaceship.Fly();
			else
				Console.WriteLine($"{spaceship.Name} is not allowed to depart.");
		}
	}
}
