using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class GeneralParametersActorGUI : EditorWindow
    {
        #region Public Members

        #endregion

        #region Unity API

        private void OnGUI()
        {
            string[] guids = AssetDatabase.FindAssets("t:MyScriptableObject");

            GUILayout.Label("General Parameters");

            // Line 1
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("Name:");
            _nameTextField = GUILayout.TextField(_nameTextField);
            GUILayout.EndVertical();

            GUILayout.Space(5);

            GUILayout.BeginVertical();
            GUILayout.Label("Nickname:");
            _nickNameTextField = GUILayout.TextField(_nickNameTextField);
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();

            // Line 2
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("Class:");
            _nameTextField = GUILayout.TextField(_nameTextField);
            GUILayout.EndVertical();

            GUILayout.Space(5);

            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("Initial Level:");
            _nickNameTextField = GUILayout.TextField(_nickNameTextField);
            GUILayout.EndVertical();
            GUILayout.BeginVertical();
            GUILayout.Label("Max Level:");
            _nickNameTextField = GUILayout.TextField(_nickNameTextField);
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
            GUILayout.EndHorizontal();
        }

        #endregion

        #region Main Methods

        [MenuItem("Testing/test")]
        public static void ShowWindow()
        {
            var window = GetWindow<GeneralParametersActorGUI>();
            window.titleContent = new GUIContent("Tool");
        }

        #endregion

        #region Utils

        #endregion

        #region Private and Protected Members

        private string _nameTextField;
        private string _nickNameTextField;

        #endregion
    }
}