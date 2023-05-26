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





        #endregion

        private void OnGUI()
        {
            ClassData instance = new ClassData();
            //Hero Instance = ScriptableObject.CreateInstance<Hero>();
            instance.m_parameterCurve.m_hPMax.m_minLvlValue = 450;
            instance.m_parameterCurve.m_hPMax.m_maxLvlValue = 3000;
            //m_curveHPMax = m_classData.m_parameterCurve.m_hPMax;

            GUILayout.BeginHorizontal();
            //m_level = EditorGUILayout.IntField("Level : ", m_level);
            //m_levelValue = EditorGUILayout.IntField("Value : ", m_levelValue);
            GUILayout.Button($"Generate Curve");
            GUILayout.EndHorizontal();

            //CurveHPMax instance = new CurveHPMax();
            //instance.m_minLvlValue = 450;
            //instance.m_maxLvlValue = 3000;
            //GenerateCurve(m_curveHPMax.m_minLvlValue, m_curveHPMax.m_maxLvlValue, m_HPCurve);
            GenerateCurve(instance.m_parameterCurve.m_hPMax.m_minLvlValue, instance.m_parameterCurve.m_hPMax.m_maxLvlValue, m_HPCurve);
            m_HPCurve = EditorGUILayout.CurveField(m_HPCurve);

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
