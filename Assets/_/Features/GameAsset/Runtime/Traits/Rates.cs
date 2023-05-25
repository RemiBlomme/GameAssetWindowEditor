using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Rates : TraitsParent
    {
        #region Public Members

        //Element
        public ElementTypeData m_elementTypes;
        public float m_percentageElements = 100f;

        //Debuff
        public ParametersEnum m_debuffRate;
        public float m_percentageDebuffRate = 100f;

        //State
        public States m_state;
        public float m_percentageState = 100f;

        //Resistance
        public States m_resistState;

        #endregion
    }
}
