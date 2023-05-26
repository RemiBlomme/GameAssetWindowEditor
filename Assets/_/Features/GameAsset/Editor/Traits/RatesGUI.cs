using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameAsset.Editor
{
    public class RatesGUI : UnityEditor.EditorWindow
    {
        #region Public Members
        #endregion


        #region Unity API
        #endregion


        #region Main Methods

        public void ShowRates()
        {
            Debug.Log("ui");
            EditorGUILayout.TextField("yes");    
        }

        #endregion
    }
}
