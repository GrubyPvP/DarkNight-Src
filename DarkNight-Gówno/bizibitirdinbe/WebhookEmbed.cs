using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace bizibitirdinbe
{
	// Token: 0x0200003D RID: 61
	public class WebhookEmbed
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002A15 File Offset: 0x00000C15
		internal WebhookEmbed(WebhookMessage parent)
		{
			this.webhookMessage_0 = parent;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002A30 File Offset: 0x00000C30
		public WebhookEmbed()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A44 File Offset: 0x00000C44
		public new WebhookMessage Finalize()
		{
			if (this.webhookMessage_0 == null)
			{
				this.webhookMessage_0 = new WebhookMessage
				{
					embeds = new List<WebhookEmbed>
					{
						this
					}
				};
			}
			return this.webhookMessage_0;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A71 File Offset: 0x00000C71
		public WebhookEmbed WithTitle(string title)
		{
			this.title = title;
			return this;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002A7B File Offset: 0x00000C7B
		public WebhookEmbed WithURL(string value)
		{
			this.url = value;
			return this;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A85 File Offset: 0x00000C85
		public WebhookEmbed WithDescription(string value)
		{
			this.description = value;
			return this;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A8F File Offset: 0x00000C8F
		public WebhookEmbed WithTimestamp(DateTime value)
		{
			this.timestamp = DiscordHelpers.DateTimeToISO(value.ToLocalTime());
			return this;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public WebhookEmbed WithField(string name, string value, bool inline = true)
		{
			this.fields.Add(new WebhookField
			{
				value = value,
				inline = inline,
				name = name
			});
			return this;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002ACC File Offset: 0x00000CCC
		public WebhookEmbed WithImage(string value)
		{
			this.image = new WebhookImage
			{
				url = value
			};
			return this;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002AE1 File Offset: 0x00000CE1
		public WebhookEmbed WithThumbnail(string value)
		{
			this.thumbnail = new WebhookImage
			{
				url = value
			};
			return this;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public WebhookEmbed WithAuthor(string name, string url = null, string icon = null)
		{
			this.author = new WebhookAuthor
			{
				name = name,
				icon_url = icon,
				url = url
			};
			return this;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002B19 File Offset: 0x00000D19
		public WebhookEmbed WithColor(EmbedColor color)
		{
			byte[] array = new byte[4];
			array[0] = color.B;
			array[1] = color.G;
			array[2] = color.R;
			this.color = BitConverter.ToInt32(array, 0);
			return this;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002B49 File Offset: 0x00000D49
		private byte method_0(float float_0)
		{
			return (byte)Math.Round((double)(float_0 * 255f), 0);
		}

		// Token: 0x04000136 RID: 310
		[JsonIgnore]
		private WebhookMessage webhookMessage_0;

		// Token: 0x04000137 RID: 311
		public int color;

		// Token: 0x04000138 RID: 312
		public WebhookAuthor author;

		// Token: 0x04000139 RID: 313
		public string title;

		// Token: 0x0400013A RID: 314
		public string url;

		// Token: 0x0400013B RID: 315
		public string description;

		// Token: 0x0400013C RID: 316
		public List<WebhookField> fields = new List<WebhookField>();

		// Token: 0x0400013D RID: 317
		public WebhookImage image;

		// Token: 0x0400013E RID: 318
		public WebhookImage thumbnail;

		// Token: 0x0400013F RID: 319
		public WebhookFooter footer;

		// Token: 0x04000140 RID: 320
		public string timestamp;
	}
}
