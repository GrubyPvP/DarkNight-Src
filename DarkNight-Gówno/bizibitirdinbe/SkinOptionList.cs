using System;
using System.Collections.Generic;

namespace bizibitirdinbe
{
	// Token: 0x02000079 RID: 121
	public class SkinOptionList
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00003DD5 File Offset: 0x00001FD5
		public SkinOptionList(SkinType Type)
		{
			this.Type = Type;
		}

		// Token: 0x04000227 RID: 551
		public SkinType Type;

		// Token: 0x04000228 RID: 552
		public HashSet<Skin> Skins = new HashSet<Skin>();
	}
}
