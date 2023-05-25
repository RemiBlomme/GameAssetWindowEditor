using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Attack : TraitsParent
    {
        #region Public Members

        //Attack Element
        public ElementTypeData m_elementTypesAttack;

        //Attack State
        public States m_stateAttack;
        [Range(0, 1000)] public float m_percentageAttack = 100f;

        //Attack Speed
        [Range(-1000, 1000)] public float m_attackSpeed;

        //Attack Times
        [Range(-9,9)]public float m_attackTimes;

        #endregion

    }
}