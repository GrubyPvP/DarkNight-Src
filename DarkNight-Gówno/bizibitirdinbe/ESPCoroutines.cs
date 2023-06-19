using System;
using System.Collections;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000052 RID: 82
	public static class ESPCoroutines
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00003A33 File Offset: 0x00001C33
		public static IEnumerator DoChams()
		{
			return new ESPCoroutines.<DoChams>d__0(0);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000143FC File Offset: 0x000125FC
		public static void DoChamsGameObject(GameObject pgo, Color32 front, Color32 behind)
		{
			if (!(AssetUtilities.Shaders["chamsLit"] == null))
			{
				Renderer[] componentsInChildren = pgo.GetComponentsInChildren<Renderer>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					if (componentsInChildren[i].material.shader != AssetUtilities.Shaders["chamsLit"] | AssetUtilities.Shaders["Chams"])
					{
						Material[] materials = componentsInChildren[i].materials;
						for (int j = 0; j < materials.Length; j++)
						{
							materials[j].shader = (ESPOptions.ChamsFlat ? AssetUtilities.Shaders["Chams"] : AssetUtilities.Shaders["chamsLit"]);
							materials[j].SetColor("_ColorVisible", new Color32(front.r, front.g, front.b, front.a));
							materials[j].SetColor("_ColorBehind", new Color32(behind.r, behind.g, behind.b, behind.a));
						}
					}
				}
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00014544 File Offset: 0x00012744
		public static void SeeThrough(GameObject pgo)
		{
			if (AssetUtilities.Shaders["SeethroughShader"] == null)
			{
				return;
			}
			Renderer[] componentsInChildren = pgo.GetComponentsInChildren<Renderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i].material.shader != AssetUtilities.Shaders["SeethroughShader"])
				{
					Material[] materials = componentsInChildren[i].materials;
					for (int j = 0; j < materials.Length; j++)
					{
						materials[j].shader = AssetUtilities.Shaders["SeethroughShader"];
					}
				}
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000145E4 File Offset: 0x000127E4
		[OffSpy]
		public static void EnableChams()
		{
			if (!ESPOptions.ChamsFlat)
			{
				return;
			}
			Color32 color = Color.blue;
			Color32 color2 = Color.magenta;
			Color32 color3 = Color.cyan;
			Color32 color4 = Color.green;
			foreach (SteamPlayer steamPlayer in Provider.clients.ToArray())
			{
				Color32 front = FriendUtilities.IsFriendly(steamPlayer.player) ? color : color3;
				Color32 behind = FriendUtilities.IsFriendly(steamPlayer.player) ? color2 : color4;
				Player player = steamPlayer.player;
				if (!(player == null) && !(player == OptimizationVariables.MainPlayer) && !(player.gameObject == null) && !(player.life == null) && !player.life.isDead)
				{
					ESPCoroutines.DoChamsGameObject(player.gameObject, front, behind);
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000146D8 File Offset: 0x000128D8
		[OffSpy]
		public static void smethod_0()
		{
			if (!ESPOptions.Ignore)
			{
				return;
			}
			SteamPlayer[] array = Provider.clients.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				Player player = array[i].player;
				if (!(player == null) && !(player == OptimizationVariables.MainPlayer) && !(player.gameObject == null) && !(player.life == null) && !player.life.isDead)
				{
					ESPCoroutines.SeeThrough(player.gameObject);
				}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00014768 File Offset: 0x00012968
		[OnSpy]
		public static void DisableChams()
		{
			try
			{
				if (!(Shader.Find("Standard/Clothes") == null))
				{
					for (int i = 0; i < Provider.clients.ToArray().Length; i++)
					{
						Player player = Provider.clients.ToArray()[i].player;
						if (!(player == null) && !(player == OptimizationVariables.MainPlayer) && !(player.life == null) && !player.life.isDead)
						{
							Renderer[] componentsInChildren = player.gameObject.GetComponentsInChildren<Renderer>();
							for (int j = 0; j < componentsInChildren.Length; j++)
							{
								Material[] materials = componentsInChildren[j].materials;
								for (int k = 0; k < materials.Length; k++)
								{
									if (materials[k].shader != Shader.Find("Standard/Clothes"))
									{
										if (materials[k].name.Contains("Clothes"))
										{
											materials[k].shader = Shader.Find("Standard/Clothes");
										}
										else
										{
											materials[k].shader = Shader.Find("Standard");
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.Log("RetChams   " + ex.Message);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00003A3B File Offset: 0x00001C3B
		public static IEnumerator UpdateObjectList()
		{
			return new ESPCoroutines.<UpdateObjectList>d__6(0);
		}
	}
}
