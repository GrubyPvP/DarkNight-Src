using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A4 RID: 164
	public static class OV_Provider
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000428D File Offset: 0x0000248D
		[Override(typeof(Provider), "legacyReceiveClient", BindingFlags.Static | BindingFlags.NonPublic, 0)]
		public static void OV_legacyReceiveClient(byte[] packet, int offset, int size)
		{
			if (!OV_Provider.IsConnected)
			{
				OV_Provider.IsConnected = true;
			}
		}

		// Token: 0x040003CB RID: 971
		public static bool IsConnected;
	}
}
