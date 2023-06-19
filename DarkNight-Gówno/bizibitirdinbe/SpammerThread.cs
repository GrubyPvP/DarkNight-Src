using System;
using System.Threading;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000AA RID: 170
	public static class SpammerThread
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00018D98 File Offset: 0x00016F98
		[Thread]
		public static void Spammer()
		{
			for (;;)
			{
				Thread.Sleep(MiscOptions.SpammerDelay);
				if (MiscOptions.SpammerEnabled & MiscOptions.ChatGlobal)
				{
					ChatManager.sendChat(0, MiscOptions.SpamText);
				}
				if (MiscOptions.SpammerEnabled & MiscOptions.ChatArea)
				{
					ChatManager.sendChat(1, MiscOptions.SpamText);
				}
				if (MiscOptions.SpammerEnabled & MiscOptions.ChatGroup)
				{
					ChatManager.sendChat(2, MiscOptions.SpamText);
				}
				if (MiscOptions.SpammerEnabled & MiscOptions.ChatSay)
				{
					ChatManager.sendChat(4, MiscOptions.SpamText);
				}
			}
		}
	}
}
