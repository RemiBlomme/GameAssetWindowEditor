using GameAsset.Runtime;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class MessageGUI
    {
        #region Main Methods


        public void GetGUI(Message data)
        {
            SetInstanceMessage(data);

            if(_message == null) return;

            Display();
        }

        private void SetInstanceMessage(Message data)
        {
            _message = data;
        }

        private void Display()
        {
            GUILayout.Label("Message");
            _message.m_messageAction = EditorGUILayout.TextField("(Username)", _message.m_messageAction);
            _message.m_messageDetail = EditorGUILayout.TextField(_message.m_messageDetail);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("throw"))
            {
                _message.m_messageAction = "throw !";
            }

            if (GUILayout.Button("do"))
            {
                _message.m_messageAction = "do !";
            }

            if (GUILayout.Button("use"))
            {
                _message.m_messageAction = "use !";
            }

            GUILayout.EndHorizontal();
        }

        #endregion


        #region Private and Protected Members

        private Message _message;

        #endregion
    }
}