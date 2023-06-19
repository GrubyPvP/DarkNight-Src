using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A8 RID: 168
	public class OV_UseableMelee
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00018BD4 File Offset: 0x00016DD4
		[Override(typeof(UseableMelee), "fire", BindingFlags.Instance | BindingFlags.NonPublic, 0)]
		public static void OV_fire()
		{
			OV_DamageTool.OVType = OverrideType.None;
			if (RaycastOptions.Enabled && MiscOptions.ExtendMeleeRange)
			{
				OV_DamageTool.OVType = OverrideType.SilentAimMelee;
			}
			else if (RaycastOptions.Enabled)
			{
				OV_DamageTool.OVType = OverrideType.SilentAim;
			}
			else if (MiscOptions.ExtendMeleeRange)
			{
				OV_DamageTool.OVType = OverrideType.Extended;
			}
			OverrideUtilities.CallOriginal(OptimizationVariables.MainPlayer.equipment.useable, new object[0]);
			OV_DamageTool.OVType = OverrideType.None;
		}
	}
}
