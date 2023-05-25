using System;

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
        public float m_percentageParametre;

        //Ex-Parameter
        public ExParameters m_exParameter;
        public float m_percentageExParam;

        //Sp-Parameter
        public SpParameters m_spParameter;
        public float m_percentageSpParam;

        #endregion

    }
}
