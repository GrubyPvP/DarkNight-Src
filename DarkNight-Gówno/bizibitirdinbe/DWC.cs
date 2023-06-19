using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace bizibitirdinbe
{
	// Token: 0x02000037 RID: 55
	public class DWC
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x000029B3 File Offset: 0x00000BB3
		public DWC(string string_0)
		{
			this.uri_0 = new Uri(string_0);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000FE80 File Offset: 0x0000E080
		public void PostMessage(WebhookMessage message)
		{
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(this.uri_0);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			string s = JsonConvert.SerializeObject(message);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Flush();
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000FF20 File Offset: 0x0000E120
		public Task PostMessageAsync(WebhookMessage message)
		{
			DWC.<PostMessageAsync>d__3 <PostMessageAsync>d__;
			<PostMessageAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<PostMessageAsync>d__.<>4__this = this;
			<PostMessageAsync>d__.message = message;
			<PostMessageAsync>d__.<>1__state = -1;
			<PostMessageAsync>d__.<>t__builder.Start<DWC.<PostMessageAsync>d__3>(ref <PostMessageAsync>d__);
			return <PostMessageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400011E RID: 286
		public Uri uri_0;
	}
}
