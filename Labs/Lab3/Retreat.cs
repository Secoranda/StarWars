namespace Labs
{
	public abstract class ARetreat
	{
		protected IStatusObserver statusObserver;

		protected ARetreat()
		{
			statusObserver = new StatusObserver();
		}

		protected abstract string RetreatParty();

		public string Retreat()
		{
			statusObserver.Update(Status.Retreating);
			return RetreatParty();
		}
	}
}
