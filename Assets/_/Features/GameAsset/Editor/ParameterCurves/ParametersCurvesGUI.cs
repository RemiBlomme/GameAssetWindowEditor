using GameAsset.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using System.Diagnostics;
using UnityEditorInternal;

namespace GameAsset.Editor
{
    public class ParametersCurvesGUI : EditorWindow
    {

        #region Public Members

        public ParametersEnum m_parametersEnum;

        #endregion


        #region Main Methods

        [MenuItem("Window/Parameters Curves")]

        public static void ShowWidow()
        {
            var window = GetWindow<ParametersCurvesGUI>();
            window.titleContent.text = "Parameters Curves";
        }

        //private void HPMax()
        //{
        //    var windowHPMax = GetWindow<CurveHPMaxGUI>();
        //    windowHPMax.titleContent.text = "HP Max";
        //}

        private void OnGUI()
        {
            string[] parameterNames = Enum.GetNames(typeof(ParametersEnum));
            for(int i = 0; i< parameterNames.Length; i++)
            {
                if (GUILayout.Button(parameterNames[i]))
                {
                    Enum.TryParse<ParametersEnum>(parameterNames[i], out ParametersEnum result);
                    m_parametersEnum = result;
                }
            }
            switch (m_parametersEnum)
            {
                case ParametersEnum.HPMax:
                    //HPMax();
                    break;

                case ParametersEnum.MPMax:

                    break;

                case ParametersEnum.Attack:

                    break;
                case ParametersEnum.Defense:

                    break;

                case ParametersEnum.MagicAttack:

                    break;

                case ParametersEnum.MagicDefense:

                    break;
                case ParametersEnum.Agility:

                    break;

                case ParametersEnum.Luck:

                    break;
            }

        }


        #endregion


        #region Utils

        #endregion


        #region Private and Protected Members
        #endregion


    }
}
