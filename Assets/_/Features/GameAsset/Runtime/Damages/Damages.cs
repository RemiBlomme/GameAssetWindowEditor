using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Damages
    {
        public enum DamageType
        {
            None,
            HPDamage,
            MPDamage,
            HPRecovery,
            MPRecovery,
            HPDrain,
            MPDrain,
        }

        #region Public Members

        public DamageType m_damageType;
        public ElementTypeData m_elementType;
        public string m_formula;
        [Range(0,100)]
        public float m_variance;
        public bool m_criticalHit;

        #endregion
    }
}