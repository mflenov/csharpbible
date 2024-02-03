using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskSample
{
    class AsyncSampleClass
    {
		public async Task<string> AccessTheWebAsync() {
			HttpClient client = new HttpClient();

			Task<string> getStringTask = client.GetStringAsync("http://www.flenov.info/robots.txt");

			return await getStringTask;
		}
	}
}
