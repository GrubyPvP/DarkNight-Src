using System;

namespace bizibitirdinbe
{
	// Token: 0x0200007A RID: 122
	public class WeaponSave
	{
		// Token: 0x06000279 RID: 633 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public WeaponSave(ushort WeaponID, int SkinID)
		{
			this.WeaponID = WeaponID;
			this.SkinID = SkinID;
		}

		// Token: 0x04000229 RID: 553
		public ushort WeaponID;

		// Token: 0x0400022A RID: 554
		public int SkinID;
	}
}
