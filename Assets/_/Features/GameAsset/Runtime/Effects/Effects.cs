using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Effects
    {
        #region Public Members

        public Recovery m_recovery;
        public EffectsStates m_states;
        public EffectsParameters m_effectsParameters;
        public OtherEffects m_other;

        #endregion
    }
}