using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace bizibitirdinbe
{
	// Token: 0x020000CF RID: 207
	public class OverrideWrapper
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000047B7 File Offset: 0x000029B7
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000047BF File Offset: 0x000029BF
		public MethodInfo Original { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000047C8 File Offset: 0x000029C8
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000047D0 File Offset: 0x000029D0
		public MethodInfo Modified { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000047D9 File Offset: 0x000029D9
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000047E1 File Offset: 0x000029E1
		public IntPtr PtrOriginal { get; private set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000047EA File Offset: 0x000029EA
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000047F2 File Offset: 0x000029F2
		public IntPtr PtrModified { get; private set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000047FB File Offset: 0x000029FB
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00004803 File Offset: 0x00002A03
		public OverrideUtilities.OffsetBackup OffsetBackup { get; private set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000480C File Offset: 0x00002A0C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00004814 File Offset: 0x00002A14
		public OverrideAttribute Attribute { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000481D File Offset: 0x00002A1D
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00004825 File Offset: 0x00002A25
		public bool Detoured { get; private set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000482E File Offset: 0x00002A2E
		public object Instance { get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00004836 File Offset: 0x00002A36
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000483E File Offset: 0x00002A3E
		public bool Local { get; private set; }

		// Token: 0x06000371 RID: 881 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public OverrideWrapper(MethodInfo original, MethodInfo modified, OverrideAttribute attribute, object instance = null)
		{
			try
			{
				this.Original = original;
				this.Modified = modified;
				this.Instance = instance;
				this.Attribute = attribute;
				this.Local = (this.Modified.DeclaringType.Assembly == Assembly.GetExecutingAssembly());
				RuntimeHelpers.PrepareMethod(original.MethodHandle);
				RuntimeHelpers.PrepareMethod(modified.MethodHandle);
				this.PtrOriginal = this.Original.MethodHandle.GetFunctionPointer();
				this.PtrModified = this.Modified.MethodHandle.GetFunctionPointer();
				this.OffsetBackup = new OverrideUtilities.OffsetBackup(this.PtrOriginal);
				this.Detoured = false;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001D080 File Offset: 0x0001B280
		public bool Override()
		{
			bool result;
			if (this.Detoured)
			{
				result = true;
			}
			else
			{
				bool flag = OverrideUtilities.OverrideFunction(this.PtrOriginal, this.PtrModified);
				if (flag)
				{
					this.Detoured = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001D0BC File Offset: 0x0001B2BC
		public bool Revert()
		{
			bool result;
			if (!this.Detoured)
			{
				result = false;
			}
			else
			{
				bool flag = OverrideUtilities.RevertOverride(this.OffsetBackup);
				if (flag)
				{
					this.Detoured = false;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004847 File Offset: 0x00002A47
		public object CallOriginal(object[] args, object instance = null)
		{
			this.Revert();
			object result = this.Original.Invoke(instance ?? this.Instance, args);
			this.Override();
			return result;
		}

		// Token: 0x0400041A RID: 1050
		[CompilerGenerated]
		private MethodInfo methodInfo_0;

		// Token: 0x0400041B RID: 1051
		[CompilerGenerated]
		private MethodInfo methodInfo_1;

		// Token: 0x0400041C RID: 1052
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x0400041D RID: 1053
		[CompilerGenerated]
		private IntPtr intptr_1;

		// Token: 0x0400041E RID: 1054
		[CompilerGenerated]
		private OverrideUtilities.OffsetBackup offsetBackup_0;

		// Token: 0x0400041F RID: 1055
		[CompilerGenerated]
		private OverrideAttribute overrideAttribute_0;

		// Token: 0x04000420 RID: 1056
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000421 RID: 1057
		[CompilerGenerated]
		private readonly object object_0;

		// Token: 0x04000422 RID: 1058
		[CompilerGenerated]
		private bool bool_1;
	}
}
