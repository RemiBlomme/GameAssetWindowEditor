using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.PackageManager.UI;

namespace GameAsset.Runtime
{
    public class ArmorWindowOpener : EditorWindow
    {
        [MenuItem("Armor/Open Armor")]
        public static void ShowWindow()
        {
            var window = GetWindow<ArmorWindowOpener>();
            window.titleContent = new GUIContent("Armors", "Armors and stuff");
            
        }

        [OnOpenAsset]
        public static bool OpenAsset(int assetId, int guId)
        {
            if (Selection.activeObject is ArmorData)
            {
                ShowWindow();
                return true;
            }
            return false;
        }

        Vector2 scrollPosition;
        private void OnGUI()
        {
            float _windowWidth = position.width;
            float _windowHeight = position.height;
            string[] guids = AssetDatabase.FindAssets("t:ArmorData");

            scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(_windowWidth), GUILayout.Height(_windowHeight));
            GUILayout.BeginArea(new Rect(0, 0, _windowWidth/4, _windowHeight));
            GUILayout.BeginVertical();
          
            foreach (string guid in guids)
            {

                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var currentSO = AssetDatabase.LoadAssetAtPath(assetPath, typeof(ArmorData)) as ArmorData;

                if (GUILayout.Button(currentSO.m_name))
                {
                    GUILayout.BeginArea(new Rect(0, 0, _windowWidth*(3/4),_windowHeight));

                    GUILayout.Label(currentSO.m_name);
                    GUILayout.Label(currentSO.m_description);
                    GUILayout.Label(currentSO.m_price.ToString());
                    GUILayout.Label(currentSO.m_name);
                    GUILayout.Label(currentSO.m_name);
                    GUILayout.Label(currentSO.m_name);

                    GUILayout.EndArea();
                };             
            }

            GUILayout.EndVertical();
            GUILayout.EndArea();
            GUILayout.EndScrollView();
          
        }
    }
}
