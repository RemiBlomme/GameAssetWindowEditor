using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Equip : TraitsParent
    {
        public enum SlotTypes
        {
            Normal,
            DualWield
        }

        #region Public Members

        //Equip Weapon
        public WeaponTypeData m_weaponTypes;

        //Equip Armor
        public ArmorTypeData m_armorTypes;

        //Lock Equipment
        public EquipmentTypeData m_equipmentTypes;

        //Seal Equipment
        public EquipmentTypeData m_equipmentTypesSeal;

        //Type Slot
        public SlotTypes m_slotType;

        #endregion
    }
}