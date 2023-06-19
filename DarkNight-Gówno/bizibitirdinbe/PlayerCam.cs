using System;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000049 RID: 73
	[Component]
	public class PlayerCam : MonoBehaviour
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00012578 File Offset: 0x00010778
		public static Vector3 GetLimbPosition(Transform target, string objName)
		{
			Transform[] componentsInChildren = target.transform.GetComponentsInChildren<Transform>();
			Vector3 result = Vector3.zero;
			if (componentsInChildren == null)
			{
				return result;
			}
			foreach (Transform transform in componentsInChildren)
			{
				if (!(transform.name.Trim() != objName))
				{
					result = transform.position + new Vector3(PlayerCam.x, PlayerCam.y, PlayerCam.z);
					return result;
				}
			}
			return result;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000125F8 File Offset: 0x000107F8
		public void Update()
		{
			if (!PlayerCam.cam_obj || !PlayerCam.subCam)
			{
				return;
			}
			if (PlayerCam.BeingSpied)
			{
				PlayerCam.Enabled = false;
			}
			else
			{
				PlayerCam.Enabled = true;
			}
			if (!PlayerCam.Enabled)
			{
				PlayerCam.subCam.enabled = false;
				return;
			}
			PlayerCam.subCam.enabled = true;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00012654 File Offset: 0x00010854
		private void OnGUI()
		{
			if (PlayerCam.MainCamera == null)
			{
				PlayerCam.MainCamera = Camera.main;
			}
			if (PlayerCam.Enabled && PlayerCam.player != null && Provider.isConnected && !PlayerCam.BeingSpied)
			{
				GUI.color = new Color(1f, 1f, 1f, 0f);
				PlayerCam.viewport = GUI.Window(98, PlayerCam.viewport, new GUI.WindowFunction(this.method_0), "Player Cam");
				GUI.color = Color.white;
				if (PlayerCam.IsFullScreen)
				{
					PlayerCam.x = Prefab.Slider(0f, 5f, PlayerCam.x, 100);
					PlayerCam.y = Prefab.Slider(0f, 5f, PlayerCam.y, 100);
					PlayerCam.z = Prefab.Slider(0f, 5f, PlayerCam.z, 100);
					if (GUI.Button(new Rect((float)(Screen.width / 2 - 50), (float)(Screen.height - 100), 100f, 50f), ""))
					{
						PlayerCam.IsFullScreen = false;
					}
				}
			}
			if (PlayerCam.player == null || PlayerCam.BeingSpied || (!Provider.isConnected && PlayerCam.subCam != null && PlayerCam.cam_obj != null))
			{
				Object.Destroy(PlayerCam.subCam);
				PlayerCam.subCam = null;
				PlayerCam.cam_obj = null;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000127CC File Offset: 0x000109CC
		private void method_0(int int_0)
		{
			if (PlayerCam.cam_obj == null || PlayerCam.subCam == null)
			{
				PlayerCam.cam_obj = new GameObject();
				if (PlayerCam.subCam != null)
				{
					Object.Destroy(PlayerCam.subCam);
				}
				PlayerCam.subCam = PlayerCam.cam_obj.AddComponent<Camera>();
				PlayerCam.subCam.CopyFrom(PlayerCam.MainCamera);
				PlayerCam.subCam.enabled = true;
				PlayerCam.subCam.rect = new Rect(0.6f, 0.6f, 0.6f, 0.4f);
				PlayerCam.subCam.depth = 98f;
				Object.DontDestroyOnLoad(PlayerCam.cam_obj);
			}
			PlayerCam.subCam.transform.SetPositionAndRotation(PlayerCam.GetLimbPosition(PlayerCam.player.transform, "Skull") + new Vector3(0f, 0.2f, 0f) + PlayerCam.player.look.aim.forward / 1.6f, PlayerCam.player.look.aim.rotation);
			float num = PlayerCam.viewport.x / (float)Screen.width;
			float num2 = (PlayerCam.viewport.y + 40f) / (float)Screen.height;
			float num3 = PlayerCam.viewport.width / (float)Screen.width;
			float num4 = PlayerCam.viewport.height / (float)Screen.height;
			if (PlayerCam.IsFullScreen)
			{
				num = 0f;
				num2 = 0f;
				num3 = (float)Screen.width;
				num4 = (float)Screen.height;
			}
			num2 = 1f - num2;
			num2 -= num4;
			PlayerCam.subCam.rect = new Rect(num, num2, num3, num4);
			if (!PlayerCam.IsFullScreen)
			{
				GUILayout.Space(-13f);
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				if (GUILayout.Button("", new GUILayoutOption[]
				{
					GUILayout.Height(25f)
				}))
				{
					PlayerCam.IsFullScreen = true;
				}
				GUILayout.TextArea(PlayersTab.SelectedPlayer.name, new GUILayoutOption[]
				{
					GUILayout.Height(25f)
				});
				GUILayout.EndHorizontal();
			}
			GUI.DragWindow();
		}

		// Token: 0x0400016D RID: 365
		public static Rect viewport = new Rect((float)(Screen.width - Screen.width / 4 - 10), 30f, (float)(Screen.width / 4), (float)(Screen.height / 4));

		// Token: 0x0400016E RID: 366
		public static GameObject cam_obj;

		// Token: 0x0400016F RID: 367
		public static Camera subCam;

		// Token: 0x04000170 RID: 368
		public static Camera MainCamera;

		// Token: 0x04000171 RID: 369
		public static bool WasEnabled;

		// Token: 0x04000172 RID: 370
		public static bool Enabled = true;

		// Token: 0x04000173 RID: 371
		public static Player player = null;

		// Token: 0x04000174 RID: 372
		public static bool IsFullScreen = false;

		// Token: 0x04000175 RID: 373
		public static bool BeingSpied = false;

		// Token: 0x04000176 RID: 374
		public static float x = 0f;

		// Token: 0x04000177 RID: 375
		public static float y = 0.4f;

		// Token: 0x04000178 RID: 376
		public static float z = 0f;
	}
}
