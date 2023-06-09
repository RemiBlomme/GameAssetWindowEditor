using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Params : TraitsParent
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

        #region Public Members

        //Parameter
        public ParametersEnum m_parametre;
        [Range(0, 1000)] public float m_percentageParametre = 100f;

        //Ex-Parameter
        public ExParameters m_exParameter;
        [Range(-1000, 1000)] public float m_percentageExParam;

        //Sp-Parameter
        public SpParameters m_spParameter;
        [Range(0, 1000)] public float m_percentageSpParam = 100f;

        #endregion

    }
}