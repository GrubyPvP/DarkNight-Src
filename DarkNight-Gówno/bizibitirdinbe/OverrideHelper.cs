using System;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000B9 RID: 185
	public class OverrideHelper
	{
		// Token: 0x06000319 RID: 793
		[DllImport("mono.dll", CallingConvention = CallingConvention.FastCall)]
		private static extern IntPtr mono_domain_get();

		// Token: 0x0600031A RID: 794
		[DllImport("mono.dll", CallingConvention = CallingConvention.FastCall)]
		private static extern IntPtr mono_method_get_header(IntPtr intptr_0);

		// Token: 0x0600031B RID: 795 RVA: 0x0001B664 File Offset: 0x00019864
		public static void RedirectCalls(MethodInfo from, MethodInfo to)
		{
			IntPtr functionPointer = from.MethodHandle.GetFunctionPointer();
			IntPtr functionPointer2 = to.MethodHandle.GetFunctionPointer();
			OverrideHelper.smethod_1(functionPointer, functionPointer2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001B698 File Offset: 0x00019898
		private unsafe static void smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
		{
			IntPtr value = methodInfo_0.MethodHandle.Value;
			IntPtr value2 = methodInfo_1.MethodHandle.Value;
			methodInfo_0.MethodHandle.GetFunctionPointer();
			methodInfo_1.MethodHandle.GetFunctionPointer();
			byte* ptr = (byte*)OverrideHelper.mono_domain_get().ToPointer() + 232;
			long** ptr2 = *(IntPtr*)((byte*)ptr + 32);
			uint num = *(uint*)((byte*)ptr + 24);
			void* ptr3 = null;
			void* ptr4 = null;
			long num2 = value.ToInt64();
			uint num3 = (uint)num2 >> 3;
			for (long* ptr5 = *(IntPtr*)(ptr2 + (ulong)(num3 % num) * (ulong)((long)sizeof(long*)) / (ulong)sizeof(long*)); ptr5 != null; ptr5 = *(IntPtr*)(ptr5 + 1))
			{
				if (num2 == *ptr5)
				{
					ptr3 = (void*)ptr5;
					IL_AE:
					long num4 = value2.ToInt64();
					uint num5 = (uint)num4 >> 3;
					for (long* ptr6 = *(IntPtr*)(ptr2 + (ulong)(num5 % num) * (ulong)((long)sizeof(long*)) / (ulong)sizeof(long*)); ptr6 != null; ptr6 = *(IntPtr*)(ptr6 + 1))
					{
						if (num4 == *ptr6)
						{
							ptr4 = (void*)ptr6;
							IL_F1:
							if (ptr3 != null)
							{
								if (ptr4 != null)
								{
									ulong* ptr7 = (ulong*)ptr3;
									ulong* ptr8 = (ulong*)ptr4;
									ptr7[2] = ptr8[2];
									ptr7[3] = ptr8[3];
									return;
								}
							}
							Debug.Log("Could not find methods");
							return;
						}
					}
					goto IL_F1;
				}
			}
			goto IL_AE;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001B7D8 File Offset: 0x000199D8
		private unsafe static void smethod_1(IntPtr intptr_0, IntPtr intptr_1)
		{
			byte* ptr = (byte*)intptr_0.ToPointer();
			*ptr = 73;
			ptr[1] = 187;
			*(long*)(ptr + 2) = intptr_1.ToInt64();
			ptr[10] = 65;
			ptr[11] = byte.MaxValue;
			ptr[12] = 227;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001B828 File Offset: 0x00019A28
		private unsafe static void smethod_2(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
		{
			IntPtr value = methodInfo_0.MethodHandle.Value;
			IntPtr value2 = methodInfo_1.MethodHandle.Value;
			OverrideHelper.mono_method_get_header(value2);
			byte* ptr = (byte*)value.ToPointer();
			byte* ptr2 = (byte*)value2.ToPointer();
			*(IntPtr*)(ptr + 40) = *(IntPtr*)(ptr2 + 40);
		}
	}
}
