using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using GameAsset.Runtime;
using JetBrains.Annotations;

namespace GameAsset.Editor

{
    public class CurveHPMaxGUI : EditorWindow
    {

        #region Public Members
        
        public AnimationCurve m_HPCurve = new AnimationCurve();
        public ClassData m_classData;

        public ParametersCurvesGUI m_parametersCurvesGUI;

        



        #endregion

        private void OnGUI()
        {


            ClassData instance = m_parametersCurvesGUI.m_classData;

            GUILayout.BeginHorizontal();
          
            GUILayout.Button($"Generate Curve");
            GUILayout.EndHorizontal();

            GenerateCurve(_curveHPMaxData.m_minLvlValue, _curveHPMaxData.m_maxLvlValue, m_HPCurve);
            m_HPCurve = EditorGUILayout.CurveField(m_HPCurve);

        }

        #region Unity API
     
        #endregion
        #region Main Methods

        public void Initialize(CurveHPMax HpMaxData)
        {
            _curveHPMaxData = HpMaxData;
        }
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

        CurveHPMax _curveHPMaxData;

        #endregion


    }
}
