using System;

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
        public float m_percentageAttack = 100f;

        //Attack Speed
        public float m_attackSpeed;

        //Attack Times
        public float m_attackTimes;

        #endregion

    }
}
