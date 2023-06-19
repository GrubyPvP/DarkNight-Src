using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x0200009D RID: 157
	public static class OV_LevelLighting
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x0000407B File Offset: 0x0000227B
		[OnSpy]
		public static void Disable()
		{
			if (DrawUtilities.ShouldRun())
			{
				OV_LevelLighting.OV_updateLighting();
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000407B File Offset: 0x0000227B
		[OffSpy]
		public static void Enable()
		{
			if (DrawUtilities.ShouldRun())
			{
				OV_LevelLighting.OV_updateLighting();
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000408C File Offset: 0x0000228C
		[Initializer]
		public static void Init()
		{
			OV_LevelLighting.Time = typeof(LevelLighting).GetField("_time", BindingFlags.Static | BindingFlags.NonPublic);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00017764 File Offset: 0x00015964
		[Override(typeof(LevelLighting), "updateLighting", BindingFlags.Static | BindingFlags.Public, 0)]
		public static void OV_updateLighting()
		{
			float time = LevelLighting.time;
			if (!DrawUtilities.ShouldRun() || !MiscOptions.SetTimeEnabled || G.BeingSpied)
			{
				OverrideUtilities.CallOriginal(null, new object[0]);
				return;
			}
			OV_LevelLighting.Time.SetValue(null, MiscOptions.Time);
			OverrideUtilities.CallOriginal(null, new object[0]);
			OV_LevelLighting.Time.SetValue(null, time);
		}

		// Token: 0x040003AC RID: 940
		public static FieldInfo Time;

		// Token: 0x040003AD RID: 941
		public static bool WasEnabled;
	}
}
