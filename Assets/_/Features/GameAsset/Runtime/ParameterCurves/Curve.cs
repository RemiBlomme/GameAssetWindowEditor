using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class Curve
    {

        public ParameterCurveTypes m_parameterCurveType;

    	#region Public Member

        #endregion


        #region Unity API

        void Awake()
    	{
		
    	}
	
        void Start()
        {
            GenerateCurve(m_parameterCurveType.m_hp.m_curve, m_parameterCurveType.m_hp.m_minLevelValue, m_parameterCurveType.m_hp.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_mp.m_curve, m_parameterCurveType.m_mp.m_minLevelValue, m_parameterCurveType.m_mp.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_attack.m_curve, m_parameterCurveType.m_attack.m_minLevelValue, m_parameterCurveType.m_attack.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_defense.m_curve, m_parameterCurveType.m_defense.m_minLevelValue, m_parameterCurveType.m_defense.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_attackM.m_curve, m_parameterCurveType.m_attackM.m_minLevelValue, m_parameterCurveType.m_attackM.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_defenseM.m_curve, m_parameterCurveType.m_defenseM.m_minLevelValue, m_parameterCurveType.m_defenseM.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_agility.m_curve, m_parameterCurveType.m_agility.m_minLevelValue, m_parameterCurveType.m_agility.m_maxLevelValue);
            GenerateCurve(m_parameterCurveType.m_luck.m_curve, m_parameterCurveType.m_luck.m_minLevelValue, m_parameterCurveType.m_luck.m_maxLevelValue);
        }

        void Update()
        {
        
        }
	
    	void FixedUpdate()
    	{
		
    	}

        #endregion

        #region Main Methods

        public void GenerateCurve(AnimationCurve typeCurve, int min, int max)
        {
            float hpPerLevel = (max - min) / 99f;
            int hpPerLevelInt = (int)Math.Ceiling((double)hpPerLevel);
            for (int i = 0; i < 99; i++)
            {
                int addHp = hpPerLevelInt * i;
                typeCurve.AddKey(new Keyframe(i + 1, min + addHp));
            }
        }

        #endregion

        #region Private And Protect

        #endregion
    }
}
