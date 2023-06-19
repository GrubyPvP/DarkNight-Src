using System;
using System.Reflection;
using HighlightingSystem;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000A0 RID: 160
	public class OV_PlayerInteract
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00017970 File Offset: 0x00015B70
		[Initializer]
		public static void Init()
		{
			OV_PlayerInteract.FocusField = typeof(PlayerInteract).GetField("focus", ReflectionVariables.publicStatic);
			OV_PlayerInteract.TargetField = typeof(PlayerInteract).GetField("target", ReflectionVariables.publicStatic);
			OV_PlayerInteract.InteractableField = typeof(PlayerInteract).GetField("_interactable", ReflectionVariables.publicStatic);
			OV_PlayerInteract.fieldInfo_0 = typeof(PlayerInteract).GetField("_interactable2", ReflectionVariables.publicStatic);
			OV_PlayerInteract.PurchaseAssetField = typeof(PlayerInteract).GetField("purchaseAsset", ReflectionVariables.publicStatic);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00004109 File Offset: 0x00002309
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000411B File Offset: 0x0000231B
		public static Transform focus
		{
			get
			{
				return (Transform)OV_PlayerInteract.FocusField.GetValue(null);
			}
			set
			{
				OV_PlayerInteract.FocusField.SetValue(null, value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00004129 File Offset: 0x00002329
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000413B File Offset: 0x0000233B
		public static Transform target
		{
			get
			{
				return (Transform)OV_PlayerInteract.TargetField.GetValue(null);
			}
			set
			{
				OV_PlayerInteract.TargetField.SetValue(null, value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00004149 File Offset: 0x00002349
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000415B File Offset: 0x0000235B
		public static Interactable interactable
		{
			get
			{
				return (Interactable)OV_PlayerInteract.InteractableField.GetValue(null);
			}
			set
			{
				OV_PlayerInteract.InteractableField.SetValue(null, value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00004169 File Offset: 0x00002369
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000417B File Offset: 0x0000237B
		public static Interactable2 interactable2
		{
			get
			{
				return (Interactable2)OV_PlayerInteract.fieldInfo_0.GetValue(null);
			}
			set
			{
				OV_PlayerInteract.fieldInfo_0.SetValue(null, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00004189 File Offset: 0x00002389
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000419B File Offset: 0x0000239B
		public static ItemAsset purchaseAsset
		{
			get
			{
				return (ItemAsset)OV_PlayerInteract.PurchaseAssetField.GetValue(null);
			}
			set
			{
				OV_PlayerInteract.PurchaseAssetField.SetValue(null, value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000041A9 File Offset: 0x000023A9
		public float salvageTime
		{
			get
			{
				if (MiscOptions.CustomSalvageTime)
				{
					return MiscOptions.SalvageTime;
				}
				if (!OptimizationVariables.MainPlayer.channel.owner.isAdmin)
				{
					return 8f;
				}
				return 1f;
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000041D9 File Offset: 0x000023D9
		public void onPurchaseUpdated(PurchaseNode node)
		{
			if (node != null)
			{
				OV_PlayerInteract.purchaseAsset = (ItemAsset)Assets.find(1, node.id);
				return;
			}
			OV_PlayerInteract.purchaseAsset = null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00017A18 File Offset: 0x00015C18
		public static void highlight(Transform target, Color color)
		{
			if (!target.CompareTag("Player") || target.CompareTag("Enemy") || target.CompareTag("Zombie") || target.CompareTag("Animal") || target.CompareTag("Agent"))
			{
				Highlighter highlighter = target.GetComponent<Highlighter>();
				if (highlighter == null)
				{
					highlighter = target.gameObject.AddComponent<Highlighter>();
				}
				highlighter.ConstantOn(color, 0.25f);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00017A98 File Offset: 0x00015C98
		[OnSpy]
		public static void OnSpied()
		{
			Transform transform = OptimizationVariables.MainCam.transform;
			if (transform != null)
			{
				Physics.Raycast(new Ray(transform.position, transform.forward), ref OV_PlayerInteract.hit, (float)((OptimizationVariables.MainPlayer.look.perspective == 1) ? 6 : 4), RayMasks.PLAYER_INTERACT, 0);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00017AF8 File Offset: 0x00015CF8
		[Override(typeof(PlayerInteract), "Update", BindingFlags.Instance | BindingFlags.NonPublic, 0)]
		public void OV_Update()
		{
			if (!DrawUtilities.ShouldRun())
			{
				return;
			}
			if (OptimizationVariables.MainPlayer.stance.stance != 6 && OptimizationVariables.MainPlayer.stance.stance != 7 && !OptimizationVariables.MainPlayer.life.isDead && !OptimizationVariables.MainPlayer.workzone.isBuilding)
			{
				if (Time.realtimeSinceStartup - OV_PlayerInteract.lastInteract > 0.1f)
				{
					int num = 0;
					if (InteractionOptions.InteractThroughWalls && !G.BeingSpied)
					{
						if (!InteractionOptions.NoHitBarricades)
						{
							num |= 134217728;
						}
						if (!InteractionOptions.NoHitItems)
						{
							num |= 8192;
						}
						if (!InteractionOptions.NoHitResources)
						{
							num |= 16384;
						}
						if (!InteractionOptions.NoHitStructures)
						{
							num |= 268435456;
						}
						if (!InteractionOptions.NoHitVehicles)
						{
							num |= 67108864;
						}
						if (!InteractionOptions.NoHitEnvironment)
						{
							num |= 1671168;
						}
					}
					else
					{
						num = RayMasks.PLAYER_INTERACT;
					}
					OV_PlayerInteract.lastInteract = Time.realtimeSinceStartup;
					float num2 = (!InteractionOptions.InteractThroughWalls || G.BeingSpied) ? 4f : 20f;
					Physics.Raycast(new Ray(Camera.main.transform.position, Camera.main.transform.forward), ref OV_PlayerInteract.hit, (OptimizationVariables.MainPlayer.look.perspective == 1) ? (num2 + 2f) : num2, num, 0);
				}
				Transform transform = (!(OV_PlayerInteract.hit.collider != null)) ? null : OV_PlayerInteract.hit.collider.transform;
				if (transform != OV_PlayerInteract.focus)
				{
					if (OV_PlayerInteract.focus != null && PlayerInteract.interactable != null)
					{
						InteractableDoorHinge componentInParent = OV_PlayerInteract.focus.GetComponentInParent<InteractableDoorHinge>();
						if (componentInParent != null)
						{
							HighlighterTool.unhighlight(componentInParent.door.transform);
						}
						else
						{
							HighlighterTool.unhighlight(PlayerInteract.interactable.transform);
						}
					}
					OV_PlayerInteract.focus = null;
					OV_PlayerInteract.target = null;
					OV_PlayerInteract.interactable = null;
					OV_PlayerInteract.interactable2 = null;
					if (transform != null)
					{
						OV_PlayerInteract.focus = transform;
						OV_PlayerInteract.interactable = OV_PlayerInteract.focus.GetComponentInParent<Interactable>();
						OV_PlayerInteract.interactable2 = OV_PlayerInteract.focus.GetComponentInParent<Interactable2>();
						if (PlayerInteract.interactable != null)
						{
							OV_PlayerInteract.target = TransformRecursiveFind.FindChildRecursive(PlayerInteract.interactable.transform, "Target");
							if (PlayerInteract.interactable.checkInteractable())
							{
								if (PlayerUI.window.isEnabled)
								{
									if (PlayerInteract.interactable.checkUseable())
									{
										Color green;
										if (!PlayerInteract.interactable.checkHighlight(ref green))
										{
											green = Color.green;
										}
										InteractableDoorHinge componentInParent2 = OV_PlayerInteract.focus.GetComponentInParent<InteractableDoorHinge>();
										if (componentInParent2 != null)
										{
											HighlighterTool.highlight(componentInParent2.door.transform, green);
										}
										else
										{
											HighlighterTool.highlight(PlayerInteract.interactable.transform, green);
										}
									}
									else
									{
										Color red = Color.red;
										InteractableDoorHinge componentInParent3 = OV_PlayerInteract.focus.GetComponentInParent<InteractableDoorHinge>();
										if (componentInParent3 != null)
										{
											HighlighterTool.highlight(componentInParent3.door.transform, red);
										}
										else
										{
											HighlighterTool.highlight(PlayerInteract.interactable.transform, red);
										}
									}
								}
							}
							else
							{
								OV_PlayerInteract.target = null;
								OV_PlayerInteract.interactable = null;
							}
						}
					}
				}
			}
			else
			{
				if (OV_PlayerInteract.focus != null && PlayerInteract.interactable != null)
				{
					InteractableDoorHinge componentInParent4 = OV_PlayerInteract.focus.GetComponentInParent<InteractableDoorHinge>();
					if (componentInParent4 != null)
					{
						HighlighterTool.unhighlight(componentInParent4.door.transform);
					}
					else
					{
						HighlighterTool.unhighlight(PlayerInteract.interactable.transform);
					}
				}
				OV_PlayerInteract.focus = null;
				OV_PlayerInteract.target = null;
				OV_PlayerInteract.interactable = null;
				OV_PlayerInteract.interactable2 = null;
			}
			if (OptimizationVariables.MainPlayer.life.isDead)
			{
				return;
			}
			if (PlayerInteract.interactable != null)
			{
				EPlayerMessage eplayerMessage;
				string text;
				Color color;
				if (PlayerInteract.interactable.checkHint(ref eplayerMessage, ref text, ref color) && !PlayerUI.window.showCursor)
				{
					if (PlayerInteract.interactable.CompareTag("Item"))
					{
						PlayerUI.hint((!(OV_PlayerInteract.target != null)) ? OV_PlayerInteract.focus : OV_PlayerInteract.target, eplayerMessage, text, color, new object[]
						{
							((InteractableItem)PlayerInteract.interactable).item,
							((InteractableItem)PlayerInteract.interactable).asset
						});
					}
					else
					{
						PlayerUI.hint((OV_PlayerInteract.target != null) ? OV_PlayerInteract.target : OV_PlayerInteract.focus, eplayerMessage, text, color, new object[0]);
					}
				}
			}
			else if (OV_PlayerInteract.purchaseAsset != null && OptimizationVariables.MainPlayer.movement.purchaseNode != null && !PlayerUI.window.showCursor)
			{
				PlayerUI.hint(null, 47, string.Empty, Color.white, new object[]
				{
					OV_PlayerInteract.purchaseAsset.itemName,
					OptimizationVariables.MainPlayer.movement.purchaseNode.cost
				});
			}
			else if (OV_PlayerInteract.focus != null && OV_PlayerInteract.focus.CompareTag("Enemy"))
			{
				Player player = DamageTool.getPlayer(OV_PlayerInteract.focus);
				if (player != null && player != Player.player && !PlayerUI.window.showCursor)
				{
					PlayerUI.hint(null, 11, string.Empty, Color.white, new object[]
					{
						player.channel.owner
					});
				}
			}
			EPlayerMessage eplayerMessage2;
			float num3;
			if (PlayerInteract.interactable2 != null && PlayerInteract.interactable2.checkHint(ref eplayerMessage2, ref num3) && !PlayerUI.window.showCursor)
			{
				PlayerUI.hint2(eplayerMessage2, (!OV_PlayerInteract.isHoldingKey) ? 0f : ((Time.realtimeSinceStartup - OV_PlayerInteract.lastKeyDown) / this.salvageTime), num3);
			}
			if (Input.GetKeyDown(ControlsSettings.interact))
			{
				OV_PlayerInteract.lastKeyDown = Time.realtimeSinceStartup;
				OV_PlayerInteract.isHoldingKey = true;
			}
			if (Input.GetKeyDown(ControlsSettings.inspect) && ControlsSettings.inspect != ControlsSettings.interact && OptimizationVariables.MainPlayer.equipment.canInspect)
			{
				OptimizationVariables.MainPlayer.channel.send("askInspect", 0, 1, new object[0]);
			}
			if (OV_PlayerInteract.isHoldingKey)
			{
				if (Input.GetKeyUp(ControlsSettings.interact))
				{
					OV_PlayerInteract.isHoldingKey = false;
					if (!PlayerUI.window.showCursor)
					{
						if (OptimizationVariables.MainPlayer.stance.stance != 6)
						{
							if (OptimizationVariables.MainPlayer.stance.stance != 7)
							{
								if (OV_PlayerInteract.focus != null && PlayerInteract.interactable != null)
								{
									if (PlayerInteract.interactable.checkUseable())
									{
										PlayerInteract.interactable.use();
										return;
									}
									return;
								}
								else if (OV_PlayerInteract.purchaseAsset != null)
								{
									if (OptimizationVariables.MainPlayer.skills.experience >= OptimizationVariables.MainPlayer.movement.purchaseNode.cost)
									{
										OptimizationVariables.MainPlayer.skills.sendPurchase(OptimizationVariables.MainPlayer.movement.purchaseNode);
										return;
									}
									return;
								}
								else
								{
									if (ControlsSettings.inspect == ControlsSettings.interact && OptimizationVariables.MainPlayer.equipment.canInspect)
									{
										OptimizationVariables.MainPlayer.channel.send("askInspect", 0, 1, new object[0]);
										return;
									}
									return;
								}
							}
						}
						VehicleManager.exitVehicle();
						return;
					}
					if (OptimizationVariables.MainPlayer.inventory.isStoring && OptimizationVariables.MainPlayer.inventory.shouldInteractCloseStorage)
					{
						PlayerDashboardUI.close();
						PlayerLifeUI.open();
						return;
					}
					if (PlayerBarricadeSignUI.active)
					{
						PlayerBarricadeSignUI.close();
						PlayerLifeUI.open();
						return;
					}
					if (PlayerBarricadeLibraryUI.active)
					{
						PlayerBarricadeLibraryUI.close();
						PlayerLifeUI.open();
						return;
					}
					if (PlayerNPCDialogueUI.active)
					{
						if (PlayerNPCDialogueUI.dialogueAnimating)
						{
							PlayerNPCDialogueUI.skipText();
							return;
						}
						if (!PlayerNPCDialogueUI.dialogueHasNextPage)
						{
							PlayerNPCDialogueUI.close();
							PlayerLifeUI.open();
							return;
						}
						PlayerNPCDialogueUI.nextPage();
						return;
					}
					else
					{
						if (PlayerNPCQuestUI.active)
						{
							PlayerNPCQuestUI.closeNicely();
							return;
						}
						if (PlayerNPCVendorUI.active)
						{
							PlayerNPCVendorUI.closeNicely();
							return;
						}
					}
				}
				else if (Time.realtimeSinceStartup - OV_PlayerInteract.lastKeyDown > this.salvageTime)
				{
					OV_PlayerInteract.isHoldingKey = false;
					if (!PlayerUI.window.showCursor && PlayerInteract.interactable2 != null)
					{
						PlayerInteract.interactable2.use();
					}
				}
			}
		}

		// Token: 0x040003C1 RID: 961
		public static FieldInfo FocusField;

		// Token: 0x040003C2 RID: 962
		public static FieldInfo TargetField;

		// Token: 0x040003C3 RID: 963
		public static FieldInfo InteractableField;

		// Token: 0x040003C4 RID: 964
		public static FieldInfo fieldInfo_0;

		// Token: 0x040003C5 RID: 965
		public static FieldInfo PurchaseAssetField;

		// Token: 0x040003C6 RID: 966
		public static bool isHoldingKey;

		// Token: 0x040003C7 RID: 967
		public static float lastInteract;

		// Token: 0x040003C8 RID: 968
		public static float lastKeyDown;

		// Token: 0x040003C9 RID: 969
		public static RaycastHit hit;
	}
}
