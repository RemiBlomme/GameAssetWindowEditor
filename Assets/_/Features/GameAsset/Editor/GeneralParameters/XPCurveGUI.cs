using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class XPCurveGUI : EditorWindow
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

        public void Initialize(ClassData classData)
        {
            m_parameterCurve = classData.m_parameterCurve;
        }

        public static void ShowWindow()
        {
            GetWindow<XPCurveGUI>();
        }

        public void GetGUI()
        {
            GUILayout.BeginHorizontal();
            //NameField();

            GUILayout.EndHorizontal();
        }

        #endregion

        #region Utils

        #endregion

        #region Private and Protected Members

        private ParameterCurve m_parameterCurve;

        #endregion
    }
}