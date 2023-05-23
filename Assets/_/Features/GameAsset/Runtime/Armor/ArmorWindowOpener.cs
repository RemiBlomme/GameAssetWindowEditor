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
            GUILayout.BeginVertical();
            foreach (string guid in guids)
            {
                GUILayout.BeginHorizontal();
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var currentSO = AssetDatabase.LoadAssetAtPath(assetPath, typeof(ArmorData)) as ArmorData;
                GUILayout.Label($"Found: {currentSO.m_name}");
                GUILayout.Box(currentSO.m_icon);
                GUILayout.EndHorizontal();
               
            }
            GUILayout.EndVertical();
            GUILayout.EndScrollView();
          
        }
    }
}
