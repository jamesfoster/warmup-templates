namespace __NS__Common.Extensions
{
	using System.Threading.Tasks;

	public static class WebClientProviderExtensions
	{
		public static Task<string> DownloadString(this IWebClientProvider webClientProvider, string url)
		{
			using (var webClient = webClientProvider.GetClient())
			{
				return webClient.DownloadString(url);
			}
		}
	}
}
