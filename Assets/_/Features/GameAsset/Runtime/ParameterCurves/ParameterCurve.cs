using System.Collections;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class ParameterCurve
    {
        public AnimationCurve m_curve;
        public int m_maxLevel;
        public int m_minLevelValue;
        public int m_maxLevelValue;

        public ParameterCurve(AnimationCurve curve, int maxLevel, int minLevelValue, int maxLevelValue)
        {
            m_curve = curve;
            m_maxLevel = maxLevel;
            m_minLevelValue = minLevelValue;
            m_maxLevelValue = maxLevelValue;
        }
    }
}