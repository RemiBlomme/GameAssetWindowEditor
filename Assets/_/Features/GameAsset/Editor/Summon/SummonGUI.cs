using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class SummonGUI : EditorWindow
    {
        #region Unity API

        [MenuItem ("Summon/SummonGUI")]
        public static void ShowWindow()
        {
            var window = GetWindow<SummonGUI>();
            window.titleContent.text = "Summon Tool";
        }

        private void OnGUI()
        {
            GetGUI(_summon);
        }

        #endregion


        #region Main Methods

        public void GetGUI(Summon data)
        {
            SetInstanceSummon(data);

            if (_summon == null) return;

            Display();
        }

        private void SetInstanceSummon(Summon data)
        {
            //_summon = data;

            _skillData = EditorGUILayout.ObjectField(_skillData, typeof(SkillData), true) as SkillData;
            if (_skillData == null) return;
            _summon = _skillData.m_summon;
            EditorGUILayout.Space();
        }

        private void Display()
        {
            
            GUILayout.Label("Summon");
            

            GUILayout.BeginHorizontal();
            GUILayout.Label("Speed:");
            GUILayout.Label("Success:");
            GUILayout.Label("Repeat:");
            GUILayout.Label("TpGain:");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            _summon.m_speed = EditorGUILayout.FloatField(_summon.m_speed);
            _summon.m_success = EditorGUILayout.FloatField(_summon.m_success);
            _summon.m_repeat = EditorGUILayout.IntField(_summon.m_repeat);
            _summon.m_tpGain = EditorGUILayout.IntField(_summon.m_tpGain);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            _summon.m_hitType =(Summon.HitType) EditorGUILayout.EnumFlagsField(_summon.m_hitType);
            _summon.m_animation =(Summon.Animations) EditorGUILayout.EnumFlagsField(_summon.m_animation);
            GUILayout.EndHorizontal();
        }

        #endregion


        #region Private and Protected Members

        private Summon _summon;
        private SkillData _skillData;

        #endregion
    }
}