using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200009B RID: 155
	public static class OV_Input
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00004062 File Offset: 0x00002262
		[OnSpy]
		public static void OnSpied()
		{
			OV_Input.InputEnabled = false;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000406A File Offset: 0x0000226A
		[OffSpy]
		public static void OnEndSpy()
		{
			OV_Input.InputEnabled = true;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00017644 File Offset: 0x00015844
		[Override(typeof(Input), "GetKey", BindingFlags.Static | BindingFlags.Public, 0)]
		public static bool OV_GetKey(KeyCode key)
		{
			bool result;
			if (!DrawUtilities.ShouldRun() || !OV_Input.InputEnabled)
			{
				result = (bool)OverrideUtilities.CallOriginal(null, new object[]
				{
					key
				});
			}
			else if (key == ControlsSettings.primary && TriggerbotOptions.IsFiring)
			{
				result = true;
			}
			else
			{
				bool flag;
				if (key != ControlsSettings.left && key != ControlsSettings.right && key != ControlsSettings.up)
				{
					if (key != ControlsSettings.down)
					{
						flag = false;
						goto IL_79;
					}
				}
				flag = (MiscOptions.SpectatedPlayer != null);
				IL_79:
				result = (!flag && (bool)OverrideUtilities.CallOriginal(null, new object[]
				{
					key
				}));
			}
			return result;
		}

		// Token: 0x040003AB RID: 939
		public static bool InputEnabled = true;
	}
}
