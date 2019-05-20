namespace Labs
{
	public interface IFleet
	{
		ISpaceshipFactory GetSpaceshipFactory();
		IStormtrooperFactory GetStormtrooperFactory();
	}

	public class Fleet : IFleet
	{
		public ISpaceshipFactory GetSpaceshipFactory() => new SpaceshipFactory();

		public IStormtrooperFactory GetStormtrooperFactory() => new StormtrooperFactory();
	}
}
