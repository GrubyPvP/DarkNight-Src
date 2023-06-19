using System;
using System.Collections.Generic;

namespace bizibitirdinbe
{
	// Token: 0x020000C6 RID: 198
	public class ESPVariables
	{
		// Token: 0x040003FB RID: 1019
		public static List<ESPObject> Objects = new List<ESPObject>();

		// Token: 0x040003FC RID: 1020
		public static Queue<ESPBox> DrawBuffer = new Queue<ESPBox>();

		// Token: 0x040003FD RID: 1021
		public static Queue<ESPBox2> DrawBuffer2 = new Queue<ESPBox2>();

		// Token: 0x040003FE RID: 1022
		public static Queue<TracerLine> TracerLine = new Queue<TracerLine>();
	}
}
