namespace Labs
{
	public partial class Stormtrooper : ARetreat
	{
		protected override string RetreatParty()
		{
			return $"{Identifier} from {Spaceship.Name} is retreating to base.";
		}
	}
}
