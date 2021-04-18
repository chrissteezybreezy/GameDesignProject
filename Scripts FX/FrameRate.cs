using UnityEngine;
using System.Collections;

namespace SurvivalEngine
{
    public class FrameRate : MonoBehaviour
    {
        private float deltaTime = 0.0f;

        GUIStyle style;

        private void Start()
        {
            int w = Screen.width, h = Screen.height;
            style = new GUIStyle();
            style.alignment = TextAnchor.UpperLeft;
            style.fontSize = h * 2 / 100;
            style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        }

        void Update()
        {
            deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        }

        void OnGUI()
        {
            int w = Screen.width, h = Screen.height;
            Rect rect = new Rect(0, 0, w, h * 2 / 100);
            float msec = deltaTime * 1000.0f;
            float fps = 1.0f / deltaTime;
            string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
            GUI.Label(rect, text, style);
        }
    }
}