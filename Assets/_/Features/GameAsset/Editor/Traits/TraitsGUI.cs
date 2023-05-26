using GameAsset.Runtime;
using System;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class TraitsGUI : EditorWindow
    {
        public enum TraitsTabs
        {
            Rates,
            Parameters,
            Attack,
            Skills,
            Equip,
            Other
        }


        [MenuItem("Traits/MainTraitsWindow")]
        public static void ShowWindow()
        {
            var window = GetWindow<TraitsGUI>();
            window.titleContent = new GUIContent("Traits", "C'est les traits magueule");
            
        }

        #region Public Members

        public TraitsTabs m_tabs = TraitsTabs.Rates;

        public ActorData m_actor;

        #endregion


        #region Unity API

        private void OnEnable()
        {
            InstantiateTabs();
        }

        private void InstantiateTabs()
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
            InstanceCheck();
            DisplayTraitsWindow();
        }


        #endregion


        #region Main Methods
        private void InstanceCheck()
        {
            if (m_paramGUI != null)
            {
                m_paramGUI.Initialize(m_paramsData);
            }
            if (m_attackGUI != null)
            {
                m_attackGUI.Initialize(m_attackData);
            }
            if (m_otherGUI != null)
            {
                m_otherGUI.Initialize(m_otherData);
            }
        }

        public void DisplayTraitsWindow()
        {
            m_actor = EditorGUILayout.ObjectField("Actor", m_actor, typeof(ActorData), true) as ActorData;
            if (m_actor == null) return;
            m_paramsData = m_actor.m_traits.m_params;
            m_ratesData = m_actor.m_traits.m_rates;
            m_attackData = m_actor.m_traits.m_attack;
            m_skillData = m_actor.m_traits.m_comp;
            m_equipData = m_actor.m_traits.m_equip;
            m_otherData = m_actor.m_traits.m_other;
            EditorGUILayout.Space();



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

        public Params m_paramsData;
        public Rates m_ratesData;
        public Attack m_attackData;
        public Comp m_skillData;
        public Equip m_equipData;
        public Other m_otherData;

        RatesGUI m_ratesGUI;
        ParametersGUI m_paramGUI;
        AttackGUI m_attackGUI;
        SkillGUI m_skillGUI;
        EquipGUI m_equipGUI;
        OtherGUI m_otherGUI;

        #endregion
    }
}
