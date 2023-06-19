using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000003 RID: 3
	public class Manager : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00006470 File Offset: 0x00004670
		private void Start()
		{
			T.DrawMaterial = new Material(Shader.Find("Hidden/Internal-Colored"))
			{
				hideFlags = 61
			};
			T.DrawMaterial.SetInt("_SrcBlend", 5);
			T.DrawMaterial.SetInt("_DstBlend", 10);
			T.DrawMaterial.SetInt("_Cull", 0);
			T.DrawMaterial.SetInt("_ZWrite", 0);
			AssetUtilities.GetAssets();
			ConfigManager.Init();
			AttributeManager.Init();
		}
	}
}
