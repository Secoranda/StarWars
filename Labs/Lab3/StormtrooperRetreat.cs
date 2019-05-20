using System;

namespace Labs
{
	public partial class Stormtrooper : ARetreat
	{
		protected override void RetreatParty()
		{
			Console.WriteLine($"{Identifier} from {Spaceship.Name} is retreating to base.");
		}
	}
}
