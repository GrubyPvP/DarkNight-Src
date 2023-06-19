using System;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000057 RID: 87
	[Component]
	public class HwidChanger : MonoBehaviour
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public void Start()
		{
			HwidChanger.methodhwid = (byte[][])HwidChanger.method.Invoke(null, null);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00014FC0 File Offset: 0x000131C0
		[Override(typeof(LocalHwid), "GetHwids", BindingFlags.Static | BindingFlags.Public, 0)]
		public static byte[][] OV_GetHwids()
		{
			byte[][] array = HwidChanger.methodhwid;
			if (MiscOptions.HwidChanger)
			{
				HwidChanger.CreateRandomHwid();
				array.SetValue(HwidChanger.Hwid1, 0);
				array.SetValue(HwidChanger.Hwid2, 1);
				array.SetValue(HwidChanger.Hwid3, 2);
			}
			return array;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00015004 File Offset: 0x00013204
		public static byte[] CreateRandomHwid2()
		{
			byte[] array = new byte[20];
			for (int i = 0; i < 20; i++)
			{
				array[i] = (byte)Random.Range(0, 256);
			}
			return array;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00015038 File Offset: 0x00013238
		public static void CreateRandomHwid()
		{
			HwidChanger.Hwid1 = new byte[20];
			for (int i = 0; i < 20; i++)
			{
				HwidChanger.Hwid1[i] = (byte)Random.Range(0, 256);
			}
			HwidChanger.Hwid2 = new byte[20];
			for (int j = 0; j < 20; j++)
			{
				HwidChanger.Hwid2[j] = (byte)Random.Range(0, 256);
			}
			HwidChanger.Hwid3 = new byte[20];
			for (int k = 0; k < 20; k++)
			{
				HwidChanger.Hwid3[k] = (byte)Random.Range(0, 256);
			}
		}

		// Token: 0x040001B7 RID: 439
		public static byte[][] methodhwid;

		// Token: 0x040001B8 RID: 440
		public static byte[] Hwid1;

		// Token: 0x040001B9 RID: 441
		public static byte[] Hwid2;

		// Token: 0x040001BA RID: 442
		public static byte[] Hwid3;

		// Token: 0x040001BB RID: 443
		public static MethodBase method = typeof(LocalHwid).GetMethod("InitHwids", BindingFlags.Static | BindingFlags.NonPublic);
	}
}
