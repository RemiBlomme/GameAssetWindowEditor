using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsOther : EffectComponents
    {
        [Serializable]
        public enum SpecialEffect
        {
            Fuire,
            Bonjour
        }

        public enum CommonEvent
        {
            One,
            Two
        }

        #region Public Members

        public SpecialEffect m_specialEffect;

        public ParametersEnum m_parametersEnum;
        public int m_growAmount;

        public SkillData m_skill;

        public CommonEvent m_commonEvent;

        #endregion
    }
}