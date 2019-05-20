namespace Labs
{
	public interface ICommand
	{
		void Execute();
	}

	public class RetreatCommand : ICommand
	{
		private ARetreat _receiver;

		public RetreatCommand(ARetreat receiver)
		{
			_receiver = receiver;
		}

		public void Execute()
		{
			_receiver.Retreat();
		}
	}

	public class NullCommand : ICommand
	{
		public void Execute()
		{
		}
	}
}
