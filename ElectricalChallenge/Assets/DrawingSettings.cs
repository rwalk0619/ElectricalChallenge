using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace FreeDraw
{
    // Helper methods used to set drawing settings
    public class DrawingSettings : MonoBehaviour
    {
        public static bool IsCursorOverUI = false;
        [FormerlySerializedAs("Transparency")] public float transparency = 1f;

        // Changing pen settings is easy as changing the static properties Drawable.Pen_Colour and Drawable.Pen_Width
        public void SetMarkerColour(Color newColor)
        {
            Drawable.Pen_Colour = newColor;
        }
        // new_width is radius in pixels
        public void SetMarkerWidth(int newWidth)
        {
            Drawable.Pen_Width = newWidth;
        }
        public void SetMarkerWidth(float newWidth)
        {
            SetMarkerWidth((int)newWidth);
        }

        public void SetTransparency(float amount)
        {
            transparency = amount;
            Color c = Drawable.Pen_Colour;
            c.a = amount;
            Drawable.Pen_Colour = c;
        }

        public void SetMarkerBlack()
        {
            GameObject.Find("Background").GetComponent<Drawable>().enabled = true;
            Color c = Color.black;
            c.a = transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
            Drawable.Pen_Width = 1;
        }

        public void SetEraser()
        {
            GameObject.Find("Background").GetComponent<Drawable>().enabled = true;
            Drawable.Pen_Width = 10;
            SetMarkerColour(new Color(255f, 255f, 255f, 0f));
        }

        public void PartialSetEraser()
        {
            SetMarkerColour(new Color(255f, 255f, 255f, 0.5f));
        }
    }
}