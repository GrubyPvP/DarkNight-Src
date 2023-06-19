using System;

namespace bizibitirdinbe
{
	// Token: 0x0200007E RID: 126
	[Flags]
	public enum MemoryProtection : uint
	{
		// Token: 0x04000248 RID: 584
		EXECUTE = 16U,
		// Token: 0x04000249 RID: 585
		EXECUTE_READ = 32U,
		// Token: 0x0400024A RID: 586
		EXECUTE_READWRITE = 64U,
		// Token: 0x0400024B RID: 587
		EXECUTE_WRITECOPY = 128U,
		// Token: 0x0400024C RID: 588
		NOACCESS = 1U,
		// Token: 0x0400024D RID: 589
		READONLY = 2U,
		// Token: 0x0400024E RID: 590
		READWRITE = 4U,
		// Token: 0x0400024F RID: 591
		WRITECOPY = 8U,
		// Token: 0x04000250 RID: 592
		GUARD_Modifierflag = 256U,
		// Token: 0x04000251 RID: 593
		NOCACHE_Modifierflag = 512U,
		// Token: 0x04000252 RID: 594
		WRITECOMBINE_Modifierflag = 1024U
	}
}
