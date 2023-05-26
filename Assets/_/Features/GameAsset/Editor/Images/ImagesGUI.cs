using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class ImagesGUI : EditorWindow
    {
        [MenuItem("Tools/Images")]
        public static void ShowWindow()
        {
            var window = GetWindow<ImagesGUI>();
            window.titleContent.text = "Images";
        }

        #region Public Members

        public Images m_imagesData;
        public ActorData m_actorData;

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


            if (m_imagesData == null) return;

            GUIStyle boldFontStyle = new GUIStyle();
            boldFontStyle.fontStyle = FontStyle.Bold;
            boldFontStyle.normal.textColor = Color.white;
            GUILayout.Label("Images", boldFontStyle);
            
            GUILayout.BeginHorizontal();

            FaceField();

            CharacterField();

            FighterField();

            GUILayout.EndHorizontal();
        }

        public void SetImageDataInstance(Images instance)
        {
            m_imagesData = instance;
        }

        private void SetImageDataInstanceAsToBeDELETED()
        {
            m_actorData = EditorGUILayout.ObjectField(m_actorData, typeof(ActorData), false) as ActorData;
            if (m_actorData == null) return;
            m_imagesData = m_actorData.m_images;
            EditorGUILayout.Space();
        }

        public void FaceField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Face:");

            _faceSprite = m_imagesData.m_faceSprite; // Should be done once
            _faceSprite = (Sprite)EditorGUILayout.ObjectField(_faceSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f));
            m_imagesData.m_faceSprite = _faceSprite;

            GUILayout.EndVertical();
        }

        public void CharacterField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Character:");

            _characterSprite = m_imagesData.m_characterSprite; // Should be done once
            _characterSprite = (Sprite)EditorGUILayout.ObjectField(_characterSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f));
            m_imagesData.m_characterSprite = _characterSprite;

            GUILayout.EndVertical();
        }

        public void FighterField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("[SV] Fighter :");

            _fighterSprite = m_imagesData.m_fighterSprite; // Should be done once
            _fighterSprite = (Sprite)EditorGUILayout.ObjectField(_fighterSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f));
            m_imagesData.m_fighterSprite = _fighterSprite;

            GUILayout.EndVertical();
        }
     

        #endregion


        #region Private and Protected Members

        private Sprite _faceSprite;
        private Sprite _characterSprite;
        private Sprite _fighterSprite;

        #endregion
    }
}