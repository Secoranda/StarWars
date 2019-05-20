namespace Labs
{
	public interface IStormtrooperFactory
	{
		IStormtrooper CreateStormtrooper(string identifier, Spaceship spaceship);
	}

	public class StormtrooperFactory : IStormtrooperFactory
	{
		public IStormtrooper CreateStormtrooper(string identifier, Spaceship spaceship) =>
				new Stormtrooper(identifier, spaceship);
	}
}
