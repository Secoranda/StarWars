namespace Labs
{
	public partial interface IStormtrooper
	{
		IStormtrooper Clone();
	}

	public partial class Stormtrooper : IStormtrooper
	{
		public string Identifier { get; }
		public Spaceship Spaceship { get; }

		public Stormtrooper(string identifier, Spaceship spaceship) : base()
		{
			Identifier = identifier;
			Spaceship = spaceship;
		}

		public IStormtrooper Clone() => MemberwiseClone() as IStormtrooper;

		public override string ToString()
		{
			return $"{Identifier} of {Spaceship.Name} is ready for duty.";
		}
	}
}
