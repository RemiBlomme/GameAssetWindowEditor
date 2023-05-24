using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Traits : MonoBehaviour
    {
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

        //public States m_state;
        public ExParameters m_exParameter;
        public SpParameters m_spParameter;
        public SlotTypes m_slotType;
        public SpecialFlags m_specialFlag;
        public CollapseEffects m_collapseEffect;
        public PartyAbilities m_partyAbility;
        //public ParametersEnum m_debuffRate;

        public ArmorTypeData[] _armorTypes;
        public ElementTypeData[] _elementTypes;
        public EquipmentTypeData[] _equipmentTypes;
        public SkillTypeData[] _skillTypes;
        public WeaponTypeData[] _weaponTypes;
        // list of competences
        public List<string> m_traits;
        //add(Button.name + State.name + " * " + nbr + "%") rajouter dans la liste
    }
}
