using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000013 RID: 19
	[Component]
	public class Main : MonoBehaviour
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00007424 File Offset: 0x00005624
		private void Start()
		{
			Main.GUIColor = GUI.color;
			foreach (object obj in Enum.GetValues(typeof(MenuTab)))
			{
				MenuTab menuTab = (MenuTab)obj;
				Main.buttons.Add(new GUIContent(Enum.GetName(typeof(MenuTab), menuTab)));
			}
			foreach (object obj2 in Enum.GetValues(typeof(ESPTarget)))
			{
				ESPTarget esptarget = (ESPTarget)obj2;
				Main.buttons2.Add(new GUIContent(Enum.GetName(typeof(ESPTarget), esptarget)));
			}
			foreach (object obj3 in Enum.GetValues(typeof(SkinType)))
			{
				SkinType skinType = (SkinType)obj3;
				Main.buttons7.Add(new GUIContent(Enum.GetName(typeof(SkinType), skinType)));
			}
			foreach (object obj4 in Enum.GetValues(typeof(SettingsOptions)))
			{
				SettingsOptions settingsOptions = (SettingsOptions)obj4;
				Main.buttons4.Add(new GUIContent(Enum.GetName(typeof(SettingsOptions), settingsOptions)));
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000075FC File Offset: 0x000057FC
		[Initializer]
		public static void Initialize()
		{
			HotkeyUtilities.AddHotkey("Menu", "Menu Key", "_MenuComponent", new KeyCode[]
			{
				282
			});
			HotkeyUtilities.AddHotkey("FreeCam", "Admin Cam", "_Cam", new KeyCode[]
			{
				283
			});
			HotkeyUtilities.AddHotkey("Server", "Server Quick Disconnect", "_Çık", new KeyCode[]
			{
				286
			});
			HotkeyUtilities.AddHotkey("Aimbot", "Aimbot Key", "_AimbotKey", new KeyCode[]
			{
				102
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Vehicle Fly On/Off", "_VFToggle", new KeyCode[]
			{
				301
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Forward", "_VFMoveForward", new KeyCode[]
			{
				119
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Backward", "_VFMoveBackward", new KeyCode[]
			{
				115
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Left", "_VFRotateLeft", new KeyCode[]
			{
				97
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Right", "_VFRotateRight", new KeyCode[]
			{
				100
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Up", "_VFStrafeUp", new KeyCode[]
			{
				32
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Down", "_VFStrafeDown", new KeyCode[]
			{
				306
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Rotate Up", "_VFRotateUp", new KeyCode[]
			{
				273
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Rotate Down", "_VFRotateDown", new KeyCode[]
			{
				274
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Roll Left", "_VFRollLeft", new KeyCode[]
			{
				276
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Roll Right", "_VFRollRight", new KeyCode[]
			{
				275
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Strafe Left", "_VFStrafeLeft", new KeyCode[]
			{
				113
			});
			HotkeyUtilities.AddHotkey("Vehicle Fly", "Strafe Right", "_VFStrafeRight", new KeyCode[]
			{
				101
			});
			HotkeyUtilities.AddHotkey("Fly", "Fly Open/Close", "_Uç", new KeyCode[]
			{
				285
			});
			HotkeyUtilities.AddHotkey("Fly", "Up", "_FlyUp", new KeyCode[]
			{
				32
			});
			HotkeyUtilities.AddHotkey("Fly", "Down", "_FlyDown", new KeyCode[]
			{
				306
			});
			HotkeyUtilities.AddHotkey("Fly", "Left", "_FlyLeft", new KeyCode[]
			{
				97
			});
			HotkeyUtilities.AddHotkey("Fly", "Right", "_FlyRight", new KeyCode[]
			{
				100
			});
			HotkeyUtilities.AddHotkey("Fly", "Forward", "_FlyForward", new KeyCode[]
			{
				119
			});
			HotkeyUtilities.AddHotkey("Fly", "Backward", "_FlyBackward", new KeyCode[]
			{
				115
			});
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00007914 File Offset: 0x00005B14
		private void Update()
		{
			Main.Initialize();
			if ((HotkeyOptions.UnorganizedHotkeys["_MenuComponent"].Keys.Length == 0 && Input.GetKeyDown(Main.MenuKey)) || HotkeyUtilities.IsHotkeyDown("_MenuComponent"))
			{
				if (!Main.MenuOpen)
				{
					Main.MenuOpen = true;
					return;
				}
				Main.MenuOpen = false;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000796C File Offset: 0x00005B6C
		private void OnGUI()
		{
			if (!G.BeingSpied)
			{
				foreach (NotificationWindow notificationWindow in T.Notifications)
				{
					notificationWindow.Run();
				}
				if (Main.MenuOpen)
				{
					GUI.skin = AssetUtilities.Skin;
					if (this.texture_0 == null)
					{
						this.texture_0 = AssetUtilities.Textures["indir"];
					}
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 122f, 32f, 32f), Main._Aimbot);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 183f, 32f, 32f), Main._Visual);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 245f, 32f, 32f), Main._Other);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 305f, 32f, 32f), Main._Player);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 370f, 40f, 40f), Main._Skin);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 430f, 32f, 32f), Main._Settings);
					GUI.Label(new Rect(this.rect_0.x + 80f, this.rect_0.y + 493f, 32f, 32f), Main._Keyboard);
					GUI.Label(new Rect(this.rect_0.x + 124f, this.rect_0.y + 27f, 500f, 70f), "<size=30><b>DarkShite</b></size>");
					GUI.Label(new Rect(this.rect_0.x + 17f, this.rect_0.y + -11f, 120f, 120f), Main._Logo2);
					GUI.Label(new Rect(this.rect_0.x + 100f, this.rect_0.y + 575f, 150f, 100f), "<size=15><b>" + bizibitirdinbecls.Name + "</b></size>");
					GUI.Label(new Rect(this.rect_0.x + 100f, this.rect_0.y + 595f, 150f, 100f), string.Format("<size=15><b>{0} Day Left</b></size>", bizibitirdinbecls.int_0));
					GUI.Label(new Rect(this.rect_0.x + 35f, this.rect_0.y + 570f, 50f, 50f), Main._User);
					GUI.depth = -1;
					GUIStyle guistyle = new GUIStyle("label");
					guistyle.margin = new RectOffset(10, 10, 5, 5);
					guistyle.fontSize = 22;
					this.rect_0 = GUILayout.Window(0, this.rect_0, new GUI.WindowFunction(this.method_0), "", Array.Empty<GUILayoutOption>());
					GUI.depth = -2;
					Main.CursorPos.x = Input.mousePosition.x;
					Main.CursorPos.y = (float)Screen.height - Input.mousePosition.y;
					GUI.DrawTexture(Main.CursorPos, this.texture_0);
					Cursor.lockState = 0;
					if (PlayerUI.window != null)
					{
						PlayerUI.window.showCursor = true;
					}
					GUI.skin = null;
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00007D98 File Offset: 0x00005F98
		private void method_0(int int_0)
		{
			GUILayout.Space(0f);
			switch (Main.SelectedTab)
			{
			case MenuTab.Aimbot:
				AimbotTab.Tab();
				break;
			case MenuTab.Visuals:
				VisualTab.Tab();
				break;
			case MenuTab.Misc:
				MiscTab.Tab();
				break;
			case MenuTab.Players:
				PlayersTab.Tab();
				break;
			case MenuTab.Skins:
				SkinsTab.Tab();
				break;
			case MenuTab.Settings:
				SettingsTab.Tab();
				break;
			case MenuTab.const_6:
				HotkeyTab.Tab();
				break;
			}
			GUILayout.BeginArea(new Rect(35f, 108f, 260f, 500f));
			int fontSize = GUI.skin.button.fontSize;
			GUI.skin.button.fixedHeight = 58f;
			GUI.skin.button.fontSize = 20;
			Main.SelectedTab = (MenuTab)GUILayout.SelectionGrid((int)Main.SelectedTab, Main.buttons.ToArray(), 1, Array.Empty<GUILayoutOption>());
			GUI.skin.button.fixedHeight = 40f;
			GUI.skin.button.fontSize = fontSize;
			GUILayout.EndArea();
			GUI.DragWindow();
		}

		// Token: 0x04000074 RID: 116
		public static Rect rect = new Rect(10f, 10f, 0f, 0f);

		// Token: 0x04000075 RID: 117
		public static GUIStyleState guiStyleState;

		// Token: 0x04000076 RID: 118
		public static GUIStyle guiStyle;

		// Token: 0x04000077 RID: 119
		public static KeyCode MenuKey = 282;

		// Token: 0x04000078 RID: 120
		public static MenuTab SelectedTab = MenuTab.Aimbot;

		// Token: 0x04000079 RID: 121
		public static bool MenuOpen = true;

		// Token: 0x0400007A RID: 122
		public static string DropdownTitle;

		// Token: 0x0400007B RID: 123
		public static Rect DropdownPos;

		// Token: 0x0400007C RID: 124
		public static Color GUIColor;

		// Token: 0x0400007D RID: 125
		public static Texture2D _Logo;

		// Token: 0x0400007E RID: 126
		public static Texture2D _Aimbot;

		// Token: 0x0400007F RID: 127
		public static Texture2D _Visual;

		// Token: 0x04000080 RID: 128
		public static Texture2D _Other;

		// Token: 0x04000081 RID: 129
		public static Texture2D _Settings;

		// Token: 0x04000082 RID: 130
		public static Texture2D _Aasset;

		// Token: 0x04000083 RID: 131
		public static Texture2D _Skin;

		// Token: 0x04000084 RID: 132
		public static Texture2D _Keyboard;

		// Token: 0x04000085 RID: 133
		public static Texture2D _Logo2;

		// Token: 0x04000086 RID: 134
		public static Texture2D _User;

		// Token: 0x04000087 RID: 135
		public static Texture2D Player;

		// Token: 0x04000088 RID: 136
		public static Texture2D ChPlayer;

		// Token: 0x04000089 RID: 137
		public static Texture2D xray;

		// Token: 0x0400008A RID: 138
		public static Texture2D Espstyle1;

		// Token: 0x0400008B RID: 139
		public static Texture2D Espstyle2;

		// Token: 0x0400008C RID: 140
		public static Texture2D Espstyle3;

		// Token: 0x0400008D RID: 141
		public static Texture2D Espstyle4;

		// Token: 0x0400008E RID: 142
		public static Texture2D Espstyle5;

		// Token: 0x0400008F RID: 143
		public static Texture2D zombie;

		// Token: 0x04000090 RID: 144
		public static Texture2D sentiri;

		// Token: 0x04000091 RID: 145
		public static Texture2D locker;

		// Token: 0x04000092 RID: 146
		public static Texture2D bed;

		// Token: 0x04000093 RID: 147
		public static Texture2D texture2D_0;

		// Token: 0x04000094 RID: 148
		public static Texture2D airdrop;

		// Token: 0x04000095 RID: 149
		public static Texture2D vehicle;

		// Token: 0x04000096 RID: 150
		public static Texture2D flag;

		// Token: 0x04000097 RID: 151
		public static Texture2D _Maps;

		// Token: 0x04000098 RID: 152
		public static Texture2D _Player;

		// Token: 0x04000099 RID: 153
		public static List<GUIContent> buttons2 = new List<GUIContent>();

		// Token: 0x0400009A RID: 154
		public static List<GUIContent> buttons = new List<GUIContent>();

		// Token: 0x0400009B RID: 155
		public static List<GUIContent> buttons3 = new List<GUIContent>();

		// Token: 0x0400009C RID: 156
		public static List<GUIContent> buttons4 = new List<GUIContent>();

		// Token: 0x0400009D RID: 157
		public static List<GUIContent> buttons5 = new List<GUIContent>();

		// Token: 0x0400009E RID: 158
		public static List<GUIContent> buttons6 = new List<GUIContent>();

		// Token: 0x0400009F RID: 159
		public static List<GUIContent> buttons7 = new List<GUIContent>();

		// Token: 0x040000A0 RID: 160
		public static Rect CursorPos = new Rect(0f, 0f, 20f, 20f);

		// Token: 0x040000A1 RID: 161
		private Texture texture_0;

		// Token: 0x040000A2 RID: 162
		private Rect rect_0 = new Rect(80f, 80f, 1010f, 645f);
	}
}
