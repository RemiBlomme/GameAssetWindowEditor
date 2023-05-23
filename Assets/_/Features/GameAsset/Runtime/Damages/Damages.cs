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
        public int m_variance;
        public bool m_criticalHit;

        #endregion


        #region Unity Api



        #endregion


        #region Main Methods



        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members



        #endregion
    }
}
