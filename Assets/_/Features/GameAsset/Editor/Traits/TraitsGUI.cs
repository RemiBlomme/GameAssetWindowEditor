using System;
using UnityEditor;
using UnityEngine;

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

        private void OnEnable()
        {
            m_ratesGUI = CreateInstance<RatesGUI>();
            m_paramGUI = CreateInstance<ParametersGUI>();
            m_attackGUI = CreateInstance<AttackGUI>();
            m_skillGUI = CreateInstance<SkillGUI>();
            m_equipGUI = CreateInstance<EquipGUI>();
            m_otherGUI = CreateInstance<OtherGUI>();
        }
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
                    m_ratesGUI.ShowRates();
                    break;
                case TraitsTabs.Parameters:
                    m_paramGUI.ShowParameters();
                    break;
                case TraitsTabs.Attack:
                    m_attackGUI.ShowAttack();
                    break;
                case TraitsTabs.Skills:
                    m_skillGUI.ShowSkill();
                    break;
                case TraitsTabs.Equip:
                    m_equipGUI.ShowEquip();
                    break;
                case TraitsTabs.Other:
                    m_otherGUI.ShowOther();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Main Methods
        #endregion

        #region Private and Protected

        RatesGUI m_ratesGUI;
        ParametersGUI m_paramGUI;
        AttackGUI m_attackGUI;
        SkillGUI m_skillGUI;
        EquipGUI m_equipGUI;
        OtherGUI m_otherGUI;

        #endregion
    }
}
