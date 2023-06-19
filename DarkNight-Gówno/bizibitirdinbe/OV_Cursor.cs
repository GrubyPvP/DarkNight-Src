using System;
using System.Reflection;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000098 RID: 152
	public static class OV_Cursor
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00004021 File Offset: 0x00002221
		[Override(typeof(Cursor), "set_lockState", BindingFlags.Static | BindingFlags.Public, 0)]
		public static void OV_set_lockState(CursorLockMode rMode)
		{
			if (!MenuComponent.IsInMenu || G.BeingSpied || (rMode != 2 && rMode != 1))
			{
				OverrideUtilities.CallOriginal(null, new object[]
				{
					rMode
				});
			}
		}
	}
}
