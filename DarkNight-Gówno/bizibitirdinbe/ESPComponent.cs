using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HighlightingSystem;
using SDG.Framework.Foliage;
using SDG.Unturned;
using Steamworks;
using UnityEngine;
using Unturned.SystemEx;

namespace bizibitirdinbe
{
	// Token: 0x02000043 RID: 67
	[Component]
	public class ESPComponent : MonoBehaviour
	{
		// Token: 0x0600018C RID: 396 RVA: 0x000106D4 File Offset: 0x0000E8D4
		[Initializer]
		public static void Initialize()
		{
			for (int i = 0; i < ESPOptions.VisualOptions.Length; i++)
			{
				ESPTarget esptarget = (ESPTarget)i;
				Color32 color = Color.white;
				switch (esptarget)
				{
				case ESPTarget.Player:
					color..ctor(byte.MaxValue, 0, 0, byte.MaxValue);
					break;
				case ESPTarget.Zombie:
					color..ctor(115, byte.MaxValue, 110, byte.MaxValue);
					break;
				case ESPTarget.Item:
					color..ctor(0, byte.MaxValue, 0, byte.MaxValue);
					break;
				case ESPTarget.Sentry:
					color..ctor(220, 10, 10, byte.MaxValue);
					break;
				case ESPTarget.Bed:
					color..ctor(byte.MaxValue, 170, byte.MaxValue, byte.MaxValue);
					break;
				case ESPTarget.Flag:
					color..ctor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					break;
				case ESPTarget.Vehicle:
					color..ctor(240, 236, 0, byte.MaxValue);
					break;
				case ESPTarget.Storage:
					color..ctor(byte.MaxValue, byte.MaxValue, 90, byte.MaxValue);
					break;
				}
				Class1.smethod_0(new ColorVariable(string.Format("_{0}", esptarget), string.Format("", esptarget), color, false));
				Class1.smethod_0(new ColorVariable(string.Format("_{0}_Glow", esptarget), string.Format("", esptarget), color, false));
				Class1.smethod_0(new ColorVariable("_ESPFriendly", "      ESP Friendly", new Color32(100, 0, byte.MaxValue, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_Admin", "      Admin", new Color32(byte.MaxValue, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_WeaponInfoColor", "", new Color32(0, byte.MaxValue, byte.MaxValue, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_WeaponInfoBorder", "", new Color32(0, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_Coordinates", "", new Color32(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_CoordinatesTick", "", new Color32(0, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_VehicleInfoColor", "", new Color32(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_VehicleInfoBorder", "", new Color32(0, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_ShowFOVAim", "", new Color32(0, byte.MaxValue, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_ShowFOV", "", new Color32(byte.MaxValue, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_SelfColor", "      Chams Self", Color.green, false));
				Class1.smethod_0(new ColorVariable("_ChamsFriendVisible", "      Chams Friend - Visible", Color.green, false));
				Class1.smethod_0(new ColorVariable("_ChamsFriendInvisible", "      Chams Friend - Invisible", Color.blue, false));
				Class1.smethod_0(new ColorVariable("_ChamsEnemyVisible", "      Chams Enemy - Visible", new Color32(byte.MaxValue, 165, 0, byte.MaxValue), false));
				Class1.smethod_0(new ColorVariable("_ChamsEnemyInvisible", "      Chams Enemy - Invisible", Color.red, false));
				Class1.smethod_0(new ColorVariable("_SlientInfoColor", "      Slient - Info", new Color32(0, byte.MaxValue, byte.MaxValue, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_SlientInfoBorder", "      Slient - Info Border", new Color32(0, 0, 0, byte.MaxValue), true));
				Class1.smethod_0(new ColorVariable("_SlientCizgiColor", "      Slient - Tracer", new Color32(0, byte.MaxValue, byte.MaxValue, byte.MaxValue), true));
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00003643 File Offset: 0x00001843
		public void Start()
		{
			CoroutineComponent.ESPCoroutine = base.StartCoroutine(ESPCoroutines.UpdateObjectList());
			CoroutineComponent.ChamsCoroutine = base.StartCoroutine(ESPCoroutines.DoChams());
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00010B1C File Offset: 0x0000ED1C
		public void Update()
		{
			if (DrawUtilities.ShouldRun() && !G.BeingSpied)
			{
				if (MiscOptions.DeleteCharacterAnimation)
				{
					OptimizationVariables.MainPlayer.animator.play("Move_Walk", false);
				}
				if (MiscOptions.NoRain)
				{
					LightingManager.DisableWeather();
				}
				if (MiscOptions.NoCloud)
				{
					RenderSettings.skybox.DisableKeyword("WITH_CLOUDS");
				}
				else
				{
					RenderSettings.skybox.EnableKeyword("WITH_CLOUDS");
				}
				if (MiscOptions.NoGrass)
				{
					FoliageSettings.enabled = true;
					FoliageSettings.drawDistance = 0;
					FoliageSettings.instanceDensity = 0f;
					FoliageSettings.drawFocusDistance = 0;
					FoliageSettings.focusDistance = 0f;
				}
				else
				{
					float focusDistance = (0.3f + GraphicsSettings.NormalizedFarClipDistance * 0.7f) * 2048f;
					FoliageSettings.enabled = true;
					FoliageSettings.drawDistance = 2;
					FoliageSettings.instanceDensity = 0.25f;
					FoliageSettings.drawFocusDistance = 1;
					FoliageSettings.focusDistance = focusDistance;
				}
				if (MiscOptions.NoFog)
				{
					RenderSettings.fog = false;
				}
				else
				{
					RenderSettings.fog = true;
				}
				if (MiscOptions.NoTree)
				{
					for (byte b = 0; b < Regions.WORLD_SIZE; b += 1)
					{
						for (byte b2 = 0; b2 < Regions.WORLD_SIZE; b2 += 1)
						{
							foreach (ResourceSpawnpoint resourceSpawnpoint in LevelGround.trees[(int)b, (int)b2])
							{
								resourceSpawnpoint.model.gameObject.SetActive(false);
							}
						}
					}
					return;
				}
				for (byte b3 = 0; b3 < Regions.WORLD_SIZE; b3 += 1)
				{
					for (byte b4 = 0; b4 < Regions.WORLD_SIZE; b4 += 1)
					{
						foreach (ResourceSpawnpoint resourceSpawnpoint2 in LevelGround.trees[(int)b3, (int)b4])
						{
							if (resourceSpawnpoint2.model.gameObject != null)
							{
								resourceSpawnpoint2.model.gameObject.SetActive(true);
							}
							if (resourceSpawnpoint2.model.gameObject == null)
							{
								resourceSpawnpoint2.model.gameObject.SetActive(false);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00010D60 File Offset: 0x0000EF60
		public void OnGUI()
		{
			if (Event.current.type != 7 || !ESPOptions.Enabled || G.BeingSpied)
			{
				return;
			}
			if (!DrawUtilities.ShouldRun())
			{
				return;
			}
			GUI.depth = 1;
			if (ESPComponent.MainCamera == null)
			{
				ESPComponent.MainCamera = OptimizationVariables.MainCam;
			}
			Vector3 position = OptimizationVariables.MainPlayer.transform.position;
			Vector3 position2 = OptimizationVariables.MainPlayer.look.aim.position;
			Vector3 forward = OptimizationVariables.MainPlayer.look.aim.forward;
			for (int i = 0; i < ESPVariables.Objects.Count; i++)
			{
				ESPComponent.<>c__DisplayClass7_0 CS$<>8__locals1 = new ESPComponent.<>c__DisplayClass7_0();
				ESPObject espobject = ESPVariables.Objects[i];
				ESPVisual espvisual = ESPOptions.VisualOptions[(int)espobject.Target];
				GameObject gobject = espobject.GObject;
				if (!espvisual.Enabled)
				{
					Highlighter component = gobject.GetComponent<Highlighter>();
					if (component != null)
					{
						component.ConstantOffImmediate();
					}
				}
				else if (espobject.Target != ESPTarget.Item || !ESPOptions.FilterItems || ItemUtilities.Whitelisted(((InteractableItem)espobject.Object).asset, ItemOptions.ItemESPOptions))
				{
					Color color = Color.yellow;
					Color c = Class1.smethod_1(string.Format("_{0}", espobject.Target));
					LabelLocation location = espvisual.Location;
					if (!(gobject == null))
					{
						Vector3 position3 = gobject.transform.position;
						double distance = VectorUtilities.GetDistance(position3, position);
						if (distance >= 0.5 && (distance <= (double)espvisual.Distance || espvisual.InfiniteDistance))
						{
							CS$<>8__locals1.vector3_0 = ESPComponent.MainCamera.WorldToScreenPoint(position3);
							if (CS$<>8__locals1.vector3_0.z > 0f)
							{
								Vector3 localScale = gobject.transform.localScale;
								ESPTarget target = espobject.Target;
								Bounds bounds;
								if (target > ESPTarget.Zombie)
								{
									if (target != ESPTarget.Vehicle)
									{
										bounds = gobject.GetComponent<Collider>().bounds;
									}
									else
									{
										bounds = gobject.transform.Find("Model_0").GetComponent<MeshRenderer>().bounds;
										Transform transform = gobject.transform.Find("Model_1");
										if (transform != null)
										{
											bounds.Encapsulate(transform.GetComponent<MeshRenderer>().bounds);
										}
									}
								}
								else
								{
									bounds..ctor(new Vector3(position3.x, position3.y + 1f, position3.z), new Vector3(localScale.x * 2f, localScale.y * 3f, localScale.z * 2f));
								}
								int textSize = DrawUtilities.GetTextSize(espvisual, distance);
								Math.Round(distance);
								string text = string.Format("<size={0}>", textSize);
								string text2 = string.Format("<size={0}>", textSize);
								if (espvisual.ShowDistance)
								{
									if (T.GetDistance(espobject.GObject.transform.position) >= 0f && T.GetDistance(espobject.GObject.transform.position) < 50f)
									{
										text += string.Format("<color=white>[</color><color=red>{0}</color><color=white>]</color> ", T.GetDistance(espobject.GObject.transform.position));
										text2 += string.Format("[{0}] ", T.GetDistance(espobject.GObject.transform.position));
									}
									if (T.GetDistance(espobject.GObject.transform.position) >= 50f && T.GetDistance(espobject.GObject.transform.position) < 300f)
									{
										text += string.Format("<color=white>[</color><color=yellow>{0}</color><color=white>]</color> ", T.GetDistance(espobject.GObject.transform.position));
										text2 += string.Format("[{0}] ", T.GetDistance(espobject.GObject.transform.position));
									}
									if (T.GetDistance(espobject.GObject.transform.position) >= 300f)
									{
										text += string.Format("<color=white>[</color><color=#00FF00>{0}</color><color=white>]</color> ", T.GetDistance(espobject.GObject.transform.position));
										text2 += string.Format("[{0}] ", T.GetDistance(espobject.GObject.transform.position));
									}
								}
								switch (espobject.Target)
								{
								case ESPTarget.Player:
								{
									Player player = (Player)espobject.Object;
									if (player.life.isDead)
									{
										goto IL_14D8;
									}
									if (espvisual.ShowName)
									{
										text = text + ESPComponent.GetSteamPlayer(player).playerID.characterName + "\n";
										text2 = text2 + ESPComponent.GetSteamPlayer(player).playerID.characterName + "\n";
									}
									if (ESPOptions.ShowPlayerWeapon)
									{
										text += ((player.equipment.asset != null) ? ("<color=#white>" + player.equipment.asset.itemName + "</color>") : "<color=#white>None</color>");
										text2 += ((player.equipment.asset != null) ? (player.equipment.asset.itemName ?? "") : "None");
									}
									if (ESPOptions.ShowAmmo && player.gameObject != null && player.equipment.asset != null)
									{
										text += ((byte)ESPComponent.AmmoInfo.GetValue(player.equipment.asset)).ToString();
										text2 += ((byte)ESPComponent.AmmoInfo.GetValue(player.equipment.asset)).ToString();
									}
									if (ESPOptions.HitboxSize && RaycastOptions.Enabled)
									{
										Vector3 vector = T.WorldToScreen(player.transform.position);
										if (vector.z >= 0f)
										{
											Vector3 vector2 = T.WorldToScreen(new Vector3(player.transform.position.x, player.transform.position.y + (float)AimbotOptions.HitboxSize, player.transform.position.z));
											float radius = Vector3.Distance(vector, vector2);
											T.DrawCircle(Color.magenta, new Vector2(vector.x, vector.y), radius);
										}
									}
									if (ESPOptions.Skeleton)
									{
										T.DrawSkeleton(espobject.GObject.transform, Color.yellow);
									}
									if (ESPOptions.showhotbar && player.equipment.asset != null)
									{
										ItemTool.getIcon(player.equipment.asset.id, 40, player.equipment.asset.getState(), new ItemIconReady(CS$<>8__locals1.method_0));
									}
									if (ESPOptions.ShowPlayerVehicle)
									{
										text += ((player.movement.getVehicle() != null) ? ("<color=#white>" + player.movement.getVehicle().asset.name + "</color>") : "<color=#white>No Vehicle</color>");
										text2 += ((player.movement.getVehicle() != null) ? (player.movement.getVehicle().asset.name ?? "") : "No Vehicle");
									}
									bounds.size /= 2f;
									bounds.size = new Vector3(bounds.size.x, bounds.size.y * 1.25f, bounds.size.z);
									if (ESPOptions.bool_1 && FriendUtilities.IsFriendly(player))
									{
										color = Color.cyan;
									}
									if (ESPOptions.AdminRengi && player.channel.owner.isAdmin)
									{
										color = Color.red;
									}
									break;
								}
								case ESPTarget.Zombie:
									if (((Zombie)espobject.Object).isDead)
									{
										goto IL_14D8;
									}
									if (espvisual.ShowName)
									{
										text += "<color=#00f742>Zombie</color>";
									}
									text2 += "Zombie";
									break;
								case ESPTarget.Item:
								{
									InteractableItem interactableItem = (InteractableItem)espobject.Object;
									if (espvisual.ShowName)
									{
										text = text + "<color=#00f742>" + interactableItem.asset.itemName + "</color>";
									}
									text2 += interactableItem.asset.itemName;
									break;
								}
								case ESPTarget.Sentry:
								{
									InteractableSentry interactableSentry = (InteractableSentry)espobject.Object;
									if (espvisual.ShowName)
									{
										text += "<color=#0212eb>Sentry</color>";
										text2 += "Sentry";
									}
									if (ESPOptions.ShowSentryItem)
									{
										text += ESPComponent.SentryName(interactableSentry.displayItem, true);
										text2 += ESPComponent.SentryName(interactableSentry.displayItem, true);
									}
									break;
								}
								case ESPTarget.Bed:
								{
									InteractableBed interactableBed = (InteractableBed)espobject.Object;
									if (espvisual.ShowName)
									{
										text += "<color=#b972cf>Bed</color>";
										text2 += "Bed";
									}
									if (ESPOptions.ShowClaimed)
									{
										if (interactableBed.isClaimed && espvisual.ShowName)
										{
											text += "<color=#00ff00ff> - Claimed</color>";
											text2 += "<color=#00ff00ff> - Claimed</color>";
										}
										if (!interactableBed.isClaimed && espvisual.ShowName)
										{
											text += "<color=#ff0000ff> - No Claimed</color>";
											text2 += "<color=#ff0000ff> - No Claimed</color>";
										}
									}
									if (ESPOptions.bool_4)
									{
										CSteamID owner = interactableBed.owner;
										if (interactableBed.owner.ToString() == "0")
										{
											text += "\nNull";
											text2 += "\nNull";
										}
										else
										{
											text = text + "\n" + interactableBed.owner.ToString();
											text2 = text2 + "\n" + interactableBed.owner.ToString();
										}
									}
									if (ESPOptions.ClaimNameBed)
									{
										SteamPlayer steamPlayer = null;
										using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												steamPlayer = enumerator.Current;
											}
										}
										if (steamPlayer.playerID.steamID == interactableBed.owner)
										{
											text = text + "\n" + steamPlayer.player.name;
											text2 = text2 + "\n" + steamPlayer.player.name;
										}
										else
										{
											text += "\nNull";
											text2 += "\nNull";
										}
									}
									break;
								}
								case ESPTarget.Flag:
									if (espvisual.ShowName)
									{
										text += "<color=white>Claim Flag</color>";
									}
									text2 += "Claim Flag";
									break;
								case ESPTarget.Vehicle:
								{
									InteractableVehicle interactableVehicle = (InteractableVehicle)espobject.Object;
									if (interactableVehicle.health == 0 || (ESPOptions.FilterVehicleLocked && interactableVehicle.isLocked))
									{
										goto IL_14D8;
									}
									ushort num;
									ushort num2;
									interactableVehicle.getDisplayFuel(ref num, ref num2);
									float num3 = Mathf.Round(100f * ((float)interactableVehicle.health / (float)interactableVehicle.asset.health));
									float num4 = Mathf.Round(100f * ((float)num / (float)num2));
									if (espvisual.ShowName)
									{
										text = text + "<color=yellow>" + interactableVehicle.asset.name + "</color>";
										text2 += interactableVehicle.asset.name;
									}
									if (ESPOptions.ShowVehicleHealth)
									{
										text = text + "\n" + string.Format("Health: {0}%", num3);
										text2 = text2 + "\n" + string.Format("Health: {0}%", num3);
									}
									if (ESPOptions.ShowVehicleFuel)
									{
										text += string.Format(" - Fuel: {0}%", num4);
										text2 += string.Format(" - Fuel: {0}%", num4);
									}
									if (ESPOptions.ShowVehicleLocked)
									{
										if (interactableVehicle.isLocked && espvisual.ShowName)
										{
											text += "\n<color=#ff0000ff> - LOCKED</color>";
											text2 += "\n- LOCKED";
										}
										if (!interactableVehicle.isLocked && espvisual.ShowName)
										{
											text += "\n<color=#ff0000ff> - Not Locket</color>";
											text2 += "\n - Not Locket";
										}
									}
									if (ESPOptions.bool_3)
									{
										CSteamID lockedOwner = interactableVehicle.lockedOwner;
										if (interactableVehicle.lockedOwner.ToString() == "0")
										{
											text += "\nNull";
											text2 += "\nNull";
										}
										else
										{
											text = text + "\n" + interactableVehicle.lockedOwner.ToString();
											text2 = text2 + "\n" + interactableVehicle.lockedOwner.ToString();
										}
									}
									if (ESPOptions.ClaimNameCar)
									{
										SteamPlayer steamPlayer2 = null;
										using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												steamPlayer2 = enumerator.Current;
											}
										}
										if (steamPlayer2.playerID.steamID == interactableVehicle.lockedOwner)
										{
											text = text + "\n" + steamPlayer2.player.name;
											text2 = text2 + "\n" + steamPlayer2.player.name;
										}
										else
										{
											text += "\nNull";
											text2 += "\nNull";
										}
									}
									break;
								}
								case ESPTarget.Storage:
								{
									InteractableStorage interactableStorage = (InteractableStorage)espobject.Object;
									if (espvisual.ShowName)
									{
										text += "<color=#008fb3>Storage</color>";
									}
									text2 += "Storage";
									if (ESPOptions.bool_2)
									{
										CSteamID owner2 = interactableStorage.owner;
										if (interactableStorage.owner.ToString() == "0")
										{
											text += "\nNull";
											text2 += "\nNull";
										}
										else
										{
											text = text + "\n" + interactableStorage.owner.ToString();
											text2 = text2 + "\n" + interactableStorage.owner.ToString();
										}
									}
									if (ESPOptions.ClaimNameStorage)
									{
										SteamPlayer steamPlayer3 = null;
										using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												steamPlayer3 = enumerator.Current;
											}
										}
										if (steamPlayer3.playerID.steamID == interactableStorage.owner)
										{
											text = text + "\n" + steamPlayer3.player.name;
											text2 = text2 + "\n" + steamPlayer3.player.name;
										}
										else
										{
											text += "\nNull";
											text2 += "\nNull";
										}
									}
									break;
								}
								}
								text += "</size>";
								text2 += "</size>";
								Vector3[] boxVectors = DrawUtilities.GetBoxVectors(bounds);
								Vector2[] rectangleLines = DrawUtilities.GetRectangleLines(ESPComponent.MainCamera, bounds, c);
								Vector3 vector3 = DrawUtilities.Get2DW2SVector(ESPComponent.MainCamera, rectangleLines, location);
								if (MirrorCameraOptions.Enabled)
								{
									if (rectangleLines.Any(new Func<Vector2, bool>(ESPComponent.<>c.<>c_0.method_0)))
									{
										Highlighter component2 = gobject.GetComponent<Highlighter>();
										if (component2 != null)
										{
											component2.ConstantOffImmediate();
											goto IL_14D8;
										}
										goto IL_14D8;
									}
								}
								if (espvisual.Boxes)
								{
									if (espvisual.TwoDimensional)
									{
										DrawUtilities.PrepareRectangleLines(rectangleLines, Color.cyan);
									}
									else
									{
										DrawUtilities.PrepareBoxLines(boxVectors, Color.cyan);
										vector3 = DrawUtilities.Get3DW2SVector(ESPComponent.MainCamera, bounds, location);
									}
								}
								Color.white;
								Color.white;
								if (espvisual.Glow)
								{
									Highlighter highlighter = espobject.GObject.GetComponent<Highlighter>() ?? espobject.GObject.AddComponent<Highlighter>();
									highlighter.occluder = true;
									highlighter.overlay = true;
									highlighter.ConstantOnImmediate(Color.cyan);
									ESPComponent.Highlighters.Add(highlighter);
								}
								else
								{
									Highlighter component3 = gobject.GetComponent<Highlighter>();
									if (component3 != null)
									{
										component3.ConstantOffImmediate();
									}
								}
								if (ESPOptions.EspStyle)
								{
									DrawUtilities.DrawLabel(ESPComponent.ESPFont, location, vector3, text, espvisual.CustomTextColor ? color : color, Color.black, espvisual.BorderStrength, text2, 12);
								}
								if (ESPOptions.EspStyle1)
								{
									GUI.DrawTexture(new Rect(CS$<>8__locals1.vector3_0.x - 20f, (float)Screen.height - CS$<>8__locals1.vector3_0.y - 10f, 200f, 25f), Main.Espstyle1);
									GUI.Label(new Rect(CS$<>8__locals1.vector3_0.x - 10f, (float)Screen.height - CS$<>8__locals1.vector3_0.y + 20f, 180f, 60f), text);
								}
								if (ESPOptions.EspStyle2)
								{
									GUI.DrawTexture(new Rect(CS$<>8__locals1.vector3_0.x - 20f, (float)Screen.height - CS$<>8__locals1.vector3_0.y - 10f, 200f, 25f), Main.Espstyle2);
									GUI.Label(new Rect(CS$<>8__locals1.vector3_0.x - 10f, (float)Screen.height - CS$<>8__locals1.vector3_0.y + 20f, 180f, 60f), text);
								}
								if (ESPOptions.EspStyle3)
								{
									GUI.DrawTexture(new Rect(CS$<>8__locals1.vector3_0.x - 20f, (float)Screen.height - CS$<>8__locals1.vector3_0.y - 10f, 200f, 25f), Main.Espstyle3);
									GUI.Label(new Rect(CS$<>8__locals1.vector3_0.x - 10f, (float)Screen.height - CS$<>8__locals1.vector3_0.y + 20f, 180f, 60f), text);
								}
								if (ESPOptions.EspStyle4)
								{
									GUI.DrawTexture(new Rect(CS$<>8__locals1.vector3_0.x - 20f, (float)Screen.height - CS$<>8__locals1.vector3_0.y - 10f, 200f, 25f), Main.Espstyle4);
									GUI.Label(new Rect(CS$<>8__locals1.vector3_0.x - 10f, (float)Screen.height - CS$<>8__locals1.vector3_0.y + 20f, 180f, 60f), text);
								}
								if (ESPOptions.EspStyle5)
								{
									GUI.DrawTexture(new Rect(CS$<>8__locals1.vector3_0.x - 20f, (float)Screen.height - CS$<>8__locals1.vector3_0.y - 10f, 200f, 25f), Main.Espstyle5);
									GUI.Label(new Rect(CS$<>8__locals1.vector3_0.x - 10f, (float)Screen.height - CS$<>8__locals1.vector3_0.y + 20f, 180f, 60f), text);
								}
								if (espvisual.LineToObject)
								{
									ESPVariables.DrawBuffer2.Enqueue(new ESPBox2
									{
										Color = Color.cyan,
										Vertices = new Vector2[]
										{
											new Vector2((float)(Screen.width / 2), (float)Screen.height),
											new Vector2(CS$<>8__locals1.vector3_0.x, (float)Screen.height - CS$<>8__locals1.vector3_0.y)
										}
									});
								}
							}
						}
					}
				}
				IL_14D8:;
			}
			T.DrawMaterial.SetPass(0);
			GL.PushMatrix();
			GL.LoadProjectionMatrix(ESPComponent.MainCamera.projectionMatrix);
			GL.modelview = ESPComponent.MainCamera.worldToCameraMatrix;
			GL.Begin(1);
			for (int j = 0; j < ESPVariables.DrawBuffer.Count; j++)
			{
				ESPBox espbox = ESPVariables.DrawBuffer.Dequeue();
				GL.Color(espbox.Color);
				Vector3[] vertices = espbox.Vertices;
				for (int k = 0; k < vertices.Length; k++)
				{
					GL.Vertex(vertices[k]);
				}
			}
			GL.End();
			GL.PopMatrix();
			GL.PushMatrix();
			GL.Begin(1);
			int l = 0;
			IL_1642:
			while (l < ESPVariables.DrawBuffer2.Count)
			{
				ESPBox2 espbox2 = ESPVariables.DrawBuffer2.Dequeue();
				GL.Color(espbox2.Color);
				Vector2[] vertices2 = espbox2.Vertices;
				bool flag = true;
				for (int m = 0; m < vertices2.Length; m++)
				{
					if (m < vertices2.Length - 1)
					{
						Vector2 vector4 = vertices2[m];
						if (Vector2.Distance(vertices2[m + 1], vector4) > (float)(Screen.width / 2))
						{
							flag = false;
							IL_15FF:
							if (flag)
							{
								for (int n = 0; n < vertices2.Length; n++)
								{
									GL.Vertex3(vertices2[n].x, vertices2[n].y, 0f);
								}
							}
							l++;
							goto IL_1642;
						}
					}
				}
				goto IL_15FF;
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003665 File Offset: 0x00001865
		public static T FindItemByGuidOrLegacyId<T>(Guid guid, ushort legacyId) where T : ItemAsset
		{
			if (GuidExtension.IsEmpty(guid))
			{
				return Assets.find(1, legacyId) as T;
			}
			return Assets.find<T>(guid);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000123F4 File Offset: 0x000105F4
		public static void DisableHighlighters()
		{
			foreach (Highlighter highlighter in ESPComponent.Highlighters)
			{
				highlighter.occluder = false;
				highlighter.overlay = false;
				highlighter.ConstantOffImmediate();
			}
			ESPComponent.Highlighters.Clear();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003687 File Offset: 0x00001887
		public static string SentryName(Item DisplayItem, bool color)
		{
			if (DisplayItem != null)
			{
				return Assets.find(1, DisplayItem.id).name;
			}
			if (!color)
			{
				return "-No Item";
			}
			return "<color=#ff0000>No Item</color>";
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000036AE File Offset: 0x000018AE
		public static string GetPowered(InteractableGenerator Generator, bool color)
		{
			if (!Generator.isPowered)
			{
				if (color)
				{
					return "<color=#ff0000ff>OFF</color>";
				}
				return "-OFF";
			}
			else
			{
				if (!color)
				{
					return "-ON";
				}
				return "<color=#00ff00ff>-ON</color>";
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00012460 File Offset: 0x00010660
		public static SteamPlayer GetSteamPlayer(Player player)
		{
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				if (steamPlayer.player == player)
				{
					return steamPlayer;
				}
			}
			return null;
		}

		// Token: 0x0400014F RID: 335
		public static FieldInfo AmmoInfo = typeof(UseableGun).GetField("ammo", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000150 RID: 336
		public static Font ESPFont;

		// Token: 0x04000151 RID: 337
		public static List<Highlighter> Highlighters = new List<Highlighter>();

		// Token: 0x04000152 RID: 338
		public static Camera MainCamera;
	}
}
