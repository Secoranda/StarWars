namespace Labs
{
	public sealed partial class CommandCenter
	{
		private ICommand _command;

		public int AvailableUnits { get; set; }

		public void SetCommand(ICommand command)
		{
			_command = command;
		}

		public void Execute()
		{
			_command.Execute();
		}

		public void Notify(Status status)
		{
			if (status == Status.Retreating)
				AvailableUnits--;
		}
	}
}
