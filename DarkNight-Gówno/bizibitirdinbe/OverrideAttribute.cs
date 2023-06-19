using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace bizibitirdinbe
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Method)]
	public class OverrideAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000024B7 File Offset: 0x000006B7
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000024BF File Offset: 0x000006BF
		public Type Class { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000024C8 File Offset: 0x000006C8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000024D0 File Offset: 0x000006D0
		public string MethodName { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000024E1 File Offset: 0x000006E1
		public MethodInfo Method { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000024EA File Offset: 0x000006EA
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000024F2 File Offset: 0x000006F2
		public BindingFlags Flags { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000024FB File Offset: 0x000006FB
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002503 File Offset: 0x00000703
		public bool MethodFound { get; private set; }

		// Token: 0x0600005C RID: 92 RVA: 0x0000C890 File Offset: 0x0000AA90
		public OverrideAttribute(Type tClass, string method, BindingFlags flags, int index = 0)
		{
			OverrideAttribute.<>c__DisplayClass20_0 CS$<>8__locals1 = new OverrideAttribute.<>c__DisplayClass20_0();
			CS$<>8__locals1.string_0 = method;
			base..ctor();
			this.Class = tClass;
			this.MethodName = CS$<>8__locals1.string_0;
			this.Flags = flags;
			try
			{
				this.Method = this.Class.GetMethods(flags).Where(new Func<MethodInfo, bool>(CS$<>8__locals1.method_0)).ToArray<MethodInfo>()[index];
				this.MethodFound = true;
			}
			catch (Exception)
			{
				this.MethodFound = false;
			}
		}

		// Token: 0x040000C5 RID: 197
		[CompilerGenerated]
		private Type xlgJpohYd;

		// Token: 0x040000C6 RID: 198
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000C7 RID: 199
		[CompilerGenerated]
		private MethodInfo methodInfo_0;

		// Token: 0x040000C8 RID: 200
		[CompilerGenerated]
		private BindingFlags bindingFlags_0;

		// Token: 0x040000C9 RID: 201
		[CompilerGenerated]
		private bool bool_0;
	}
}
