namespace __NS__Common
{
	using System.Threading.Tasks;

	public interface IRequestHandler {}

	public interface IRequestHandler<in TRequest, TResponse> : IRequestHandler
		where TRequest : IRequest<TResponse>
	{
		Task<TResponse> Handle(TRequest request);
	}
}