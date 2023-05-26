using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using GameAsset.Runtime;

namespace GameAsset.Editor

{
    public class CurveHPMaxGUI : EditorWindow
    {

        #region Public Members
        
        public AnimationCurve m_HPCurve = new AnimationCurve();
        public CurveHPMax m_curveHPMax;





        #endregion

        private void OnGUI()
        {
            //GenerateCurve(m_curveHPMax.m_minLvlValue, m_curveHPMax.m_maxLvlValue, m_HPCurve);
            GenerateCurve(450, 3500, m_HPCurve);
            m_HPCurve = EditorGUILayout.CurveField("HP Curve", m_HPCurve);

        }

        #region Unity API
     
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
