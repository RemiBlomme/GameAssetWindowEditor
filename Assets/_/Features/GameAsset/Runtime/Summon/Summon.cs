using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [SerializeField]
    public class Summon
    {
        #region Public Members

        public enum HitType
        {
            physicalAttack,
            magicalAttack,
            certainHit
        }
        public int m_speed;
        public int m_success;
        public int m_repeat;
        public int m_tpGain;
        public HitType m_hitType;
        public Animation m_animation;

        #endregion


        #region Unity API



        #endregion


        #region Main Methods



        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members



        #endregion
    }
}