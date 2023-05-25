using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsStates : EffectComponents
    {
        #region Public Members

        public States m_addState;
        [Range(0, 1000)]
        public float m_addProbability;

        public States m_removeState;
        [Range(0, 100)]
        public float m_removeProbability;

        #endregion
    }
}