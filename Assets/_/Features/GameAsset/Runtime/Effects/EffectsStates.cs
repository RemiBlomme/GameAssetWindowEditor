using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class EffectsStates : EffectComponents
    {
        public enum StateAction
        {
            AddState,
            RemoveState,
        }

        #region Public Members

        public StateAction m_stateAction;
        public States m_state;
        [Range(0, 100)]
        public float m_probability;

        #endregion
    }
}