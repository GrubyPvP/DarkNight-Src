using System;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200002E RID: 46
	[Component]
	public class RadarComponent : MonoBehaviour
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002801 File Offset: 0x00000A01
		[OnSpy]
		public static void Disable()
		{
			RadarComponent.WasEnabled = RadarOptions.Enabled;
			RadarOptions.Enabled = false;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002813 File Offset: 0x00000A13
		[OffSpy]
		public static void Enable()
		{
			RadarOptions.Enabled = RadarComponent.WasEnabled;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000E24C File Offset: 0x0000C44C
		private void OnGUI()
		{
			if (RadarOptions.Enabled && DrawUtilities.ShouldRun())
			{
				RadarOptions.vew.width = (RadarOptions.vew.height = RadarOptions.RadarSize + 10f);
				GUI.color = new Color(1f, 1f, 1f, 0f);
				RadarComponent.veww = GUILayout.Window(345, RadarOptions.vew, new GUI.WindowFunction(this.method_0), "Radar", Array.Empty<GUILayoutOption>());
				RadarOptions.vew.x = RadarComponent.veww.x;
				RadarOptions.vew.y = RadarComponent.veww.y;
				GUI.color = Color.white;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000E314 File Offset: 0x0000C514
		private void method_0(int int_0)
		{
			Drawing.DrawRect(new Rect(0f, 0f, RadarOptions.vew.width, 20f), new Color32(44, 44, 44, byte.MaxValue), null);
			Drawing.DrawRect(new Rect(0f, 20f, RadarOptions.vew.width, 5f), new Color32(34, 34, 34, byte.MaxValue), null);
			Drawing.DrawRect(new Rect(0f, 25f, RadarOptions.vew.width, RadarOptions.vew.height + 25f), new Color32(64, 64, 64, byte.MaxValue), null);
			GUILayout.Space(-19f);
			GUILayout.Label("Radar", Array.Empty<GUILayoutOption>());
			Vector2 vector;
			vector..ctor(RadarOptions.vew.width / 2f, (RadarOptions.vew.height + 25f) / 2f);
			RadarComponent.radarcenter = new Vector2(RadarOptions.vew.width / 2f, (RadarOptions.vew.height + 25f) / 2f);
			Vector2 vector2 = this.GameToRadarPosition(OptimizationVariables.MainPlayer.transform.position);
			if (RadarOptions.type == 2 || RadarOptions.type == 3)
			{
				RadarComponent.radarcenter.x = RadarComponent.radarcenter.x - vector2.x;
				RadarComponent.radarcenter.y = RadarComponent.radarcenter.y + vector2.y;
			}
			Drawing.DrawRect(new Rect(vector.x, 25f, 1f, RadarOptions.vew.height), Color.gray, null);
			Drawing.DrawRect(new Rect(0f, vector.y, RadarOptions.vew.width, 1f), Color.gray, null);
			Vector2 vector3;
			vector3..ctor(vector.x, vector.y - 10f);
			Vector2 vector4;
			vector4..ctor(vector.x + 5f, vector.y + 5f);
			Vector2 vector5;
			vector5..ctor(vector.x - 5f, vector.y + 5f);
			if (RadarOptions.type == 2)
			{
				vector3 = RadarComponent.RotatePoint(vector3, vector, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				vector4 = RadarComponent.RotatePoint(vector4, vector, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				vector5 = RadarComponent.RotatePoint(vector5, vector, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				RadarComponent.DrawLine(vector3, vector4, Color.white, 1f);
				RadarComponent.DrawLine(vector4, vector5, Color.white, 1f);
				RadarComponent.DrawLine(vector5, vector3, Color.white, 1f);
			}
			if (RadarOptions.type == 3)
			{
				RadarComponent.DrawLine(vector3, vector4, Color.white, 1f);
				RadarComponent.DrawLine(vector4, vector5, Color.white, 1f);
				RadarComponent.DrawLine(vector5, vector3, Color.white, 1f);
			}
			if (RadarOptions.type == 1)
			{
				Vector2 vector6;
				vector6..ctor(RadarComponent.radarcenter.x + vector2.x, RadarComponent.radarcenter.y - vector2.y);
				Vector2 vector7;
				vector7..ctor(vector6.x, vector6.y - 10f);
				Vector2 vector8;
				vector8..ctor(vector6.x + 5f, vector6.y + 5f);
				Vector2 vector9;
				vector9..ctor(vector6.x - 5f, vector6.y + 5f);
				vector7 = RadarComponent.RotatePoint(vector7, vector6, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				vector8 = RadarComponent.RotatePoint(vector8, vector6, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				vector9 = RadarComponent.RotatePoint(vector9, vector6, Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
				RadarComponent.DrawLine(vector7, vector8, Color.white, 1f);
				RadarComponent.DrawLine(vector8, vector9, Color.white, 1f);
				RadarComponent.DrawLine(vector9, vector7, Color.white, 1f);
			}
			if (RadarOptions.ShowVehicles)
			{
				foreach (InteractableVehicle interactableVehicle in VehicleManager.vehicles)
				{
					bool flag;
					if (interactableVehicle == null)
					{
						flag = true;
					}
					else
					{
						Transform transform = interactableVehicle.transform;
						Vector3? vector10 = (transform != null) ? new Vector3?(transform.position) : null;
						flag = (vector10 == null);
					}
					if (!flag)
					{
						if (RadarOptions.ShowVehiclesUnlocked)
						{
							if (!interactableVehicle.isLocked)
							{
								Vector2 vector11 = this.GameToRadarPosition(interactableVehicle.transform.position);
								this.method_1(new Vector2(RadarComponent.radarcenter.x + vector11.x, RadarComponent.radarcenter.y - vector11.y), Color.black, 3f);
								this.method_1(new Vector2(RadarComponent.radarcenter.x + vector11.x, RadarComponent.radarcenter.y - vector11.y), Class1.smethod_1("_Vehicles"), 2f);
							}
						}
						else
						{
							Vector2 vector12 = this.GameToRadarPosition(interactableVehicle.transform.position);
							this.method_1(new Vector2(RadarComponent.radarcenter.x + vector12.x, RadarComponent.radarcenter.y - vector12.y), Color.black, 3f);
							this.method_1(new Vector2(RadarComponent.radarcenter.x + vector12.x, RadarComponent.radarcenter.y - vector12.y), Class1.smethod_1("_Vehicles"), 2f);
						}
					}
				}
			}
			if (RadarOptions.ShowPlayers)
			{
				foreach (SteamPlayer steamPlayer in Provider.clients)
				{
					if (((steamPlayer != null) ? steamPlayer.player : null) != OptimizationVariables.MainPlayer)
					{
						bool flag2;
						if (steamPlayer == null)
						{
							flag2 = true;
						}
						else
						{
							Player player = steamPlayer.player;
							Vector3? vector13;
							if (player == null)
							{
								vector13 = null;
							}
							else
							{
								Transform transform2 = player.transform;
								vector13 = ((transform2 != null) ? new Vector3?(transform2.position) : null);
							}
							Vector3? vector10 = vector13;
							flag2 = (vector10 == null);
						}
						if (!flag2)
						{
							bool flag3;
							if (steamPlayer == null)
							{
								flag3 = true;
							}
							else
							{
								Player player2 = steamPlayer.player;
								Vector3? vector14;
								if (player2 == null)
								{
									vector14 = null;
								}
								else
								{
									PlayerLook look = player2.look;
									if (look == null)
									{
										vector14 = null;
									}
									else
									{
										Transform aim = look.aim;
										vector14 = ((aim != null) ? new Vector3?(aim.eulerAngles) : null);
									}
								}
								Vector3? vector10 = vector14;
								flag3 = (vector10 == null);
							}
							if (!flag3)
							{
								Vector2 vector15 = this.GameToRadarPosition(steamPlayer.player.transform.position);
								Vector2 vector16;
								vector16..ctor(RadarComponent.radarcenter.x + vector15.x, RadarComponent.radarcenter.y - vector15.y);
								Color color = Class1.smethod_1("_Players");
								if (FriendUtilities.IsFriendly(steamPlayer.player) && ESPOptions.UsePlayerGroup)
								{
									color = Class1.smethod_1("_ESPFriendly");
								}
								if (RadarOptions.DetialedPlayers)
								{
									if (vector16.y > 30f)
									{
										Vector2 vector17;
										vector17..ctor(vector16.x, vector16.y - 10f);
										Vector2 vector18;
										vector18..ctor(vector16.x + 5f, vector16.y + 5f);
										Vector2 vector19;
										vector19..ctor(vector16.x - 5f, vector16.y + 5f);
										vector17 = RadarComponent.RotatePoint(vector17, vector16, Math.Round((double)steamPlayer.player.look.aim.eulerAngles.y, 2));
										vector18 = RadarComponent.RotatePoint(vector18, vector16, Math.Round((double)steamPlayer.player.look.aim.eulerAngles.y, 2));
										vector19 = RadarComponent.RotatePoint(vector19, vector16, Math.Round((double)steamPlayer.player.look.aim.eulerAngles.y, 2));
										RadarComponent.DrawLine(vector17, vector18, color, 1f);
										RadarComponent.DrawLine(vector18, vector19, color, 1f);
										RadarComponent.DrawLine(vector19, vector17, color, 1f);
									}
								}
								else
								{
									this.method_1(vector16, Color.black, 3f);
									this.method_1(vector16, color, 2f);
								}
							}
						}
					}
				}
			}
			if (MiscComponent.LastDeath != new Vector3(0f, 0f, 0f))
			{
				Vector2 vector20 = this.GameToRadarPosition(MiscComponent.LastDeath);
				this.method_1(new Vector2(RadarComponent.radarcenter.x + vector20.x, RadarComponent.radarcenter.y - vector20.y), Color.black, 4f);
				this.method_1(new Vector2(RadarComponent.radarcenter.x + vector20.x, RadarComponent.radarcenter.y - vector20.y), Color.grey, 3f);
			}
			GUI.DragWindow();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000281F File Offset: 0x00000A1F
		private void method_1(Vector2 vector2_0, Color color_0, float float_0 = 2f)
		{
			if (vector2_0.y > 28f)
			{
				Drawing.DrawRect(new Rect(vector2_0.x - float_0, vector2_0.y - float_0, float_0 * 2f, float_0 * 2f), color_0, null);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		public Vector2 GameToRadarPosition(Vector3 pos)
		{
			Vector2 vector;
			vector.x = pos.x / ((float)Level.size / (RadarOptions.RadarZoom * RadarOptions.RadarSize));
			vector.y = pos.z / ((float)Level.size / (RadarOptions.RadarZoom * RadarOptions.RadarSize));
			if (RadarOptions.type == 3)
			{
				return RadarComponent.RotatePoint(vector, new Vector2(RadarOptions.vew.width / 2f, (RadarOptions.vew.height + 25f) / 2f), Math.Round((double)MainCamera.instance.transform.eulerAngles.y, 2));
			}
			return vector;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000ED9C File Offset: 0x0000CF9C
		public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
		{
			Matrix4x4 matrix = GUI.matrix;
			if (!RadarComponent.texture2D_0)
			{
				RadarComponent.texture2D_0 = new Texture2D(1, 1);
				RadarComponent.texture2D_0.SetPixel(0, 0, Color.white);
				RadarComponent.texture2D_0.Apply();
			}
			Color color2 = GUI.color;
			GUI.color = color;
			float num = Vector2.Angle(pointB - pointA, Vector2.right);
			if (pointA.y > pointB.y)
			{
				num = -num;
			}
			GUIUtility.RotateAroundPivot(num, pointA);
			GUI.DrawTexture(new Rect(pointA.x, pointA.y, (pointB - pointA).magnitude, width), RadarComponent.texture2D_0);
			GUI.matrix = matrix;
			GUI.color = color2;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000EE54 File Offset: 0x0000D054
		public static Vector2 RotatePoint(Vector2 pointToRotate, Vector2 centerPoint, double angleInDegrees)
		{
			double num = angleInDegrees * 0.017453292519943295;
			double num2 = Math.Cos(num);
			double num3 = Math.Sin(num);
			return new Vector2((float)((int)(num2 * (double)(pointToRotate.x - centerPoint.x) - num3 * (double)(pointToRotate.y - centerPoint.y) + (double)centerPoint.x)), (float)((int)(num3 * (double)(pointToRotate.x - centerPoint.x) + num2 * (double)(pointToRotate.y - centerPoint.y) + (double)centerPoint.y)));
		}

		// Token: 0x0400010A RID: 266
		public static Rect veww;

		// Token: 0x0400010B RID: 267
		public static Vector2 radarcenter;

		// Token: 0x0400010C RID: 268
		public static bool WasEnabled;

		// Token: 0x0400010D RID: 269
		private static Texture2D texture2D_0;
	}
}
