using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class ImagesGUI
    {
        #region Public Members

        public Images m_imagesData;

        #endregion


        #region Main Methods

        public void GetGUI(Images data)
        {
            SetImageDataInstance(data);

            if (m_imagesData == null) return;

            Display();
        }

        private void Display()
        {
            GUILayout.Label("Images", GetStyle());

            GUILayout.BeginHorizontal();

            FaceField();
            CharacterField();
            FighterField();

            GUILayout.EndHorizontal();
        }

        #endregion


        #region Utils

        private void SetImageDataInstance(Images instance)
        {
            m_imagesData = instance;
        }

        private GUIStyle GetStyle()
        {
            GUIStyle boldFontStyle = new GUIStyle();
            boldFontStyle.fontStyle = FontStyle.Bold;
            boldFontStyle.normal.textColor = Color.white;

            return boldFontStyle;
        }

        private void FaceField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Face:");

            m_imagesData.m_faceSprite = EditorGUILayout.ObjectField(m_imagesData.m_faceSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f)) as Sprite;

            GUILayout.EndVertical();
        }

        private void CharacterField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("Character:");

            m_imagesData.m_characterSprite = EditorGUILayout.ObjectField(m_imagesData.m_characterSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f)) as Sprite;

            GUILayout.EndVertical();
        }

        private void FighterField()
        {
            GUILayout.BeginVertical();

            GUILayout.Label("[SV] Fighter :");

            m_imagesData.m_fighterSprite = EditorGUILayout.ObjectField(m_imagesData.m_fighterSprite, typeof(Sprite), false, GUILayout.MaxWidth(100f), GUILayout.MaxHeight(100f)) as Sprite;

            GUILayout.EndVertical();
        }

        #endregion
    }
}