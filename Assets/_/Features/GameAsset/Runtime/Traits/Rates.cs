using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Rates : TraitsParent
    {
        #region Public Members

        //Element
        public ElementTypeData m_elementTypes;
        [Range(0, 1000)] public float m_percentageElements = 100f;

        //Debuff
        public ParametersEnum m_debuffRate;
        [Range(0, 1000)] public float m_percentageDebuffRate = 100f;

        //State
        public States m_state;
        [Range(0,1000)] public float m_percentageState = 100f;

        //Resistance
        public States m_resistState;

        #endregion
    }
}