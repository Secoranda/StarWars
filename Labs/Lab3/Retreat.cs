namespace Labs
{
	public abstract class ARetreat
	{
		protected IStatusObserver statusObserver;

		protected ARetreat()
		{
			statusObserver = new StatusObserver();
		}

		protected abstract void RetreatParty();

		public void Retreat()
		{
			RetreatParty();
			statusObserver.Update(Status.Retreating);
		}
	}
}
