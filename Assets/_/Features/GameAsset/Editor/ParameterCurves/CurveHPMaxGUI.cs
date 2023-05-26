using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

namespace GameAsset.Editor
{
    public class CurveHPMaxGUI : EditorWindow
    {

        #region Public Members



        #endregion

        private void OnGUI()
        {
            
        }

        #region Unity API
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion
        #region Main Methods

        public void GenerateCurve(int min, int max, AnimationCurve typeCurve)
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

        #region Utils
        #endregion

        #region Private and Protected Members
        #endregion


    }
}
