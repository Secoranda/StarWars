namespace Labs
{
	public interface IMediator
	{
		void Send(Status status);
	}

	public class Mediator : IMediator
	{
		public void Send(Status status)
		{
			CommandCenter.Instance.Notify(status);
		}
	}
}
