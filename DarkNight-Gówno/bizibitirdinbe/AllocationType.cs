using System;

namespace bizibitirdinbe
{
	// Token: 0x0200007B RID: 123
	[Flags]
	public enum AllocationType : uint
	{
		// Token: 0x0400022C RID: 556
		COMMIT = 4096U,
		// Token: 0x0400022D RID: 557
		RESERVE = 8192U,
		// Token: 0x0400022E RID: 558
		RESET = 524288U,
		// Token: 0x0400022F RID: 559
		LARGE_PAGES = 536870912U,
		// Token: 0x04000230 RID: 560
		PHYSICAL = 4194304U,
		// Token: 0x04000231 RID: 561
		TOP_DOWN = 1048576U,
		// Token: 0x04000232 RID: 562
		WRITE_WATCH = 2097152U
	}
}
