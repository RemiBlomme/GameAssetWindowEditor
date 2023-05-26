using GameAsset.Runtime;
using System.Numerics;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class GeneralParametersClassGUI : EditorWindow
    {
        #region Public Members

        #endregion

        #region Unity API

        private void OnGUI()
        {
            GetGUI();
        }

        #endregion

        #region Main Methods

        [MenuItem("Testing/class")]
        public static void ShowWindow()
        {
            GetWindow<GeneralParametersClassGUI>();
        }

        public void GetGUI()
        {
            GUIStyle boldFontStyle = new()
            {
                fontStyle = FontStyle.Bold,
            };
            boldFontStyle.normal.textColor = Color.white;
            GUILayout.Label("General Parameters", boldFontStyle);

            _class = (ClassData)EditorGUILayout.ObjectField(_class, typeof(ClassData), false);
            if (_class is null) return;

            GUILayout.BeginHorizontal();
            NameField();

            GUILayout.EndHorizontal();
        }

        private void NameField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Name:");
            _nameTextField = _class.m_generalParametersClass._name;
            _nameTextField = EditorGUILayout.TextField(_nameTextField);
            if (_class.m_generalParametersClass._name != _nameTextField)
            {
                _class.m_generalParametersClass._name = _nameTextField;
            }
            if (GUILayout.Button("")) // TODO
            {

            }
            GUILayout.EndVertical();
        }

        #endregion

        #region Utils

        #endregion

        #region Private and Protected Members

        private string _nameTextField;

        private ClassData _class;

        #endregion
    }
}