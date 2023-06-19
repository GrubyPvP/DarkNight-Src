using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000015 RID: 21
	public class NotificationWindow
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00009620 File Offset: 0x00007820
		public void Run()
		{
			GUI.skin = AssetUtilities.Skin;
			if (DateTimeOffset.Now.ToUnixTimeMilliseconds() > this.long_0)
			{
				T.Notifications.Remove(this);
				return;
			}
			if (100L > this.long_0 - DateTimeOffset.Now.ToUnixTimeMilliseconds())
			{
				long num = (this.long_0 - DateTimeOffset.Now.ToUnixTimeMilliseconds()) * 3L;
				GUI.Window(this.NotificationNum + 10, new Rect((float)((long)Screen.width - num), (float)(250 + 70 * this.NotificationNum), (float)num, 60f), new GUI.WindowFunction(this.method_0), "", "verticalsliderthumb");
				return;
			}
			GUI.Window(this.NotificationNum + 10, new Rect((float)(Screen.width - 250), (float)(250 + 70 * this.NotificationNum), 300f, 60f), new GUI.WindowFunction(this.method_0), "", "verticalsliderthumb");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00009744 File Offset: 0x00007944
		private void method_0(int int_0)
		{
			GUI.Label(new Rect(25f, 25f, 260f, 70f), "<size=20>" + this.info + "</size>");
			GUI.DrawTexture(new Rect(300f - (float)(this.long_0 - DateTimeOffset.Now.ToUnixTimeMilliseconds() - 100L) / 9900f * 300f, 50f, 300f, 10f), AssetUtilities.Skin.verticalScrollbar.normal.background, 0);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000097E8 File Offset: 0x000079E8
		public NotificationWindow()
		{
			this.long_0 = DateTimeOffset.Now.ToUnixTimeMilliseconds() + 3000L;
		}

		// Token: 0x040000A9 RID: 169
		public string info;

		// Token: 0x040000AA RID: 170
		private long long_0;

		// Token: 0x040000AB RID: 171
		public int NotificationNum = T.Notifications.Count + 1;
	}
}
