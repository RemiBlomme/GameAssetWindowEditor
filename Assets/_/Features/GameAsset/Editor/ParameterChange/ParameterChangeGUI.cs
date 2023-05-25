using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    [CreateAssetMenu(fileName = "ParameterChangerGUI", menuName = "Test")]
    public class ParameterChangeGUI : EditorWindow
    {
        #region Public Members

        public int m_damage, m_defense, m_magicDamage, m_magicDefense, m_agility, m_luck, m_maxHP, m_maxMP;

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
            m_damage = EditorGUILayout.IntField("Damage", m_damage);
            m_defense = EditorGUILayout.IntField("Defense", m_defense);
            m_magicDamage = EditorGUILayout.IntField("Magic Damage", m_magicDamage);
            m_magicDefense = EditorGUILayout.IntField("Magic Defense", m_magicDefense);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            m_agility = EditorGUILayout.IntField("Agility", m_agility);
            m_luck = EditorGUILayout.IntField("Lucl", m_luck);
            m_maxHP = EditorGUILayout.IntField("Max HP", m_maxHP);
            m_maxMP = EditorGUILayout.IntField("Max MP", m_maxMP);
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