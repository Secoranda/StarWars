namespace Labs
{
	public enum SpaceshipType
	{
		Combat, Defense, Transport
	}

	public enum Fuselage
	{
		Framework, Monocoque, SemiMonocoque
	}

	public enum Engines
	{
		FTL, Photonic, Quantum
	}

	public enum Avionics
	{
		Rockwell, Proline, Bendix
	}

	public enum Weaponry
	{
		Beam, Kinetic, Missile
	}

	public partial class Spaceship
	{
		public string Name { get; }
		public Fuselage Fuselage { get; set; }
		public Engines Engines { get; set; }
		public Avionics Avionics { get; set; }
		public Weaponry Weaponry { get; set; }
		public SpaceshipType Type { get; set; }

		public Spaceship(string name) : base() => Name = name;

		public override string ToString()
		{
			return $"{Name} is a {Type} type Spaceship, it has {Fuselage} " +
				$"fuselage, {Engines} engines, {Avionics} avionics and " +
				$"{Weaponry} weaponry.";
		}
	}

	public interface ISpaceshipBuilder
	{
		void BuildFuselage(Fuselage f);
		void BuildEngines(Engines e);
		void BuildAvionics(Avionics a);
		void BuildWeaponry(Weaponry w);
		void BuildType(SpaceshipType t);
		Spaceship BuildSpaceship();
	}

	public class SpaceshipBuilder : ISpaceshipBuilder
	{
		private Spaceship spaceship;

		public SpaceshipBuilder(string name) =>
			spaceship = new Spaceship(name);

		public void BuildFuselage(Fuselage f) => spaceship.Fuselage = f;
		public void BuildEngines(Engines e) => spaceship.Engines = e;
		public void BuildAvionics(Avionics a) => spaceship.Avionics = a;
		public void BuildWeaponry(Weaponry w) => spaceship.Weaponry = w;
		public void BuildType(SpaceshipType t) => spaceship.Type = t;
		public Spaceship BuildSpaceship() => spaceship;
	}
}