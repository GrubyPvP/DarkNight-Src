using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A3 RID: 163
	public class OV_PlayerQuests
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00004286 File Offset: 0x00002486
		[Override(typeof(PlayerQuests), "isMemberOfSameGroupAs", BindingFlags.Instance | BindingFlags.Public, 0)]
		public bool OV_isMemberOfSameGroupAs(Player player)
		{
			return ESPOptions.ShowMap;
		}
	}
}
