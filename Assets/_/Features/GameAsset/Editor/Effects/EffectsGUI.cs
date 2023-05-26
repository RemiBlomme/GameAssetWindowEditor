using Codice.Client.Common.GameUI;
using GameAsset.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class EffectsGUI : EditorWindow
    {
        public enum EffecsComponentsEnum
        {
            Recovery,
            State,
            Parameters,
            Other
        }

        #region Public Members

        #endregion


        #region Unity API

        private void OnGUI()
        {
            Display();
        }

        #endregion


        #region Main Methods

        public void GetGUI(Effects effects)
        {
            _effects = effects;

            if (_effects == null) return;

            Display();
        }

        [MenuItem("Tools/Effects")]
        public static void ShowWindow()
        {
            var window = GetWindow<EffectsGUI>();
            window.titleContent = new GUIContent("Effects");
        }

        [OnOpenAsset]
        public static bool OpenAsset(int instanceId, int line)
        {
            if (Selection.activeObject is ObjectData)
            {
                ShowWindow();
                return true;
            }

            return false;
        }

        public void Display()
        {
            DisplayButtons();
        }

        private void DisplayButtons()
        {
            GUILayout.BeginHorizontal();
            foreach(string s in Enum.GetNames(typeof(EffecsComponentsEnum)))
            {
                if (GUILayout.Button(s))
                {
                    _effecsComponentsEnum = (EffecsComponentsEnum)Enum.Parse(typeof(EffecsComponentsEnum),s);
                }
            }
            GUILayout.EndHorizontal();

            switch (_effecsComponentsEnum)
            {
                case EffecsComponentsEnum.Recovery:
                    DisplayRecovery();
                    break;
                case EffecsComponentsEnum.State:
                    break;
                case EffecsComponentsEnum.Parameters:
                    break;
                case EffecsComponentsEnum.Other:
                    break;
            }
        }

        private void DisplayRecovery()
        {
            GUILayout.Label("Recovery");
        }

        #endregion


        #region Private and Protected Members

        private Effects _effects;
        private EffecsComponentsEnum _effecsComponentsEnum;

        #endregion
    }
}
