using UnityEngine;

namespace GameAsset.Runtime
{
    public class Curves 
    {
        #region Public Members
        
        public int m_minLvl = 1;
        public int m_maxLvl = 99;

        public int m_minLvlValue;
        public int m_maxLvlValue;

        [Tooltip("0 = EaseIn, 11 = Linear, 22 = EaseOut")][Range(0,22)] public int m_growthType;

        #endregion
    }
}