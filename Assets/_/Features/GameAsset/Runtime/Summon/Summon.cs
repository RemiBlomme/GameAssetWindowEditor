using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Summon
    {
        #region Public Members

        public enum HitType
        {
            physicalAttack,
            magicalAttack,
            certainHit
        }
        public enum Animations
        {
            
            Heal,
            Attack
            
        }
        public float m_speed;
        [Range(0,100)] public float m_success;
        public int m_repeat;
        public int m_tpGain;
        public HitType m_hitType;
        public Animations m_animation;

        #endregion
    }
}