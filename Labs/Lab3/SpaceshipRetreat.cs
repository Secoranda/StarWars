namespace Labs
{
	public partial class Spaceship : ARetreat
	{
		protected override string RetreatParty()
		{
			return $"{Name} is retreating from the battlefield.";
		}
	}
}
