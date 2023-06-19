using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x0200009E RID: 158
	public class OV_PlayerEquipment
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000040AA File Offset: 0x000022AA
		[Override(typeof(PlayerEquipment), "punch", BindingFlags.Instance | BindingFlags.NonPublic, 0)]
		public void OV_punch(EPlayerPunch p)
		{
			if (MiscOptions.PunchSilentAim)
			{
				OV_DamageTool.OVType = OverrideType.PlayerHit;
			}
			OverrideUtilities.CallOriginal(OptimizationVariables.MainPlayer.equipment, new object[]
			{
				p
			});
			OV_DamageTool.OVType = OverrideType.None;
		}

		// Token: 0x040003AE RID: 942
		public static bool WasPunching;

		// Token: 0x040003AF RID: 943
		public static uint CurrSim;
	}
}
