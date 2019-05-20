using System;

namespace Labs
{
	public partial class Spaceship : ARetreat
	{
		protected override void RetreatParty()
		{
			Console.WriteLine($"{Name} is retreating from the battlefield.");
		}
	}
}
