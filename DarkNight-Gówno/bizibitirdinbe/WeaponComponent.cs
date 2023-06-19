using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200004C RID: 76
	[Component]
	[SpyComponent]
	public class WeaponComponent : MonoBehaviour
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000131F8 File Offset: 0x000113F8
		public void Update()
		{
			ItemGunAsset itemGunAsset;
			if (DrawUtilities.ShouldRun() && !G.BeingSpied && (itemGunAsset = (OptimizationVariables.MainPlayer.equipment.asset as ItemGunAsset)) != null)
			{
				if (!WeaponComponent.AssetBackups.ContainsKey(itemGunAsset.id))
				{
					float[] value = new float[]
					{
						itemGunAsset.recoilMax_x,
						itemGunAsset.recoilMax_y,
						itemGunAsset.recoilMin_x,
						itemGunAsset.recoilMin_y,
						itemGunAsset.recoilCrouch,
						itemGunAsset.recoilProne,
						itemGunAsset.recoilSprint,
						itemGunAsset.aimingRecoilMultiplier,
						itemGunAsset.spreadAim,
						itemGunAsset.spreadCrouch,
						itemGunAsset.recoilProne,
						itemGunAsset.spreadSprint
					};
					WeaponComponent.AssetBackups.Add(itemGunAsset.id, value);
				}
				if (WeaponOptions.NoRecoil)
				{
					itemGunAsset.recoilMax_x = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilMax_y = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilMin_x = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilMin_y = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilCrouch = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilProne = WeaponOptions.NoRecoil1;
					itemGunAsset.recoilSprint = WeaponOptions.NoRecoil1;
					itemGunAsset.aimingRecoilMultiplier = WeaponOptions.NoRecoil1;
				}
				else
				{
					itemGunAsset.recoilMax_x = WeaponComponent.AssetBackups[itemGunAsset.id][0];
					itemGunAsset.recoilMax_y = WeaponComponent.AssetBackups[itemGunAsset.id][1];
					itemGunAsset.recoilMin_x = WeaponComponent.AssetBackups[itemGunAsset.id][2];
					itemGunAsset.recoilMin_y = WeaponComponent.AssetBackups[itemGunAsset.id][3];
					itemGunAsset.recoilCrouch = WeaponComponent.AssetBackups[itemGunAsset.id][4];
					itemGunAsset.recoilProne = WeaponComponent.AssetBackups[itemGunAsset.id][5];
					itemGunAsset.recoilSprint = WeaponComponent.AssetBackups[itemGunAsset.id][6];
					itemGunAsset.aimingRecoilMultiplier = WeaponComponent.AssetBackups[itemGunAsset.id][7];
				}
				if (!WeaponOptions.NoSpread)
				{
					itemGunAsset.spreadAim = WeaponComponent.AssetBackups[itemGunAsset.id][8];
					itemGunAsset.spreadCrouch = WeaponComponent.AssetBackups[itemGunAsset.id][9];
					itemGunAsset.spreadProne = WeaponComponent.AssetBackups[itemGunAsset.id][10];
					itemGunAsset.spreadSprint = WeaponComponent.AssetBackups[itemGunAsset.id][11];
				}
				else
				{
					itemGunAsset.spreadAim = WeaponOptions.NoSpread1;
					itemGunAsset.spreadCrouch = WeaponOptions.NoSpread1;
					itemGunAsset.spreadProne = WeaponOptions.NoSpread1;
					itemGunAsset.spreadSprint = WeaponOptions.NoSpread1;
					OptionsSettings.useStaticCrosshair = true;
					OptionsSettings.staticCrosshairSize = 0f;
				}
				if (WeaponOptions.NoSway)
				{
					OptimizationVariables.MainPlayer.animator.viewmodelSwayMultiplier = WeaponOptions.NoSway1;
					OptimizationVariables.MainPlayer.animator.scopeSway = new Vector3(WeaponOptions.NoSway1, WeaponOptions.NoSway1, WeaponOptions.NoSway1);
				}
				if (WeaponOptions.Crosshair)
				{
					Provider.modeConfigData.Gameplay.Crosshair = true;
					PlayerLifeUI.crosshair.SetDirectionalArrowsVisible(true);
				}
				else
				{
					Provider.modeConfigData.Gameplay.Crosshair = false;
					PlayerLifeUI.crosshair.SetDirectionalArrowsVisible(false);
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00013558 File Offset: 0x00011758
		private void FixedUpdate()
		{
			if (this.int_0 > 0 && this.int_2 == 0)
			{
				this.int_0--;
				this.int_1++;
			}
			if (this.int_1 > 0 && this.int_0 == 0)
			{
				this.int_1--;
				this.int_2++;
			}
			if (this.int_2 > 0 && this.int_1 == 0)
			{
				this.int_2--;
				this.int_0++;
			}
			WeaponComponent.RGBRenk = new Color((float)this.int_0, (float)this.int_1, (float)this.int_2, 255f);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00013610 File Offset: 0x00011810
		public void OnGUI()
		{
			if (!G.BeingSpied && Event.current.type == 7 && DrawUtilities.ShouldRun())
			{
				if (RaycastOptions.SilentAimUseFOV && RaycastOptions.bool_1 && RaycastOptions.Enabled)
				{
					DrawUtilities.DrawCircle(Color.red, new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), WeaponComponent.smethod_0(RaycastOptions.SilentAimFOV));
				}
				if (WeaponOptions.Tracers)
				{
					T.DrawMaterial.SetPass(0);
					GL.PushMatrix();
					GL.LoadProjectionMatrix(OptimizationVariables.MainCam.projectionMatrix);
					GL.modelview = OptimizationVariables.MainCam.worldToCameraMatrix;
					GL.Begin(1);
					for (int i = WeaponComponent.TracerLines.Count - 1; i > -1; i--)
					{
						WeaponComponent.TracerObject tracerObject = WeaponComponent.TracerLines[i];
						if (DateTime.Now - tracerObject.ShotTime > TimeSpan.FromSeconds(3.0))
						{
							WeaponComponent.TracerLines.Remove(tracerObject);
						}
						else
						{
							GL.Color(WeaponComponent.RGBRenk);
							GL.Vertex(tracerObject.PlayerPos);
							GL.Vertex(tracerObject.HitPos);
						}
					}
					GL.End();
					GL.PopMatrix();
				}
				if (WeaponOptions.DamageIndicators && WeaponComponent.DamageIndicators.Count > 0)
				{
					T.DrawMaterial.SetPass(0);
					for (int j = WeaponComponent.DamageIndicators.Count - 1; j > -1; j--)
					{
						WeaponComponent.IndicatorObject indicatorObject = WeaponComponent.DamageIndicators[j];
						if (DateTime.Now - indicatorObject.ShotTime > TimeSpan.FromSeconds(3.0))
						{
							WeaponComponent.DamageIndicators.Remove(indicatorObject);
						}
						else
						{
							GUI.color = Color.red;
							Vector3 vector = OptimizationVariables.MainCam.WorldToScreenPoint(indicatorObject.HitPos + new Vector3(0f, 1f, 0f));
							vector.y = (float)Screen.height - vector.y;
							if (vector.z >= 0f)
							{
								GUIStyle label = GUI.skin.label;
								label.alignment = 4;
								Vector2 vector2 = label.CalcSize(new GUIContent(string.Format("<b>{0}</b>", indicatorObject.Damage)));
								T.DrawOutlineLabel(new Vector2(vector.x - vector2.x / 2f, vector.y - (float)(DateTime.Now - indicatorObject.ShotTime).TotalSeconds * 10f), WeaponComponent.RGBRenk, Color.black, string.Format("<b>{0}</b>", indicatorObject.Damage), null);
								label.alignment = 3;
							}
							GUI.color = Main.GUIColor;
						}
					}
				}
				if (AimbotOptions.ShowAimUseFOV && AimbotOptions.bool_0 && AimbotOptions.Enabled)
				{
					DrawUtilities.DrawCircle(Color.green, new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), WeaponComponent.smethod_0(AimbotOptions.float_0));
				}
				if (ESPOptions.ShowCoordinates)
				{
					float x = OptimizationVariables.MainPlayer.transform.position.x;
					float y = OptimizationVariables.MainPlayer.transform.position.y;
					float z = OptimizationVariables.MainPlayer.transform.position.z;
					string content = string.Format("", Math.Round((double)x, 2).ToString(), Math.Round((double)y, 2).ToString(), Math.Round((double)z, 2).ToString());
					DrawUtilities.DrawLabel(Font.CreateDynamicFontFromOSFont("Arial", 11), LabelLocation.MiddleLeft, new Vector2((float)(Screen.width - 20), (float)(Screen.height / 2 + 50)), content, Class1.smethod_1("_Coordinates"), Class1.smethod_1("_CoordinatesTick"), 1, null, 12);
				}
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00013A04 File Offset: 0x00011C04
		public static void AddTracer(RaycastInfo ri)
		{
			if (WeaponOptions.Tracers && ri.point != new Vector3(0f, 0f, 0f))
			{
				WeaponComponent.TracerObject item = new WeaponComponent.TracerObject
				{
					HitPos = ri.point,
					PlayerPos = Player.player.look.aim.transform.position,
					ShotTime = DateTime.Now
				};
				WeaponComponent.TracerLines.Add(item);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00013A84 File Offset: 0x00011C84
		public static void AddDamage(RaycastInfo ri)
		{
			if (WeaponOptions.DamageIndicators && ri.point != new Vector3(0f, 0f, 0f))
			{
				ItemGunAsset itemGunAsset = Player.player.equipment.asset as ItemGunAsset;
				if (itemGunAsset != null && ri.player != null)
				{
					WeaponComponent.IndicatorObject item = new WeaponComponent.IndicatorObject
					{
						HitPos = ri.point,
						Damage = Mathf.FloorToInt(DamageTool.getPlayerArmor(ri.limb, ri.player) * itemGunAsset.playerDamageMultiplier.multiply(ri.limb)),
						ShotTime = DateTime.Now
					};
					WeaponComponent.DamageIndicators.Add(item);
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00013B40 File Offset: 0x00011D40
		internal static float smethod_0(float float_0)
		{
			float fieldOfView = OptimizationVariables.MainCam.fieldOfView;
			return (float)(Math.Tan((double)float_0 * 0.017453292519943295 / 2.0) / Math.Tan((double)fieldOfView * 0.017453292519943295 / 2.0) * (double)Screen.height);
		}

		// Token: 0x0400018A RID: 394
		public static List<WeaponComponent.TracerObject> TracerLines = new List<WeaponComponent.TracerObject>();

		// Token: 0x0400018B RID: 395
		public static List<WeaponComponent.IndicatorObject> DamageIndicators = new List<WeaponComponent.IndicatorObject>();

		// Token: 0x0400018C RID: 396
		private int int_0 = 255;

		// Token: 0x0400018D RID: 397
		private int int_1;

		// Token: 0x0400018E RID: 398
		private int int_2;

		// Token: 0x0400018F RID: 399
		public static Color RGBRenk;

		// Token: 0x04000190 RID: 400
		private Color color_0;

		// Token: 0x04000191 RID: 401
		public Color targetColor;

		// Token: 0x04000192 RID: 402
		public static Dictionary<ushort, float[]> AssetBackups = new Dictionary<ushort, float[]>();

		// Token: 0x04000193 RID: 403
		public static List<TracerLine> Tracers = new List<TracerLine>();

		// Token: 0x04000194 RID: 404
		public static FieldInfo look1 = typeof(PlayerLook).GetField("fov", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000195 RID: 405
		public static FieldInfo ZoomInfo = typeof(UseableGun).GetField("zoom", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000196 RID: 406
		public static FieldInfo AmmoInfo = typeof(UseableGun).GetField("ammo", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000197 RID: 407
		public static MethodInfo UpdateCrosshair = typeof(UseableGun).GetMethod("updateCrosshair", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000198 RID: 408
		public static FieldInfo attachments1 = typeof(UseableGun).GetField("firstAttachments", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000199 RID: 409
		public static FieldInfo fov = typeof(PlayerLook).GetField("fov", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019A RID: 410
		public static FieldInfo oryaw = typeof(PlayerLook).GetField("_orbitPitch", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019B RID: 411
		public static FieldInfo orpitch = typeof(PlayerLook).GetField("_orbitYaw", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019C RID: 412
		public static FieldInfo yaw = typeof(PlayerLook).GetField("_yaw", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019D RID: 413
		public static FieldInfo pitch = typeof(PlayerLook).GetField("_pitch", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019E RID: 414
		public static FieldInfo lookx = typeof(PlayerLook).GetField("_look_x", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0400019F RID: 415
		public static FieldInfo looky = typeof(PlayerLook).GetField("_look_y", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x0200004D RID: 77
		public class TracerObject
		{
			// Token: 0x040001A0 RID: 416
			public DateTime ShotTime;

			// Token: 0x040001A1 RID: 417
			public Vector3 PlayerPos;

			// Token: 0x040001A2 RID: 418
			public Vector3 HitPos;
		}

		// Token: 0x0200004E RID: 78
		public class IndicatorObject
		{
			// Token: 0x040001A3 RID: 419
			public DateTime ShotTime;

			// Token: 0x040001A4 RID: 420
			public Vector3 HitPos;

			// Token: 0x040001A5 RID: 421
			public int Damage;
		}
	}
}
