using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

namespace GameAsset.Editor
{
    public class TraitsGUI : UnityEditor.EditorWindow
    {
        [MenuItem("Traits/MainTraitsWindow")]
        public static void ShowWindow()
        {
            var window = EditorWindow.GetWindow<TraitsGUI>();
            window.titleContent = new GUIContent("Traits", "C'est les traits mageule");
        }

        public enum TraitsTabs
        {
            Rates,
            Parameters,
            Attack,
            Skills,
            Equip,
            Other
        }

        #region Public Members

        public TraitsTabs m_tabs = TraitsTabs.Rates;

        #endregion


        #region Unity API
        private void OnGUI()
        {
            DisplayTraitsWindow();
        }
        #endregion


        #region Main Methods

        public void DisplayTraitsWindow()
        {
            var _names = Enum.GetNames(typeof(TraitsTabs));

            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < _names.Length; i++)
            {
                if (GUILayout.Button($"{_names[i]}"))
                {
                    Enum.TryParse<TraitsTabs>(_names[i], out TraitsTabs result);

                    m_tabs = result;
                }
            }
            EditorGUILayout.EndHorizontal();
            ;
            //switch with differentTabs

            switch (m_tabs)
            {
                case TraitsTabs.Rates:
                    ShowRates();
                    break;
                case TraitsTabs.Parameters:
                    ShowParameters();
                    break;
                case TraitsTabs.Attack:
                    ShowAttack();
                    break;
                case TraitsTabs.Skills:
                    ShowSkills();
                    break;
                case TraitsTabs.Equip:
                    ShowEquip();
                    break;
                case TraitsTabs.Other:
                    ShowOther();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Main Methods

        public void ShowRates()
        {
            EditorGUILayout.TextField("Rates");
        }

        public void ShowParameters()
        {
            EditorGUILayout.TextField("Params");

        }
        public void ShowAttack()
        {
            EditorGUILayout.TextField("Attack");

        }

        public void ShowSkills()
        {
            EditorGUILayout.TextField("Skills");

        }

        public void ShowEquip()
        {
            EditorGUILayout.TextField("Equip");

        }

        public void ShowOther()
        {
            EditorGUILayout.TextField("Other");

        }
        #endregion
    }
}
