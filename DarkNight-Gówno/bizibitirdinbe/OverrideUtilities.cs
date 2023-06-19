using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace bizibitirdinbe
{
	// Token: 0x020000BA RID: 186
	public static class OverrideUtilities
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0001B880 File Offset: 0x00019A80
		public static object CallOriginalFunc(MethodInfo method, object instance = null, params object[] args)
		{
			OverrideUtilities.<>c__DisplayClass0_0 CS$<>8__locals1 = new OverrideUtilities.<>c__DisplayClass0_0();
			CS$<>8__locals1.methodInfo_0 = method;
			OverrideManager overrideManager = new OverrideManager();
			if (overrideManager.Overrides.All(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_0)))
			{
				throw new Exception("The Override specified was not found!");
			}
			return overrideManager.Overrides.First(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_1)).Value.CallOriginal(args, instance);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		public static object CallOriginal(object instance = null, params object[] args)
		{
			OverrideUtilities.<>c__DisplayClass1_0 CS$<>8__locals1 = new OverrideUtilities.<>c__DisplayClass1_0();
			OverrideManager overrideManager = new OverrideManager();
			StackTrace stackTrace = new StackTrace(false);
			if (stackTrace.FrameCount < 1)
			{
				throw new Exception("Invalid trace back to the original method! Please provide the methodinfo instead!");
			}
			MethodBase method = stackTrace.GetFrame(1).GetMethod();
			CS$<>8__locals1.methodInfo_0 = null;
			if (!Attribute.IsDefined(method, typeof(OverrideAttribute)))
			{
				method = stackTrace.GetFrame(2).GetMethod();
			}
			OverrideAttribute overrideAttribute = (OverrideAttribute)Attribute.GetCustomAttribute(method, typeof(OverrideAttribute));
			if (overrideAttribute == null)
			{
				throw new Exception("This method can only be called from an overwritten method!");
			}
			if (!overrideAttribute.MethodFound)
			{
				throw new Exception("The original method was never found!");
			}
			CS$<>8__locals1.methodInfo_0 = overrideAttribute.Method;
			if (overrideManager.Overrides.All(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_0)))
			{
				throw new Exception("The Override specified was not found!");
			}
			return overrideManager.Overrides.First(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_1)).Value.CallOriginal(args, instance);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001BA04 File Offset: 0x00019C04
		public static bool EnableOverride(MethodInfo method)
		{
			OverrideUtilities.<>c__DisplayClass2_0 CS$<>8__locals1 = new OverrideUtilities.<>c__DisplayClass2_0();
			CS$<>8__locals1.methodInfo_0 = method;
			OverrideWrapper value = new OverrideManager().Overrides.First(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_0)).Value;
			return value != null && value.Override();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001BA54 File Offset: 0x00019C54
		public static bool DisableOverride(MethodInfo method)
		{
			OverrideUtilities.<>c__DisplayClass3_0 CS$<>8__locals1 = new OverrideUtilities.<>c__DisplayClass3_0();
			CS$<>8__locals1.methodInfo_0 = method;
			OverrideWrapper value = new OverrideManager().Overrides.First(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_0)).Value;
			return value != null && value.Revert();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		public unsafe static bool OverrideFunction(IntPtr ptrOriginal, IntPtr ptrModified)
		{
			bool result;
			try
			{
				int size = IntPtr.Size;
				if (size != 4)
				{
					if (size != 8)
					{
						return false;
					}
					byte* ptr = (byte*)ptrOriginal.ToPointer();
					*ptr = 72;
					ptr[1] = 184;
					*(long*)(ptr + 2) = ptrModified.ToInt64();
					ptr[10] = byte.MaxValue;
					ptr[11] = 224;
				}
				else
				{
					byte* ptr2 = (byte*)ptrOriginal.ToPointer();
					*ptr2 = 104;
					*(int*)(ptr2 + 1) = ptrModified.ToInt32();
					ptr2[5] = 195;
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001BB48 File Offset: 0x00019D48
		public unsafe static bool RevertOverride(OverrideUtilities.OffsetBackup backup)
		{
			bool result;
			try
			{
				byte* ptr = (byte*)backup.Method.ToPointer();
				*ptr = backup.A;
				ptr[1] = backup.B;
				ptr[10] = backup.C;
				ptr[11] = backup.D;
				ptr[12] = backup.E;
				if (IntPtr.Size == 4)
				{
					*(int*)(ptr + 1) = (int)backup.F32;
					ptr[5] = backup.G;
				}
				else
				{
					*(long*)(ptr + 2) = (long)backup.F64;
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x020000BB RID: 187
		public class OffsetBackup
		{
			// Token: 0x06000326 RID: 806 RVA: 0x0001BBE4 File Offset: 0x00019DE4
			public unsafe OffsetBackup(IntPtr method)
			{
				this.Method = method;
				byte* ptr = (byte*)method.ToPointer();
				this.A = *ptr;
				this.B = ptr[1];
				this.C = ptr[10];
				this.D = ptr[11];
				this.E = ptr[12];
				if (IntPtr.Size == 4)
				{
					this.F32 = *(uint*)(ptr + 1);
					this.G = ptr[5];
					return;
				}
				this.F64 = (ulong)(*(long*)(ptr + 2));
			}

			// Token: 0x040003DE RID: 990
			public IntPtr Method;

			// Token: 0x040003DF RID: 991
			public byte A;

			// Token: 0x040003E0 RID: 992
			public byte B;

			// Token: 0x040003E1 RID: 993
			public byte C;

			// Token: 0x040003E2 RID: 994
			public byte D;

			// Token: 0x040003E3 RID: 995
			public byte E;

			// Token: 0x040003E4 RID: 996
			public byte G;

			// Token: 0x040003E5 RID: 997
			public ulong F64;

			// Token: 0x040003E6 RID: 998
			public uint F32;
		}
	}
}
