using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class GeneralParametersActorGUI : EditorWindow
    {
        #region Public Members

        #endregion

        #region Unity API

        private void OnGUI()
        {
            GetGUI();
        }

        #endregion

        #region Main Methods

        [MenuItem("Testing/actor")]
        public static void ShowWindow()
        {
            GetWindow<GeneralParametersActorGUI>();
        }

        public void GetGUI()
        {
            GUIStyle boldFontStyle = new()
            {
                fontStyle = FontStyle.Bold,
            };
            boldFontStyle.normal.textColor = Color.white;
            GUILayout.Label("General Parameters", boldFontStyle);

            _actor = (ActorData)EditorGUILayout.ObjectField(_actor, typeof(ActorData), false);
            if (_actor is null) return;

            GUILayout.BeginHorizontal();
            NameField();
            if (Event.current.type == EventType.Repaint)
            {
                _nameFieldWidth = GUILayoutUtility.GetLastRect().width;
            }
            GUILayout.Space(15);
            NicknameField();
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            ClassField();
            GUILayout.Space(15);
            InitialLevelField();
            MaxLevelField();
            GUILayout.EndHorizontal();
            ProfileField();
        }

        private void NameField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Name:");
            _actor.m_generalParameters._name = EditorGUILayout.TextField(_actor.m_generalParameters._name);
            GUILayout.EndVertical();
        }

        private void NicknameField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Nickname:");
            _nickNameTextField = _actor.m_generalParameters.m_username;
            _nickNameTextField = EditorGUILayout.TextField(_nickNameTextField);
            if (_actor.m_generalParameters.m_username != _nickNameTextField)
            {
                _actor.m_generalParameters.m_username = _nickNameTextField;
            }
            GUILayout.EndVertical();
        }

        private void ClassField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Class:");
            _classObjectField = _actor.m_generalParameters.m_class;
            _classObjectField = (ClassData)EditorGUILayout.ObjectField(_classObjectField, typeof(ClassData), false, GUILayout.Width(_nameFieldWidth));
            if (_actor.m_generalParameters.m_class != _classObjectField)
            {
                _actor.m_generalParameters.m_class = _classObjectField;
            }
            GUILayout.EndVertical();
        }

        private void InitialLevelField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Initial Level:");
            _initialLevelIntField = _actor.m_generalParameters.m_initialLevel;
            _initialLevelIntField = EditorGUILayout.IntField(_initialLevelIntField);
            if (_actor.m_generalParameters.m_initialLevel != _initialLevelIntField)
            {
                _actor.m_generalParameters.m_initialLevel = _initialLevelIntField;
            }
            GUILayout.EndVertical();
        }

        private void MaxLevelField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Max Level:");
            _maxLevelIntField = _actor.m_generalParameters.m_maxLevel;
            _maxLevelIntField = EditorGUILayout.IntField(_maxLevelIntField);
            if (_actor.m_generalParameters.m_maxLevel != _maxLevelIntField)
            {
                _actor.m_generalParameters.m_maxLevel = _maxLevelIntField;
            }
            GUILayout.EndVertical();
        }

        private void ProfileField()
        {
            GUILayout.BeginVertical();
            GUILayout.Label("Profile:");
            _profileFieldVectorPosition = GUILayout.BeginScrollView(_profileFieldVectorPosition, GUILayout.Height(80));
            _profileField = _actor.m_generalParameters.m_profile;
            _profileField = GUILayout.TextArea(_profileField, GUILayout.ExpandHeight(true));
            if (_actor.m_generalParameters.m_profile != _profileField)
            {
                _actor.m_generalParameters.m_profile = _profileField;
            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
        }

        #endregion

        #region Utils

        #endregion

        #region Private and Protected Members

        private string _nameTextField;
        private float _nameFieldWidth;
        private string _nickNameTextField;

        private ClassData _classObjectField;
        private int _initialLevelIntField;
        private int _maxLevelIntField;

        private string _profileField;
        private Vector2 _profileFieldVectorPosition;

        private ActorData _actor;

        #endregion
    }
}