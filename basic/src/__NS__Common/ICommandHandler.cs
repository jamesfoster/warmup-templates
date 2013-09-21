namespace __NS__Common
{
	using System.Threading.Tasks;

	public interface ICommandHandler { }

	public interface ICommandHandler<in TCommand> : ICommandHandler
		where TCommand : ICommand
	{
		Task Handle(TCommand command);
	}
}