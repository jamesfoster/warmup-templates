namespace __NS__Common
{
	public interface IRequestHandlerProvider
	{
		IRequestHandler<TRequest, TResponse> Get<TRequest, TResponse>() where TRequest : IRequest<TResponse>;
	}
}