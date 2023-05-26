using GameAsset.Runtime;
using System;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class EffectsGUI : EditorWindow
    {
        public enum EffecsComponentsEnum
        {
            Recovery,
            State,
            Parameters,
            Other
        }

        #region Public Members

        #endregion


        #region Unity API

        private void OnGUI()
        {
            Display();
        }

        #endregion


        #region Main Methods

        public void GetGUI(Effects effects)
        {
            _effects = effects;

            if (_effects == null) return;

            Display();
        }

        [MenuItem("Tools/Effects")]
        public static void ShowWindow()
        {
            var window = GetWindow<EffectsGUI>();
            window.titleContent = new GUIContent("Effects");
        }

        [OnOpenAsset]
        public static bool OpenAsset(int instanceId, int line)
        {
            if (Selection.activeObject is ObjectData)
            {
                ShowWindow();
                return true;
            }

            return false;
        }

        public void Display()
        {
            _object = (ObjectData)EditorGUILayout.ObjectField(_object, typeof(ObjectData), true);
            if (_object == null)
            {
                return;
            }
            _effects = _object.m_effects[0];
            DisplayButtons();
        }

        private void DisplayButtons()
        {
            GUILayout.BeginHorizontal();
            foreach(string s in Enum.GetNames(typeof(EffecsComponentsEnum)))
            {
                if (GUILayout.Button(s))
                {
                    _effecsComponentsEnum = (EffecsComponentsEnum)Enum.Parse(typeof(EffecsComponentsEnum),s);
                }
            }
            GUILayout.EndHorizontal();

            switch (_effecsComponentsEnum)
            {
                case EffecsComponentsEnum.Recovery:
                    DisplayRecovery();
                    break;
                case EffecsComponentsEnum.State:
                    break;
                case EffecsComponentsEnum.Parameters:
                    break;
                case EffecsComponentsEnum.Other:
                    break;
            }

            DisplayCloseButton();
        }

        private void DisplayRecovery()
        {
            EditorGUILayout.BeginHorizontal();
            _hpRecoveryButton = EditorGUILayout.ToggleLeft("HP Recovery", _hpRecoveryButton);
            if (_hpRecoveryButton)
            {
                EditorGUILayout.BeginVertical();
                _effects.m_recovery.m_hpRecoveryPercentage = Mathf.Clamp(EditorGUILayout.FloatField(_effects.m_recovery.m_hpRecoveryPercentage), -100f, 100f);
                _effects.m_recovery.m_hpRecoveryAmount = Mathf.Clamp(EditorGUILayout.IntField(_effects.m_recovery.m_hpRecoveryAmount), -999999, 999999);
                EditorGUILayout.EndVertical();
                _mpRecoveryButton = false;
                _tpGainButton = false;
            }
            else
            {
                EditorGUILayout.Space();
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            _mpRecoveryButton = EditorGUILayout.ToggleLeft("MP Recovery", _mpRecoveryButton);
            if (_mpRecoveryButton)
            {
                EditorGUILayout.BeginVertical();
                _effects.m_recovery.m_mpRecoveryPercentage = Mathf.Clamp(EditorGUILayout.FloatField(_effects.m_recovery.m_mpRecoveryPercentage), -100f, 100f);
                _effects.m_recovery.m_mpRecoveryAmount = Mathf.Clamp(EditorGUILayout.IntField(_effects.m_recovery.m_mpRecoveryAmount), -999999, 999999);
                EditorGUILayout.EndVertical();
                _hpRecoveryButton = false;
                _tpGainButton = false;
            }
            else
            {
                EditorGUILayout.Space();
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            _tpGainButton = EditorGUILayout.ToggleLeft("TP Gain", _tpGainButton);
            if (_tpGainButton)
            {
                _effects.m_recovery.m_tpGainAmount = Mathf.Clamp(EditorGUILayout.FloatField(_effects.m_recovery.m_tpGainAmount), 0, 100);
                _hpRecoveryButton = false;
                _mpRecoveryButton = false;
            }
            else
            {
                EditorGUILayout.Space();
            }
            EditorGUILayout.EndHorizontal();
        }

        private void DisplayCloseButton()
        {
            EditorGUILayout.Space(20);
            EditorGUILayout.BeginHorizontal();
            GUILayout.Button("OK");
            GUILayout.Button("Cancel");
            EditorGUILayout.EndHorizontal();
        }

        #endregion


        #region Private and Protected Members

        private Effects _effects;
        private EffecsComponentsEnum _effecsComponentsEnum;
        private bool _hpRecoveryButton = false;
        private bool _mpRecoveryButton = false;
        private bool _tpGainButton = false;
        private ObjectData _object;

        #endregion
    }
}
