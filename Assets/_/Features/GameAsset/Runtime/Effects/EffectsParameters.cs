using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsParameters : EffectComponents
    {
        public ParametersEnum m_addBuffParameter;
        [Range(1,1000)]
        public int m_addBuffNumberOfRounds;

        public ParametersEnum m_addDebuffParameter;
        [Range(1, 1000)]
        public int m_addDebuffNumberOfRounds;

        public ParametersEnum m_removeBuffParameter;

        public ParametersEnum m_removeDebuffParameter;
    }
}