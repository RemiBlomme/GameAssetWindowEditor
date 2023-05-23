using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu]
    public class ArmorData : ScriptableObject   
    {
        public enum ArmorTypes
        {
            None,
            General,
            Magic,
            Light,
            Heavy,
            SmallShield,
            BigShield
        }

        public enum EquipmentTypes
        {
            Shield,
            Head,
            Chest,
            Legs
        }

        public string m_name;
        public Sprite m_icon;
        public string m_description;

        public ArmorTypes m_armorType;
        public EquipmentTypes m_equipmentType;
        public int m_price;

        public int m_attack;
        public int m_agility;
        public int m_defense;
        public int m_luck;
        public int m_attackM;
        public int m_HPMax;
        public int m_DefenseM;
        public int m_MPMax;

        private void OnEnable()
        {

        }
    }
}
