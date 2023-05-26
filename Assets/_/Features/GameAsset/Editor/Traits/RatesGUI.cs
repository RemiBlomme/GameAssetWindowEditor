using GameAsset.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class RatesGUI : UnityEditor.EditorWindow
    {
        #region Public Members

        //public Rates _rates;
        public ElementTypeData m_elementsource;

        #endregion


        #region Unity API
        #endregion


        #region Main Methods

        public void ShowRates()
        {
            //Debug.Log("ui");
            //EditorGUILayout.TextField("yes");

            EditorGUILayout.BeginHorizontal();
            _elementRatesEnabled = EditorGUILayout.BeginToggleGroup("Element Rates", _elementRatesEnabled);
            EditorGUILayout.BeginVertical();
            EditorGUILayout.ObjectField(m_elementsource, typeof(ElementTypeData), false);
            //EditorGUILayout.FloatField(_rates.m_percentageElements);
            EditorGUILayout.EndVertical();
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.BeginHorizontal();
            _debuffRatesEnabled = EditorGUILayout.BeginToggleGroup("Debuff Rates", _debuffRatesEnabled);
            EditorGUILayout.BeginVertical();
            EditorGUILayout.EnumPopup(_parameters);
            //EditorGUILayout.FloatField(_rates.m_percentageDebuffRate);
            EditorGUILayout.EndVertical();
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.BeginHorizontal();
            _stateRatesEnabled = EditorGUILayout.BeginToggleGroup("State Rates", _stateRatesEnabled);
            EditorGUILayout.BeginVertical();
            EditorGUILayout.EnumPopup(_states);
            //EditorGUILayout.FloatField(_rates.m_percentageState);
            EditorGUILayout.EndVertical();
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.BeginHorizontal();
            _stateResistEnabled = EditorGUILayout.BeginToggleGroup("State Resistances", _stateResistEnabled);
            EditorGUILayout.EnumPopup(_states);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndToggleGroup();
        }

        #endregion


        #region Private Members

        bool _elementRatesEnabled;
        bool _debuffRatesEnabled;
        bool _stateRatesEnabled;
        bool _stateResistEnabled;

        private ParametersEnum _parameters;
        private States _states;

        private Rates _rates;

        #endregion
    }
}
