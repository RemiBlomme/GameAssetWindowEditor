using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

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

        private void OnGUI()
        {
            string[] guids = AssetDatabase.FindAssets("t:ArmorData");


            foreach (string guid in guids)
            {
                var assetPath = AssetDatabase.GUIDToAssetPath(guid);
                var currentSO = AssetDatabase.LoadAssetAtPath(assetPath, typeof(ArmorData)) as ArmorData;
                GUILayout.Label($"Found: {currentSO.m_name}");
            }
        }
    }
}
