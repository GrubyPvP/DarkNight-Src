using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000073 RID: 115
	public class ESPObject
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00003D75 File Offset: 0x00001F75
		public ESPObject(ESPTarget t, object o, GameObject go)
		{
			this.Target = t;
			this.Object = o;
			this.GObject = go;
		}

		// Token: 0x040001F4 RID: 500
		public ESPTarget Target;

		// Token: 0x040001F5 RID: 501
		public object Object;

		// Token: 0x040001F6 RID: 502
		public GameObject GObject;
	}
}
