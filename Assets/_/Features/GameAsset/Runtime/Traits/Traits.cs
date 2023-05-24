using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Traits : MonoBehaviour
    {
        public ArmorTypeData[] _armorTypes;
        public ElementTypeData[] _elementTypes;
        public EquipmentTypeData[] _equipmentTypes;
        public SkillTypeData[] _skillTypes;
        public WeaponTypeData[] _weaponTypes;

        public enum States
        {
            Assomé,
            Garde,
            Immortel,
            Empoisonné,
            Aveuglé,
            Muet,
            Enragé,
            Confus,
            Fasciné,
            Endormi
        }

        public enum ExParameters
        {
            HitRate,
            EvasionRate,
            CriticalRate,
            CriticalEvasion,
            MagicEvasion,
            MagicReflection,
            CounterAttack,
            HPRegen,
            MPRegen,
            TPRegen
        }

        public enum SpParameters
        {
            TargetRate,
            GuardEffect,
            RecoveryEffect,
            Pharmacology,
            MPCostRate,
            TPChargeRate,
            PhysicalDMG,
            MagicDMG,
            FloorDMG,
            XP
        }

        public enum SlotTypes
        {
            Normal,
            DualWield
        }

        public enum SpecialFlags
        {
            AutoBattle,
            Guard,
            Substitute,
            PreserveTP
        }

        public enum CollapseEffects
        {
            Normal,
            Boss,
            Instant,
            NoDisappear
        }

        public enum PartyAbilities
        {
            EncounterHalf,
            EncounterNone,
            CancelSurprise,
            RaisePreemptive,
            GoldDouble,
            DropItemDouble
        }

        public float m_percentage;
        public float m_attackSpeed;
        public float m_attackTimes;
        public float m_actionTimes;

        public States m_state;
       
    }
}
