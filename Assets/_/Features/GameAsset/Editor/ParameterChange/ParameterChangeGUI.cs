using GameAsset.Runtime;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    [CreateAssetMenu(fileName = "ParameterChangerGUI", menuName = "Test")]
    public class ParameterChangeGUI : EditorWindow
    {
        #region Public Members

        public ParameterChange m_parameterChange;

        #endregion

        #region Unity API

        [MenuItem("test/ParameterChangeGUI")]
        public static void ShowWindow()
        {
            GetWindow<ParameterChangeGUI>();
            Debug.Log("open window");
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginHorizontal();
            m_parameterChange.m_damage = EditorGUILayout.IntField("Damage", m_parameterChange.m_damage);
            m_parameterChange.m_defense = EditorGUILayout.IntField("Defense", m_parameterChange.m_defense);
            m_parameterChange.m_magicDamage = EditorGUILayout.IntField("Magic Damage", m_parameterChange.m_magicDamage);
            m_parameterChange.m_magicDefense = EditorGUILayout.IntField("Magic Defense", m_parameterChange.m_magicDefense);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            m_parameterChange.m_agility = EditorGUILayout.IntField("Agility", m_parameterChange.m_agility);
            m_parameterChange.m_luck = EditorGUILayout.IntField("Lucl", m_parameterChange.m_luck);
            m_parameterChange.m_maxHP = EditorGUILayout.IntField("Max HP", m_parameterChange.m_maxHP);
            m_parameterChange.m_maxMP = EditorGUILayout.IntField("Max MP", m_parameterChange.m_maxMP);
            EditorGUILayout.EndHorizontal();
        }

        #endregion

        #region Main Methods

        #endregion

        #region Utils

        #endregion

        #region Private and Protected Members

        #endregion
    }
}