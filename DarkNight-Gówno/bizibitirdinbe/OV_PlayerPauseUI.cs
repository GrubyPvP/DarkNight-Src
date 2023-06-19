using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A2 RID: 162
	public static class OV_PlayerPauseUI
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00004269 File Offset: 0x00002469
		[Override(typeof(PlayerPauseUI), "onClickedExitButton", BindingFlags.Static | BindingFlags.NonPublic, 0)]
		public static void OV_onClickedExitButton(ISleekElement button)
		{
			Provider.disconnect();
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00004270 File Offset: 0x00002470
		[Override(typeof(PlayerPauseUI), "onClickedSuicideButton", BindingFlags.Static | BindingFlags.NonPublic, 0)]
		public static void OV_onClickedSuicideButton(ISleekElement button)
		{
			PlayerPauseUI.closeAndGotoAppropriateHUD();
			Player.player.life.sendSuicide();
		}
	}
}
