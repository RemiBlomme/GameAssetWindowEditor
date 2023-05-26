using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class DamagesGUI
    {
        #region Main Methods

        public void GetGUI(Damages damages)
        {
            _damages = damages;

            if (_damages == null) return;

            Display();
        }

        private void Display()
        {
            // TITLE

            GUIStyle insertVarNameHere = new GUIStyle();
            insertVarNameHere.fontStyle = FontStyle.Bold;
            insertVarNameHere.normal.textColor = Color.white;
            GUILayout.Label("Damages", insertVarNameHere);


            //  TYPE

            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("Type:");
            _damages.m_damageType = (Damages.DamageType)EditorGUILayout.EnumPopup(_damages.m_damageType);
            GUILayout.EndVertical();


            //  ELEMENT

            GUILayout.BeginVertical();
            GUILayout.Label("Element:");
            _damages.m_elementType = (ElementTypeData)EditorGUILayout.ObjectField(_damages.m_elementType, typeof(ElementTypeData), true);
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();


            //  FORMULA

            GUILayout.Label("Formula:");
            _damages.m_formula = EditorGUILayout.TextField(_damages.m_formula);


            //  VARIANCE

            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.Label("Variance:");
            _damages.m_variance = Mathf.Clamp(EditorGUILayout.FloatField(_damages.m_variance), 0, 100);
            GUILayout.EndVertical();


            //  CRITICAL STRIKES

            GUILayout.BeginVertical();
            GUILayout.Label("Critical strikes:");
            _damages.m_criticalHit = EditorGUILayout.Toggle(_damages.m_criticalHit);
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        #endregion


        #region Private and Protected Members

        private Damages _damages;

        #endregion
    }
}