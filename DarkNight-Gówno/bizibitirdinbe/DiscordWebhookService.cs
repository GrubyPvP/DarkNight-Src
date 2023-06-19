using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace bizibitirdinbe
{
	// Token: 0x02000039 RID: 57
	public static class DiscordWebhookService
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00010264 File Offset: 0x0000E464
		public static void PostMessage(string string_0, WebhookMessage message)
		{
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(string_0);
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

		// Token: 0x060000DC RID: 220 RVA: 0x00010300 File Offset: 0x0000E500
		public static void PostMessageAsync(string string_0, WebhookMessage message)
		{
			DiscordWebhookService.<PostMessageAsync>d__1 <PostMessageAsync>d__;
			<PostMessageAsync>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<PostMessageAsync>d__.string_0 = string_0;
			<PostMessageAsync>d__.message = message;
			<PostMessageAsync>d__.<>1__state = -1;
			<PostMessageAsync>d__.<>t__builder.Start<DiscordWebhookService.<PostMessageAsync>d__1>(ref <PostMessageAsync>d__);
		}
	}
}
