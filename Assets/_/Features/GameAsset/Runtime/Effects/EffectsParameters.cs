using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsParameters : EffectComponents
    {
        public enum EffectsParametersActions
        {
            AddBuff,
            AddDenuff,
            RemoveBuff,
            RemoveDebuff,
        }

        public EffectsParametersActions m_action;
        public ParametersEnum m_parameter;
        public int m_numberOfRounds;
    }
}