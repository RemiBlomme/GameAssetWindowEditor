using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class Curve
    {
    	#region Public Member

        #endregion


        #region Unity API

        void Awake()
    	{
		
    	}
	
        void Start()
        {

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
