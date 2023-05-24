using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class Curve : MonoBehaviour
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

        public void GenerateCurve(int min, int max, AnimationCurve typeCurve)
        {
            float hpPerLevel = (max - min) / 99;
            int hpPerLevelInt = (int)Math.Round(hpPerLevel);
            for (int i = 0; i <= 99; i++)
            {
                float addHp = hpPerLevelInt * i;
                typeCurve.AddKey(new Keyframe(i, min + addHp));
            }
        }

        #endregion

        #region Private And Protect

        #endregion
    }
}
