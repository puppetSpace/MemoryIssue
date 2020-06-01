using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddHttpClient();

			var container = serviceCollection.BuildServiceProvider();
			var httpClientFactory = container.GetService<IHttpClientFactory>();
			var content = new ByteArrayContent(File.ReadAllBytes("github-git-cheat-sheet.pdf"));
			Console.WriteLine("Press any key to call web api continually");
			Console.ReadKey();
			while (true)
			{
				var httpClient = httpClientFactory.CreateClient();
				await httpClient.PostAsync("https://localhost:5001/api/data", content);
			}
		}
	}
}
