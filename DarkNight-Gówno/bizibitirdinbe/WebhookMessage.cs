using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace bizibitirdinbe
{
	// Token: 0x02000041 RID: 65
	public class WebhookMessage
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002B6E File Offset: 0x00000D6E
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002B76 File Offset: 0x00000D76
		public bool tts { get; set; }

		// Token: 0x060000F4 RID: 244 RVA: 0x00002B7F File Offset: 0x00000D7F
		public WebhookMessage WithEmbed(WebhookEmbed embed)
		{
			this.embeds.Add(embed);
			return this;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010660 File Offset: 0x0000E860
		public WebhookEmbed PassEmbed()
		{
			WebhookEmbed webhookEmbed = new WebhookEmbed(this);
			this.embeds.Add(webhookEmbed);
			return webhookEmbed;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002B8E File Offset: 0x00000D8E
		public WebhookMessage WithUsername(string un)
		{
			this.username = un;
			return this;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002B98 File Offset: 0x00000D98
		public WebhookMessage WithAvatar(string avatar)
		{
			this.avatar_url = avatar;
			return this;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public WebhookMessage WithContent(string c)
		{
			this.content = c;
			return this;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002BAC File Offset: 0x00000DAC
		public WebhookMessage WithTTS()
		{
			this.tts = true;
			return this;
		}

		// Token: 0x04000147 RID: 327
		public string username;

		// Token: 0x04000148 RID: 328
		public string avatar_url;

		// Token: 0x04000149 RID: 329
		public string content = "";

		// Token: 0x0400014A RID: 330
		public List<WebhookEmbed> embeds = new List<WebhookEmbed>();

		// Token: 0x0400014B RID: 331
		[CompilerGenerated]
		private bool SyRkichcsC;
	}
}
