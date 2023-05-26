using GameAsset.Runtime;
using UnityEditor;

namespace GameAsset.Editor
{
    public class InitialEquipementGUI
    {
        #region Public Members

        public InitialEquipement m_initialEquipement;

        #endregion

        #region Main Methods

        public void GetGUI(InitialEquipement data)
        {
            SetInitialEquipementInstance(data);

            if (m_initialEquipement == null) return;

            Display();
        }

        public void SetInitialEquipementInstance(InitialEquipement data)
        {
            m_initialEquipement = data;
        }

        private void Display()
        {
            m_initialEquipement.m_weapon = EditorGUILayout.ObjectField("Weapon", m_initialEquipement.m_weapon, typeof(WeaponData), true) as WeaponData;
            m_initialEquipement.m_shield = EditorGUILayout.ObjectField("Shield", m_initialEquipement.m_shield, typeof(ArmorData), true) as ArmorData;
            m_initialEquipement.m_head = EditorGUILayout.ObjectField("Head", m_initialEquipement.m_head, typeof(ArmorData), true) as ArmorData;
            m_initialEquipement.m_body = EditorGUILayout.ObjectField("Body", m_initialEquipement.m_body, typeof(ArmorData), true) as ArmorData;
            m_initialEquipement.m_accessory = EditorGUILayout.ObjectField("Accessory", m_initialEquipement.m_accessory, typeof(ArmorData), true) as ArmorData;
        }

        #endregion
    }
}