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

        public ParametersEnum? m_parametersEnum = null;

        #endregion


        #region Main Methods

        [MenuItem("Window/Parameters Curves")]

        public static void ShowWidow()
        {
            var window = GetWindow<ParametersCurvesGUI>();
            window.titleContent.text = "Parameters Curves";
        }

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
            if (m_parametersEnum != null)
            {
                switch (m_parametersEnum)
                {
                    case ParametersEnum.HPMax:
                        var windowHPMax = GetWindow<CurveHPMaxGUI>();
                        windowHPMax.titleContent.text = "HP Max";
                        break;

                    case ParametersEnum.MPMax:
                        var windowMPMax = GetWindow<CurveMPMaxGUI>();
                        windowMPMax.titleContent.text = "MP Max";
                        break;

                    case ParametersEnum.Attack:
                        var windowAttack = GetWindow<CurveAttackGUI>();
                        windowAttack.titleContent.text = "Attack";
                        break;
                    case ParametersEnum.Defense:
                        var windowDefense = GetWindow<CurveDefenseGUI>();
                        windowDefense.titleContent.text = "Defense";
                        break;

                    case ParametersEnum.MagicAttack:
                        var windowMagicAttack = GetWindow<CurveMagicAttackGUI>();
                        windowMagicAttack.titleContent.text = "Magic Attack";
                        break;

                    case ParametersEnum.MagicDefense:
                        var windowMagicDefense = GetWindow<CurveMagicDefenseGUI>();
                        windowMagicDefense.titleContent.text = "Magic Defense";
                        break;
                    case ParametersEnum.Agility:
                        var windowAgility = GetWindow<CurveAgilityGUI>();
                        windowAgility.titleContent.text = "Agility";
                        break;

                    case ParametersEnum.Luck:
                        var windowLuck = GetWindow<CurveLuckGUI>();
                        windowLuck.titleContent.text = "Luck";
                        break;
                }
                m_parametersEnum = null;
            }

        }


        #endregion


        #region Utils

        #endregion


        #region Private and Protected Members
        #endregion


    }
}
