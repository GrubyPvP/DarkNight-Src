using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000029 RID: 41
	[Component]
	public class MirrorCameraComponent : MonoBehaviour
	{
		// Token: 0x0600006D RID: 109 RVA: 0x000025C0 File Offset: 0x000007C0
		[OnSpy]
		public static void Disable()
		{
			MirrorCameraComponent.WasEnabled = MirrorCameraOptions.Enabled;
			MirrorCameraOptions.Enabled = false;
			Object.Destroy(MirrorCameraComponent.cam_obj);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000025DC File Offset: 0x000007DC
		[OffSpy]
		public static void Enable()
		{
			MirrorCameraOptions.Enabled = MirrorCameraComponent.WasEnabled;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000025E8 File Offset: 0x000007E8
		public void Update()
		{
			if (!MirrorCameraComponent.cam_obj || !MirrorCameraComponent.subCam)
			{
				return;
			}
			if (MirrorCameraOptions.Enabled)
			{
				MirrorCameraComponent.subCam.enabled = true;
				return;
			}
			MirrorCameraComponent.subCam.enabled = false;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002240 File Offset: 0x00000440
		private void Start()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
		private void OnGUI()
		{
			if (MirrorCameraOptions.Enabled)
			{
				GUI.color = new Color(1f, 1f, 1f, 0f);
				MirrorCameraComponent.viewport = GUILayout.Window(99, MirrorCameraComponent.viewport, new GUI.WindowFunction(this.method_0), "Mirror Camera", Array.Empty<GUILayoutOption>());
				GUI.color = Color.white;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		private void method_0(int int_0)
		{
			if (MirrorCameraComponent.cam_obj == null || MirrorCameraComponent.subCam == null)
			{
				MirrorCameraComponent.cam_obj = new GameObject();
				if (MirrorCameraComponent.subCam != null)
				{
					Object.Destroy(MirrorCameraComponent.subCam);
				}
				MirrorCameraComponent.subCam = MirrorCameraComponent.cam_obj.AddComponent<Camera>();
				MirrorCameraComponent.subCam.CopyFrom(OptimizationVariables.MainCam);
				MirrorCameraComponent.cam_obj.transform.position = OptimizationVariables.MainCam.gameObject.transform.position;
				MirrorCameraComponent.cam_obj.transform.rotation = OptimizationVariables.MainCam.gameObject.transform.rotation;
				MirrorCameraComponent.cam_obj.transform.Rotate(0f, 0f, 0f);
				MirrorCameraComponent.subCam.transform.SetParent(OptimizationVariables.MainCam.transform, false);
				MirrorCameraComponent.subCam.enabled = true;
				MirrorCameraComponent.subCam.rect = new Rect(0.6f, 0.6f, 0.4f, 0.4f);
				MirrorCameraComponent.subCam.depth = 99f;
				Object.DontDestroyOnLoad(MirrorCameraComponent.cam_obj);
			}
			float num = MirrorCameraComponent.viewport.x / (float)Screen.width;
			float num2 = (MirrorCameraComponent.viewport.y + 25f) / (float)Screen.height;
			float num3 = MirrorCameraComponent.viewport.width / (float)Screen.width;
			float num4 = MirrorCameraComponent.viewport.height / (float)Screen.height;
			num2 = 1f - num2;
			num2 -= num4;
			MirrorCameraComponent.subCam.rect = new Rect(num, num2, num3, num4);
			Drawing.DrawRect(new Rect(0f, 0f, MirrorCameraComponent.viewport.width, 20f), new Color32(44, 44, 44, byte.MaxValue), null);
			Drawing.DrawRect(new Rect(0f, 20f, MirrorCameraComponent.viewport.width, 5f), new Color32(34, 34, 34, byte.MaxValue), null);
			GUILayout.Space(-19f);
			GUILayout.Label("Mirror Camera", Array.Empty<GUILayoutOption>());
			GUI.DragWindow();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000CD48 File Offset: 0x0000AF48
		public static void FixCam()
		{
			if (MirrorCameraComponent.cam_obj != null && MirrorCameraComponent.subCam != null)
			{
				MirrorCameraComponent.cam_obj.transform.position = OptimizationVariables.MainCam.gameObject.transform.position;
				MirrorCameraComponent.cam_obj.transform.rotation = OptimizationVariables.MainCam.gameObject.transform.rotation;
				MirrorCameraComponent.cam_obj.transform.Rotate(0f, 180f, 0f);
				MirrorCameraComponent.subCam.transform.SetParent(OptimizationVariables.MainCam.transform, true);
				MirrorCameraComponent.subCam.depth = 99f;
				MirrorCameraComponent.subCam.enabled = true;
			}
		}

		// Token: 0x040000D9 RID: 217
		public static Rect viewport = new Rect(1075f, 10f, (float)(Screen.width / 4), (float)(Screen.height / 4));

		// Token: 0x040000DA RID: 218
		public static GameObject cam_obj;

		// Token: 0x040000DB RID: 219
		public static Camera subCam;

		// Token: 0x040000DC RID: 220
		public static bool WasEnabled;
	}
}
