using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersArmor : GeneralParameters
    {
        #region Public Members

        public Sprite m_icon;
        public string m_description;
        public ArmorTypeData m_armorType; 
        public EquipmentTypeData m_equipmentType; 
        public int m_price;

        #endregion
    }
}