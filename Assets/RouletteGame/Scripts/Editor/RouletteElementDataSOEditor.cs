using RouletteGame.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace RouletteGame.EditorModules
{
    [CustomEditor(typeof(RouletteElementDataSO))]
    public class RouletteElementDataSOEditor : Editor
    {
        SerializedProperty rewardIconProp;

        void OnEnable()
        {
            rewardIconProp = serializedObject.FindProperty("rewardIcon");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            DrawDefaultInspector();

            if (rewardIconProp.objectReferenceValue != null)
            {
                Sprite sprite = (Sprite)rewardIconProp.objectReferenceValue;

                GUILayout.Space(10);
                GUILayout.Label("Icon Preview", EditorStyles.boldLabel);

                Rect container = GUILayoutUtility.GetRect(128, 128, GUILayout.ExpandWidth(false));
                float aspect = sprite.rect.width / sprite.rect.height;
                Rect drawRect = GetPreserveAspectRect(container, aspect);

                Rect spriteRect = sprite.rect;
                Texture2D texture = sprite.texture;

                Rect uv = new Rect(
                    spriteRect.x / texture.width,
                    spriteRect.y / texture.height,
                    spriteRect.width / texture.width,
                    spriteRect.height / texture.height
                );

                GUI.DrawTextureWithTexCoords(drawRect, texture, uv, true);
            }

            serializedObject.ApplyModifiedProperties();
        }

        private Rect GetPreserveAspectRect(Rect container, float aspect)
        {
            float containerAspect = container.width / container.height;

            if (containerAspect > aspect)
            {
                // Container geniþ, height baz al
                float height = container.height;
                float width = height * aspect;
                float x = container.x + (container.width - width) * 0.5f;
                return new Rect(x, container.y, width, height);
            }
            else
            {
                // Container dar, width baz al
                float width = container.width;
                float height = width / aspect;
                float y = container.y + (container.height - height) * 0.5f;
                return new Rect(container.x, y, width, height);
            }
        }
    }
}