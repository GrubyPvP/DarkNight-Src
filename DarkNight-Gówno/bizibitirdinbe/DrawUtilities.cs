using System;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000AC RID: 172
	public static class DrawUtilities
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0000436C File Offset: 0x0000256C
		public static bool ShouldRun()
		{
			return Provider.isConnected && !Provider.isLoading && !LoadingUI.isBlocked && OptimizationVariables.MainPlayer != null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00018F50 File Offset: 0x00017150
		public static void DrawESPLabel(Vector3 worldpos, Color textcolor, Color outlinecolor, string text, string outlinetext = null)
		{
			GUIContent guicontent = new GUIContent(text);
			if (outlinetext == null)
			{
				outlinetext = text;
			}
			GUIContent guicontent2 = new GUIContent(outlinetext);
			GUIStyle label = GUI.skin.label;
			label.alignment = 4;
			Vector2 vector = label.CalcSize(guicontent);
			Vector3 vector2 = G.MainCamera.WorldToScreenPoint(worldpos);
			vector2.y = (float)Screen.height - vector2.y;
			if (vector2.z >= 0f)
			{
				GUI.color = Color.black;
				GUI.Label(new Rect(vector2.x - vector.x / 2f + 1f, vector2.y + 1f, vector.x, vector.y), guicontent2);
				GUI.Label(new Rect(vector2.x - vector.x / 2f - 1f, vector2.y - 1f, vector.x, vector.y), guicontent2);
				GUI.Label(new Rect(vector2.x - vector.x / 2f + 1f, vector2.y - 1f, vector.x, vector.y), guicontent2);
				GUI.Label(new Rect(vector2.x - vector.x / 2f - 1f, vector2.y + 1f, vector.x, vector.y), guicontent2);
				GUI.color = textcolor;
				GUI.Label(new Rect(vector2.x - vector.x / 2f, vector2.y, vector.x, vector.y), guicontent);
				GUI.color = Main.GUIColor;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001911C File Offset: 0x0001731C
		public static int GetTextSize(ESPVisual vis, double dist)
		{
			int result;
			if (!vis.TextScaling)
			{
				result = vis.FixedTextSize;
			}
			else if (dist > (double)vis.MinTextSizeDistance)
			{
				result = vis.MinTextSize;
			}
			else
			{
				int num = vis.MaxTextSize - vis.MinTextSize;
				double num2 = (double)(vis.MinTextSizeDistance / (float)num);
				result = vis.MaxTextSize - (int)(dist / num2);
			}
			return result;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00019180 File Offset: 0x00017380
		public static Vector2[] GetRectangleLines(Camera cam, Bounds b, Color c)
		{
			Vector3[] array = new Vector3[]
			{
				cam.WorldToScreenPoint(new Vector3(b.center.x + b.extents.x, b.center.y + b.extents.y, b.center.z + b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x + b.extents.x, b.center.y + b.extents.y, b.center.z - b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x + b.extents.x, b.center.y - b.extents.y, b.center.z + b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x + b.extents.x, b.center.y - b.extents.y, b.center.z - b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x - b.extents.x, b.center.y + b.extents.y, b.center.z + b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x - b.extents.x, b.center.y + b.extents.y, b.center.z - b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x - b.extents.x, b.center.y - b.extents.y, b.center.z + b.extents.z)),
				cam.WorldToScreenPoint(new Vector3(b.center.x - b.extents.x, b.center.y - b.extents.y, b.center.z - b.extents.z))
			};
			for (int i = 0; i < array.Length; i++)
			{
				array[i].y = (float)Screen.height - array[i].y;
			}
			Vector3 vector = array[0];
			Vector3 vector2 = array[0];
			for (int j = 1; j < array.Length; j++)
			{
				vector = Vector3.Min(vector, array[j]);
				vector2 = Vector3.Max(vector2, array[j]);
			}
			return new Vector2[]
			{
				new Vector2(vector.x, vector.y),
				new Vector2(vector2.x, vector.y),
				new Vector2(vector.x, vector2.y),
				new Vector2(vector2.x, vector2.y)
			};
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001956C File Offset: 0x0001776C
		public static Bounds GetBoundsRecursively(GameObject go)
		{
			Bounds result = default(Bounds);
			Collider[] componentsInChildren = go.GetComponentsInChildren<Collider>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				result.Encapsulate(componentsInChildren[i].bounds);
			}
			return result;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000195B0 File Offset: 0x000177B0
		public static Bounds TransformBounds(Transform _transform, Bounds _localBounds)
		{
			Vector3 center = _transform.TransformPoint(_localBounds.center);
			Vector3 extents = _localBounds.extents;
			Vector3 vector = _transform.TransformVector(extents.x, 0f, 0f);
			Vector3 vector2 = _transform.TransformVector(0f, extents.y, 0f);
			Vector3 vector3 = _transform.TransformVector(0f, 0f, extents.z);
			extents.x = Mathf.Abs(vector.x) + Mathf.Abs(vector2.x) + Mathf.Abs(vector3.x);
			extents.y = Mathf.Abs(vector.y) + Mathf.Abs(vector2.y) + Mathf.Abs(vector3.y);
			extents.z = Mathf.Abs(vector.z) + Mathf.Abs(vector2.z) + Mathf.Abs(vector3.z);
			Bounds result = default(Bounds);
			result.center = center;
			result.extents = extents;
			return result;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000196C4 File Offset: 0x000178C4
		public static void DrawTextWithOutline(Rect centerRect, string text, GUIStyle style, Color innerColor, Color borderColor, int borderWidth, string outlineText = null)
		{
			if (outlineText == null)
			{
				outlineText = text;
			}
			style.normal.textColor = borderColor;
			Rect rect = centerRect;
			rect.x -= (float)borderWidth;
			rect.y -= (float)borderWidth;
			GUI.Label(rect, text, style);
			while (rect.x <= centerRect.x + (float)borderWidth)
			{
				float x = rect.x;
				rect.x = x + 1f;
				GUI.Label(rect, outlineText, style);
			}
			while (rect.y <= centerRect.y + (float)borderWidth)
			{
				float y = rect.y;
				rect.y = y + 1f;
				GUI.Label(rect, outlineText, style);
			}
			while (rect.x >= centerRect.x - (float)borderWidth)
			{
				float x2 = rect.x;
				rect.x = x2 - 1f;
				GUI.Label(rect, outlineText, style);
			}
			while (rect.y >= centerRect.y - (float)borderWidth)
			{
				float y2 = rect.y;
				rect.y = y2 - 1f;
				GUI.Label(rect, outlineText, style);
			}
			style.normal.textColor = innerColor;
			GUI.Label(centerRect, text, style);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00004390 File Offset: 0x00002590
		public static Vector2 InvertScreenSpace(Vector2 dim)
		{
			return new Vector2(dim.x, (float)Screen.height - dim.y);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001980C File Offset: 0x00017A0C
		public static string ColorToHex(Color32 color)
		{
			return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2") + color.a.ToString("X2");
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00019868 File Offset: 0x00017A68
		public static void DrawLabel(Font Font, LabelLocation Location, Vector2 vector2_0, string Content, Color BorderColor, Color InnerColor, int BorderWidth, string outerContent = null, int fontSize = 12)
		{
			GUIContent guicontent = new GUIContent(Content);
			GUIStyle guistyle = new GUIStyle
			{
				font = Font,
				fontSize = fontSize
			};
			Vector2 vector = guistyle.CalcSize(guicontent);
			float x = vector.x;
			float y = vector.y;
			Rect centerRect;
			centerRect..ctor(0f, 0f, x, y);
			switch (Location)
			{
			case LabelLocation.TopRight:
				centerRect.x = vector2_0.x;
				centerRect.y = vector2_0.y - y;
				guistyle.alignment = 0;
				break;
			case LabelLocation.TopMiddle:
				centerRect.x = vector2_0.x - x / 2f;
				centerRect.y = vector2_0.y - y;
				guistyle.alignment = 7;
				break;
			case LabelLocation.TopLeft:
				centerRect.x = vector2_0.x - x;
				centerRect.y = vector2_0.y - y;
				guistyle.alignment = 2;
				break;
			case LabelLocation.MiddleRight:
				centerRect.x = vector2_0.x;
				centerRect.y = vector2_0.y - y / 2f;
				guistyle.alignment = 3;
				break;
			case LabelLocation.Center:
				centerRect.x = vector2_0.x - x / 2f;
				centerRect.y = vector2_0.y - y / 2f;
				guistyle.alignment = 4;
				break;
			case LabelLocation.MiddleLeft:
				centerRect.x = vector2_0.x - x;
				centerRect.y = vector2_0.y - y / 2f;
				guistyle.alignment = 5;
				break;
			case LabelLocation.BottomRight:
				centerRect.x = vector2_0.x;
				centerRect.y = vector2_0.y;
				guistyle.alignment = 6;
				break;
			case LabelLocation.BottomMiddle:
				centerRect.x = vector2_0.x - x / 2f;
				centerRect.y = vector2_0.y;
				guistyle.alignment = 1;
				break;
			case LabelLocation.BottomLeft:
				centerRect.x = vector2_0.x - x;
				centerRect.y = vector2_0.y;
				guistyle.alignment = 8;
				break;
			}
			if (centerRect.x - 10f >= 0f && centerRect.y - 10f >= 0f && centerRect.x + 10f <= (float)Screen.width && centerRect.y + 10f <= (float)Screen.height)
			{
				DrawUtilities.DrawTextWithOutline(centerRect, guicontent.text, guistyle, BorderColor, InnerColor, BorderWidth, outerContent);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00019AFC File Offset: 0x00017CFC
		public static Vector2 Get3DW2SVector(Camera cam, Bounds b, LabelLocation location)
		{
			Vector2 result;
			switch (location)
			{
			case LabelLocation.TopRight:
			case LabelLocation.TopMiddle:
			case LabelLocation.TopLeft:
				result = DrawUtilities.InvertScreenSpace(cam.WorldToScreenPoint(new Vector3(b.center.x, b.center.y + b.extents.y, b.center.z)));
				break;
			case LabelLocation.MiddleRight:
			case LabelLocation.Center:
			case LabelLocation.MiddleLeft:
				result = DrawUtilities.InvertScreenSpace(cam.WorldToScreenPoint(b.center));
				break;
			case LabelLocation.BottomRight:
			case LabelLocation.BottomMiddle:
			case LabelLocation.BottomLeft:
				result = DrawUtilities.InvertScreenSpace(cam.WorldToScreenPoint(new Vector3(b.center.x, b.center.y - b.extents.y, b.center.z)));
				break;
			default:
				result = Vector2.zero;
				break;
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00019BF0 File Offset: 0x00017DF0
		public static Vector2 Get2DW2SVector(Camera cam, Vector2[] Corners, LabelLocation location)
		{
			Vector2 result;
			switch (location)
			{
			case LabelLocation.TopRight:
				result = Corners[1];
				break;
			case LabelLocation.TopMiddle:
				result..ctor((Corners[0].x + Corners[1].x) / 2f, Corners[0].y);
				break;
			case LabelLocation.TopLeft:
				result = Corners[0];
				break;
			case LabelLocation.MiddleRight:
				result..ctor(Corners[0].x, (Corners[1].y + Corners[2].y) / 2f);
				break;
			case LabelLocation.Center:
				result..ctor(Corners[2].x, (Corners[1].y + Corners[2].y) / 2f);
				break;
			case LabelLocation.MiddleLeft:
				result..ctor((Corners[2].x + Corners[3].x) / 2f, (Corners[1].y + Corners[2].y) / 2f);
				break;
			case LabelLocation.BottomRight:
				result = Corners[2];
				break;
			case LabelLocation.BottomMiddle:
				result..ctor((Corners[2].x + Corners[3].x) / 2f, Corners[2].y);
				break;
			case LabelLocation.BottomLeft:
				result = Corners[3];
				break;
			default:
				result = Vector2.zero;
				break;
			}
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00019D88 File Offset: 0x00017F88
		public static Vector3[] GetBoxVectors(Bounds b)
		{
			Vector3 center = b.center;
			Vector3 extents = b.extents;
			return new Vector3[]
			{
				new Vector3(center.x - extents.x, center.y + extents.y, center.z - extents.z),
				new Vector3(center.x + extents.x, center.y + extents.y, center.z - extents.z),
				new Vector3(center.x - extents.x, center.y - extents.y, center.z - extents.z),
				new Vector3(center.x + extents.x, center.y - extents.y, center.z - extents.z),
				new Vector3(center.x - extents.x, center.y + extents.y, center.z + extents.z),
				new Vector3(center.x + extents.x, center.y + extents.y, center.z + extents.z),
				new Vector3(center.x - extents.x, center.y - extents.y, center.z + extents.z),
				new Vector3(center.x + extents.x, center.y - extents.y, center.z + extents.z)
			};
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00019F78 File Offset: 0x00018178
		public static void PrepareRectangleLines(Vector2[] nvectors, Color c)
		{
			ESPVariables.DrawBuffer2.Enqueue(new ESPBox2
			{
				Color = c,
				Vertices = new Vector2[]
				{
					nvectors[0],
					nvectors[1],
					nvectors[1],
					nvectors[3],
					nvectors[3],
					nvectors[2],
					nvectors[2],
					nvectors[0]
				}
			});
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001A020 File Offset: 0x00018220
		public static void PrepareBoxLines(Vector3[] vectors, Color c)
		{
			ESPVariables.DrawBuffer.Enqueue(new ESPBox
			{
				Color = c,
				Vertices = new Vector3[]
				{
					vectors[0],
					vectors[1],
					vectors[1],
					vectors[3],
					vectors[3],
					vectors[2],
					vectors[2],
					vectors[0],
					vectors[4],
					vectors[5],
					vectors[5],
					vectors[7],
					vectors[7],
					vectors[6],
					vectors[6],
					vectors[4],
					vectors[0],
					vectors[4],
					vectors[1],
					vectors[5],
					vectors[2],
					vectors[6],
					vectors[3],
					vectors[7]
				}
			});
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001A1B8 File Offset: 0x000183B8
		public static void DrawCircle(Color Col, Vector2 Center, float Radius)
		{
			GL.PushMatrix();
			T.DrawMaterial.SetPass(0);
			GL.Begin(1);
			GL.Color(Col);
			for (float num = 0f; num < 6.2831855f; num += RaycastOptions.float_0)
			{
				GL.Vertex(new Vector3(Mathf.Cos(num) * Radius + Center.x, Mathf.Sin(num) * Radius + Center.y));
				GL.Vertex(new Vector3(Mathf.Cos(num + RaycastOptions.float_0) * Radius + Center.x, Mathf.Sin(num + RaycastOptions.float_0) * Radius + Center.y));
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001A268 File Offset: 0x00018468
		public static void DrawMenuRect(float x, float y, float width, float height, Color fillcolor)
		{
			Color black = Color.black;
			Drawing.DrawRect(new Rect(x, y, width, 5f), black, null);
			Drawing.DrawRect(new Rect(x, y, 5f, height), black, null);
			Drawing.DrawRect(new Rect(x, y + (height - 5f), width, 5f), black, null);
			Drawing.DrawRect(new Rect(x + (width - 5f), 0f, 5f, height), black, null);
			Drawing.DrawRect(new Rect(5f, 5f, width - 10f, height - 10f), fillcolor, null);
		}

		// Token: 0x040003CF RID: 975
		public static Color GUIColor;
	}
}
