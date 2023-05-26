using GameAsset.Runtime;
using UnityEditor;

namespace GameAsset.Editor
{
    public class ParameterChangeGUI : EditorWindow
    {
        #region Main Methods

        public void GetGUI(ParameterChange data)
        {
            SetArmorDataInstance(data);

            if (m_parameterChange == null) return;

            Display();
        }

        public void SetArmorDataInstance(ParameterChange data)
        {
            m_parameterChange = data;
        }

        private void Display()
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

        #region Private and Protected Members

        private ParameterChange m_parameterChange;

        #endregion
    }
}