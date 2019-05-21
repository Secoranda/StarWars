namespace Labs
{
	public partial class Spaceship
	{
		public string Fly()
		{
			return $"{Name} is departing in 3. 2. 1. Go.";
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
			var proxy = new FlightProxy(access);
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

		public string StartFlight(Spaceship spaceship)
		{
			return _access ? spaceship.Fly() : $"{spaceship.Name} is not allowed to depart.";
		}
	}
}
