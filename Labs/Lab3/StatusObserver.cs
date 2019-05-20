namespace Labs
{
	public enum Status
	{
		StandBy, Fighting, Retreating, Unavailable
	}

	public interface IStatusObserver
	{
		void Update(Status status);
	}

	public class StatusObserver: IStatusObserver
	{
		private IMediator _mediator;

		public StatusObserver() => _mediator = new Mediator();

		public void Update(Status status)
		{
			_mediator.Send(status);
		}
	}
}
