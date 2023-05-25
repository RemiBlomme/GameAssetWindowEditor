using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Effects
    {
        #region Public Members

        public EffectsRecovery m_recovery;
        public EffectsStates m_states;
        public EffectsParameters m_effectsParameters;
        public EffectsOther m_other;

        #endregion
    }
}