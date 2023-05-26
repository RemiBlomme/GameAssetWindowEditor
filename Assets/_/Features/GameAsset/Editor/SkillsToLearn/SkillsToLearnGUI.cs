using GameAsset.Runtime;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class SkillsToLearnGUI : EditorWindow
    {
        [MenuItem("Tools/SkillsToLearn")]
        public static void ShowWindow()
        {
            var window = GetWindow<SkillsToLearnGUI>();
            window.titleContent.text = "SkillsToLearn";
        }
        #region Public Members

        public ClassData m_classData;
        public SkillsToLearn m_skillsToLearn;

        #endregion


        #region Unity API

        private void OnGUI()
        {
            GetGUI();
        }

        #endregion


        #region Main Methods

        public void GetGUI()
        {
            SetImageDataInstanceAsToBeDELETED();

            GUIStyle boldFontStyle = new GUIStyle();
            boldFontStyle.fontStyle = FontStyle.Bold;
            boldFontStyle.normal.textColor = Color.white;
            GUILayout.Label("SkillsToLearn", boldFontStyle);

            if (m_classData is null) return;

            _skillsToLearn = m_classData.m_skillsToLearn.m_skillsToLearn;

            if (_skillsToLearn is null) return;

            if (GUILayout.Button("Create new skill to learn"))
            {
                CreateNewSkillToLearn();
            }

            GUILayout.BeginScrollView(new Vector2());

            GUILayout.BeginHorizontal();

            LevelField();
            SkillField();
            CommentField();
            RemoveField();

            GUILayout.EndHorizontal();

            GUILayout.EndScrollView();
        }

        public void SetSkillsToLearnDataInstance(SkillsToLearn instance)
        {
            m_skillsToLearn = instance;
        }

        private void SetImageDataInstanceAsToBeDELETED()
        {
            m_classData = EditorGUILayout.ObjectField(m_classData, typeof(ClassData), false) as ClassData;
            if (m_classData == null) return;
            m_skillsToLearn = m_classData.m_skillsToLearn;
            EditorGUILayout.Space();
        }

        public void LevelField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Level");

            for (int i = 0; i < _skillsToLearn.Count; i++)
            {
                _skillsToLearn[i].m_level = EditorGUILayout.IntField(_skillsToLearn[i].m_level);
            }

            GUILayout.EndVertical();
        }

        public void SkillField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Skill");

            for (int i = 0; i < _skillsToLearn.Count; i++)
            {
                _skillsToLearn[i].m_skill = EditorGUILayout.ObjectField(_skillsToLearn[i].m_skill, typeof(SkillData), false) as SkillData;
            }

            GUILayout.EndVertical();
        }

        public void CommentField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Comment");

            for (int i = 0; i < _skillsToLearn.Count; i++)
            {
                _skillsToLearn[i].m_comment = EditorGUILayout.TextField(_skillsToLearn[i].m_comment);
            }

            GUILayout.EndVertical();
        }

        public void RemoveField()
        {
            GUILayout.BeginVertical();

            GUILayout.Space(20);

            for (int i = 0; i < _skillsToLearn.Count; i++)
            {
                if (GUILayout.Button("-", GUILayout.Width(20f), GUILayout.Height(18f)))
                {
                    RemoveSkillToLearn(i);
                }
            }

            GUILayout.EndVertical();
        }

        public void CreateNewSkillToLearn()
        {
            _skillsToLearn.Add(new SkillToLearn());
        }

        public void RemoveSkillToLearn(int index)
        {
            if (_skillsToLearn.Count == 0) return;

            _skillsToLearn.RemoveAt(index);
        }

        #endregion


        #region Private and Protected Members

        private List<SkillToLearn> _skillsToLearn;

        #endregion
    }
}