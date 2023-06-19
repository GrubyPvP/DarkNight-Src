using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200001B RID: 27
	public class VisualTab
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000B554 File Offset: 0x00009754
		public static void Tab()
		{
			GUILayout.Space(0f);
			GUILayout.BeginArea(new Rect(300f, 0f, 940f, 40f));
			VisualTab.SelectedObject = (ESPTarget)GUI.Toolbar(new Rect(25f, 10f, 680f, 40f), (int)VisualTab.SelectedObject, Main.buttons2.ToArray(), "TabBtn");
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(340f, 330f, 350f, 300f), "Options", "box");
			VisualTab.vector2_2 = GUILayout.BeginScrollView(VisualTab.vector2_2, Array.Empty<GUILayoutOption>());
			switch (VisualTab.SelectedObject)
			{
			case ESPTarget.Player:
				ESPOptions.ShowPlayerWeapon = GUILayout.Toggle(ESPOptions.ShowPlayerWeapon, "Show Weapon", Array.Empty<GUILayoutOption>());
				ESPOptions.showhotbar = GUILayout.Toggle(ESPOptions.showhotbar, "Show Weapon Icon", Array.Empty<GUILayoutOption>());
				ESPOptions.HitboxSize = GUILayout.Toggle(ESPOptions.HitboxSize, "Show Hitbox Size", Array.Empty<GUILayoutOption>());
				ESPOptions.Skeleton = GUILayout.Toggle(ESPOptions.Skeleton, "Skeleton", Array.Empty<GUILayoutOption>());
				if (ESPOptions.showhotbar)
				{
					GUILayout.Label("Pixel Size X: " + ESPOptions.x.ToString(), Array.Empty<GUILayoutOption>());
					ESPOptions.x = (int)GUILayout.HorizontalSlider((float)ESPOptions.x, 10f, 200f, Array.Empty<GUILayoutOption>());
					GUILayout.Label("Pixel Size Y: " + ESPOptions.y.ToString(), Array.Empty<GUILayoutOption>());
					ESPOptions.y = (int)GUILayout.HorizontalSlider((float)ESPOptions.y, 10f, 200f, Array.Empty<GUILayoutOption>());
				}
				ESPOptions.ShowAmmo = GUILayout.Toggle(ESPOptions.ShowAmmo, "Ammo", Array.Empty<GUILayoutOption>());
				if (MiscOptions.ShaderMethod == 1 && GUILayout.Button("ChamsType: Flat", "NavBox", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.ChamsEnabled = false;
					ESPOptions.ChamsFlat = false;
					ESPOptions.Ignore = true;
					MiscOptions.ShaderMethod = 2;
				}
				if (MiscOptions.ShaderMethod == 2 && GUILayout.Button("ChamsType: Xray", "NavBox", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.ChamsEnabled = false;
					ESPOptions.ChamsFlat = false;
					ESPOptions.Ignore = false;
					MiscOptions.ShaderMethod = 0;
				}
				if (MiscOptions.ShaderMethod == 0 && GUILayout.Button("ChamsType: None", "NavBox", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.ChamsEnabled = true;
					ESPOptions.ChamsFlat = true;
					ESPOptions.Ignore = false;
					MiscOptions.ShaderMethod = 1;
				}
				VisualTab.smethod_8(ESPTarget.Player);
				break;
			case ESPTarget.Zombie:
				VisualTab.smethod_8(ESPTarget.Zombie);
				break;
			case ESPTarget.Item:
				VisualTab.smethod_8(ESPTarget.Item);
				break;
			case ESPTarget.Sentry:
				ESPOptions.ShowSentryItem = GUILayout.Toggle(ESPOptions.ShowSentryItem, "Show Sentry Gun", Array.Empty<GUILayoutOption>());
				VisualTab.smethod_8(ESPTarget.Sentry);
				break;
			case ESPTarget.Bed:
				ESPOptions.ClaimNameBed = GUILayout.Toggle(ESPOptions.ClaimNameBed, "Show Claimed State", Array.Empty<GUILayoutOption>());
				VisualTab.smethod_8(ESPTarget.Bed);
				break;
			case ESPTarget.Flag:
				VisualTab.smethod_8(ESPTarget.Flag);
				break;
			case ESPTarget.Vehicle:
				ESPOptions.ShowVehicleLocked = GUILayout.Toggle(ESPOptions.ShowVehicleLocked, "Show Lock State", Array.Empty<GUILayoutOption>());
				ESPOptions.FilterVehicleLocked = GUILayout.Toggle(ESPOptions.FilterVehicleLocked, "Only Display Unlocked Vehicles", Array.Empty<GUILayoutOption>());
				VisualTab.smethod_8(ESPTarget.Vehicle);
				break;
			case ESPTarget.Storage:
				VisualTab.smethod_8(ESPTarget.Storage);
				break;
			case ESPTarget.Airdrop:
				VisualTab.smethod_8(ESPTarget.Airdrop);
				break;
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(700f, 430f, 290f, 200f), "Other", "box");
			GUILayout.Space(5f);
			VisualTab.vector2_1 = GUILayout.BeginScrollView(VisualTab.vector2_1, Array.Empty<GUILayoutOption>());
			MiscOptions.NoGrass = GUILayout.Toggle(MiscOptions.NoGrass, "No Grass", Array.Empty<GUILayoutOption>());
			MiscOptions.NoCloud = GUILayout.Toggle(MiscOptions.NoCloud, "No Cloud", Array.Empty<GUILayoutOption>());
			MiscOptions.NoRain = GUILayout.Toggle(MiscOptions.NoRain, "No Rain", Array.Empty<GUILayoutOption>());
			MiscOptions.NoFog = GUILayout.Toggle(MiscOptions.NoFog, "No Fog", Array.Empty<GUILayoutOption>());
			MiscOptions.NoTree = GUILayout.Toggle(MiscOptions.NoTree, "No Tree", Array.Empty<GUILayoutOption>());
			MiscOptions.GPS = GUILayout.Toggle(MiscOptions.GPS, "Force GPS", Array.Empty<GUILayoutOption>());
			ESPOptions.ShowMap = GUILayout.Toggle(ESPOptions.ShowMap, "Show Player On Map", Array.Empty<GUILayoutOption>());
			MiscOptions.NightVision = GUILayout.Toggle(MiscOptions.NightVision, "Night Mode", Array.Empty<GUILayoutOption>());
			MiscOptions.NightVision2 = GUILayout.Toggle(MiscOptions.NightVision2, "NightVision", Array.Empty<GUILayoutOption>());
			MiscOptions.Compass = GUILayout.Toggle(MiscOptions.Compass, "Force Compass", Array.Empty<GUILayoutOption>());
			GUILayout.EndScrollView();
			GUILayout.EndArea();
			Rect rect = new Rect(340f, 65f, 350f, 250f);
			GUIStyle guistyle = "box";
			GUILayout.BeginArea(rect, Enum.GetName(typeof(ESPTarget), VisualTab.SelectedObject), guistyle);
			GUILayout.Space(5f);
			VisualTab.vector2_0 = GUILayout.BeginScrollView(VisualTab.vector2_0, Array.Empty<GUILayoutOption>());
			switch (VisualTab.SelectedObject)
			{
			case ESPTarget.Player:
				VisualTab.smethod_9(ESPTarget.Player, "Players");
				break;
			case ESPTarget.Zombie:
				VisualTab.smethod_9(ESPTarget.Zombie, "Zombies");
				break;
			case ESPTarget.Item:
				VisualTab.smethod_9(ESPTarget.Item, "Items");
				break;
			case ESPTarget.Sentry:
				VisualTab.smethod_9(ESPTarget.Sentry, "Sentry");
				break;
			case ESPTarget.Bed:
				VisualTab.smethod_9(ESPTarget.Bed, "Beds");
				break;
			case ESPTarget.Flag:
				VisualTab.smethod_9(ESPTarget.Flag, "Claim Flags");
				break;
			case ESPTarget.Vehicle:
				VisualTab.smethod_9(ESPTarget.Vehicle, "Vehicles");
				break;
			case ESPTarget.Storage:
				VisualTab.smethod_9(ESPTarget.Storage, "Storages");
				break;
			case ESPTarget.Airdrop:
				VisualTab.smethod_9(ESPTarget.Airdrop, "Airdrop");
				break;
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(700f, 65f, 290f, 350f), "box");
			switch (VisualTab.SelectedObject)
			{
			case ESPTarget.Player:
				VisualTab.smethod_0(ESPTarget.Player);
				break;
			case ESPTarget.Zombie:
				VisualTab.smethod_1(ESPTarget.Zombie);
				break;
			case ESPTarget.Item:
				VisualTab.smethod_3(ESPTarget.Item);
				break;
			case ESPTarget.Sentry:
				VisualTab.smethod_2(ESPTarget.Sentry);
				break;
			case ESPTarget.Bed:
				VisualTab.fNpuaejOg(ESPTarget.Bed);
				break;
			case ESPTarget.Flag:
				VisualTab.smethod_4(ESPTarget.Flag);
				break;
			case ESPTarget.Vehicle:
				VisualTab.smethod_5(ESPTarget.Vehicle);
				break;
			case ESPTarget.Storage:
				VisualTab.smethod_6(ESPTarget.Storage);
				break;
			case ESPTarget.Airdrop:
				VisualTab.smethod_7(ESPTarget.Airdrop);
				break;
			}
			GUILayout.EndArea();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		private static void smethod_0(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			if (ESPOptions.ChamsEnabled)
			{
				GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.ChPlayer);
			}
			else
			{
				GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.Player);
			}
			if (ESPOptions.Ignore)
			{
				GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.xray);
			}
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 265f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName || ESPOptions.ShowPlayerWeapon)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					(!espvisual.ShowName) ? "" : (" " + bizibitirdinbecls.Name),
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? " - Maplestrike" : "Maplestrike") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000BD88 File Offset: 0x00009F88
		private static void smethod_1(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.zombie);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Zombie" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		private static void smethod_2(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.sentiri);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Sentry" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		private static void smethod_3(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.texture2D_0);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Item" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000C124 File Offset: 0x0000A324
		private static void fNpuaejOg(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.bed);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Bed" : "",
					(!ESPOptions.ShowPlayerWeapon) ? "" : ((espvisual.ShowDistance || espvisual.ShowName) ? "" : ""),
					"</size>"
				}));
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000C258 File Offset: 0x0000A458
		private static void smethod_4(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.flag);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Claim Flag" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000C38C File Offset: 0x0000A58C
		private static void smethod_5(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.vehicle);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Vehicle" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		private static void smethod_6(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.locker);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " Locker" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		private static void smethod_7(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUI.Label(new Rect(25f, 20f, 250f, 400f), Main.airdrop);
			if (espvisual.Boxes)
			{
				T.DrawColorBox(Color.cyan, new Rect(15f, 10f, 260f, 280f), 1);
			}
			if (espvisual.ShowDistance || espvisual.ShowName)
			{
				GUI.Label(new Rect(110f, 300f, 335f, 22f), string.Concat(new string[]
				{
					"<size=",
					espvisual.FixedTextSize.ToString(),
					">",
					espvisual.ShowDistance ? "[50]" : "",
					espvisual.ShowName ? " AIRDROP" : "",
					ESPOptions.ShowPlayerWeapon ? ((espvisual.ShowDistance || espvisual.ShowName) ? "" : "") : "",
					"</size>"
				}));
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000C728 File Offset: 0x0000A928
		private static void smethod_8(ESPTarget esptarget_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUILayout.Space(2f);
			GUILayout.Label("Max Render Distance: " + espvisual.Distance.ToString(), Array.Empty<GUILayoutOption>());
			espvisual.Distance = (float)((int)GUILayout.HorizontalSlider(espvisual.Distance, 0f, 3000f, Array.Empty<GUILayoutOption>()));
			GUILayout.Space(2f);
			GUILayout.Label("Font Size: " + espvisual.FixedTextSize.ToString(), Array.Empty<GUILayoutOption>());
			espvisual.FixedTextSize = (int)GUILayout.HorizontalSlider((float)espvisual.FixedTextSize, 0f, 24f, Array.Empty<GUILayoutOption>());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		private static void smethod_9(ESPTarget esptarget_0, string string_0)
		{
			ESPVisual espvisual = ESPOptions.VisualOptions[(int)esptarget_0];
			GUILayout.Space(2f);
			espvisual.Enabled = GUILayout.Toggle(espvisual.Enabled, string_0 + " ESP Enabled", Array.Empty<GUILayoutOption>());
			espvisual.Boxes = GUILayout.Toggle(espvisual.Boxes, "Box", Array.Empty<GUILayoutOption>());
			espvisual.LineToObject = GUILayout.Toggle(espvisual.LineToObject, "Snaplines", Array.Empty<GUILayoutOption>());
			espvisual.ShowName = GUILayout.Toggle(espvisual.ShowName, "Name", Array.Empty<GUILayoutOption>());
			espvisual.ShowDistance = GUILayout.Toggle(espvisual.ShowDistance, "Distance", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x040000C1 RID: 193
		public static ESPTarget SelectedObject = ESPTarget.Player;

		// Token: 0x040000C2 RID: 194
		private static Vector2 vector2_0;

		// Token: 0x040000C3 RID: 195
		private static Vector2 vector2_1 = new Vector2(0f, 0f);

		// Token: 0x040000C4 RID: 196
		private static Vector2 vector2_2 = new Vector2(0f, 0f);
	}
}
