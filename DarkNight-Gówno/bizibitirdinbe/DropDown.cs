using System;
using System.Collections.Generic;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000CC RID: 204
	public class DropDown
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00004757 File Offset: 0x00002957
		public DropDown()
		{
			this.IsEnabled = false;
			this.ListIndex = 0;
			this.ScrollView = Vector2.zero;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001CF7C File Offset: 0x0001B17C
		public static DropDown Get(string identifier)
		{
			DropDown dropDown;
			DropDown result;
			if (!DropDown.DropDownManager.TryGetValue(identifier, out dropDown))
			{
				dropDown = new DropDown();
				DropDown.DropDownManager.Add(identifier, dropDown);
				result = dropDown;
			}
			else
			{
				result = dropDown;
			}
			return result;
		}

		// Token: 0x04000411 RID: 1041
		public static Dictionary<string, DropDown> DropDownManager = new Dictionary<string, DropDown>();

		// Token: 0x04000412 RID: 1042
		public bool IsEnabled;

		// Token: 0x04000413 RID: 1043
		public int ListIndex;

		// Token: 0x04000414 RID: 1044
		public Vector2 ScrollView;
	}
}
