using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GameAsset.Editor
{
    public class MessageGUI : EditorWindow
    {
        #region Public Members



        #endregion


        #region Unity API

        [MenuItem ("Skill/Message")]

        public static void ShowWindow()
        {
            var window = GetWindow<MessageGUI>();
            window.titleContent.text = "Message Tool";
        }

        

        private void OnGUI()
        {
            Message();
        }

        #endregion


        #region Main Methods

        public void Message()
        {
            GUILayout.Label("Message");
            _attack = EditorGUILayout.TextField("(Username)",_attack);
            _attack2 = EditorGUILayout.TextField(_attack2);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("throw"))
            {
                _attack = "throw";
            }

            if (GUILayout.Button("do"))
            {
                _attack = "do";
            }

            if (GUILayout.Button("use"))
            {
                _attack = "use";
            }

            GUILayout.EndHorizontal();
        }

        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members

        private string _attack;
        private string _attack2;

        #endregion
    }
}