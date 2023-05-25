using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class DamagesGUI : EditorWindow
    {
        [MenuItem("Tools/Damages")]
        public static void ShowWindow()
        {
            var window = GetWindow<DamagesGUI>();
            window.titleContent = new GUIContent("Damages");
        }

        private void OnGUI()
        {
            DamagesOnGUI();
        }

        public void DamagesOnGUI()
        {
            GUILayout.Label("Damages");

            GUILayout.Label("Type:");
            _salut = (Salut)EditorGUILayout.EnumPopup(_salut);
        }

        private enum Salut
        {
            test,
            test2
        }

        private Salut _salut = Salut.test;
    }
}
