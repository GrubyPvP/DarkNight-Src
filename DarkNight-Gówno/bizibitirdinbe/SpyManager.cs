using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000070 RID: 112
	public class SpyManager
	{
		// Token: 0x0600026B RID: 619 RVA: 0x000169A0 File Offset: 0x00014BA0
		public static void InvokePre()
		{
			foreach (MethodInfo methodInfo in SpyManager.PreSpy)
			{
				methodInfo.Invoke(null, null);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000169F4 File Offset: 0x00014BF4
		public static void InvokePost()
		{
			foreach (MethodInfo methodInfo in SpyManager.PostSpy)
			{
				methodInfo.Invoke(null, null);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00016A48 File Offset: 0x00014C48
		public static void DestroyComponents()
		{
			foreach (Type type in SpyManager.Components)
			{
				Object.Destroy(bizibitirdinbecls.oko.GetComponent(type));
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00016AA8 File Offset: 0x00014CA8
		public static void AddComponents()
		{
			foreach (Type type in SpyManager.Components)
			{
				bizibitirdinbecls.oko.AddComponent(type);
			}
		}

		// Token: 0x040001ED RID: 493
		public static IEnumerable<MethodInfo> PreSpy;

		// Token: 0x040001EE RID: 494
		public static IEnumerable<Type> Components;

		// Token: 0x040001EF RID: 495
		public static IEnumerable<MethodInfo> PostSpy;
	}
}
