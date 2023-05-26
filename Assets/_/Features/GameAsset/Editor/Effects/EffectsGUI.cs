using Codice.Client.Common.GameUI;
using GameAsset.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class EffectsGUI : EditorWindow
    {
        #region Public Members
    
        #endregion
    
    
        #region Unity API
    
        void Start()
        {
        
        }
    
        void Update()
        {
        
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

        private void Display()
        {


        }

        #endregion


        #region Private and Protected Members

        private Effects _effects;

        #endregion
    }
}
