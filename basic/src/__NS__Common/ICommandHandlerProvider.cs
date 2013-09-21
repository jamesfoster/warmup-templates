namespace __NS__Common
{
	public interface ICommandHandlerProvider
	{
		ICommandHandler<TCommand> Get<TCommand>();
	}
}