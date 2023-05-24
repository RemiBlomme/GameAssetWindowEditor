using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Recovery
    {
        public enum RecoveryType
        {
            HPRecovery,
            MPRecovery,
            TPGain
        }

        public RecoveryType m_recoveryType;
        [Range(0, 100)]
        public float m_recoveryPercentage;
        public int m_recoveryAmount;
    }
}
