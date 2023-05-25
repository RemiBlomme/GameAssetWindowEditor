using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsRecovery : EffectComponents
    {
        [Range(0, 100)]
        public float m_hpRecoveryPercentage = 100f;
        public int m_hpRecoveryAmount = 0;

        [Range(0, 100)]
        public float m_mpRecoveryPercentage = 100f;
        public int m_mpRecoveryAmount = 0;

        [Range(0,100)]
        public float m_tpGainAmount = 0;
    }
}