using UnityEngine;

namespace GameAsset.Runtime
{
    public class StatesActions
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
