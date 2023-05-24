using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class OtherEffects : EffectComponents
    {
        [Serializable]
        public enum OtherEffectType
        {
            SpecialEffect,
            Grow,
            LearnAbility,
            CommonEvent
        }

        public enum SpecialEffect
        {
            Salut,
            Bonjour
        }

        public enum CommonEvent
        {
            Hi,
            Hello
        }

        #region Public Members

        public OtherEffectType m_otherEffectType;
        public SpecialEffect m_specialEffect;
        public ParametersEnum m_parametersEnum;
        public int m_growAmount;
        public SkillData m_skill;
        public CommonEvent m_commonEvent;

        #endregion
    }
}