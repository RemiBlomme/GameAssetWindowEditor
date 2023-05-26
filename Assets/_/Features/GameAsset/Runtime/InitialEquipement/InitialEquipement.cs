using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class InitialEquipement
    {
        #region Public Members

        public WeaponData m_weapon;
        public ArmorData m_shield;
        public ArmorData m_head;
        public ArmorData m_body;
        public ArmorData m_accessory;

        #endregion
    }
}