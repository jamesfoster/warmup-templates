namespace __NS__Common
{
	using System;
	using System.Threading.Tasks;

	public interface IWebClient : IDisposable
	{
		Task<string> DownloadString(string address);
	}
}