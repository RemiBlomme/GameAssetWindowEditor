using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Traits
    {
        #region Public Members

        public Rates m_rates;
        public Params m_params;
        public Attack m_attack;
        public Comp m_comp;
        public Equip m_equip;
        public Other m_other;

        #endregion

    }
}