using UnityEditor;

namespace GameAsset.Editor
{
    public class ImagesGUI : EditorWindow
    {
        [MenuItem("Tools/Images")]
        public static void ShowWindow()
        {
            var window = GetWindow<ImagesGUI>();
            window.titleContent.text = "Le Tool";
        }

        //[OnOpenAsset]
        //public static bool OpenAsset(int instanceID, int guid)
        //{
        //    if (Selection.activeObject as MyScriptableObject)
        //    {
        //        Debug.Log("double clické");
        //        ShowWindow();
        //        return true;
        //    }
        //    return false;
        //}
        #region Public Members



        #endregion


        #region Unity API

        private void OnGUI()
        {
            //OnImagesGUI();
        }

        #endregion


        #region Main Methods

        //public void OnImagesGUI()
        //{
        //    string[] guids = AssetDatabase.FindAssets("t:MyScriptableObject");
        //
        //    GUILayout.Label("Images");
        //
        //    GUILayout.BeginHorizontal();
        //
        //    GUILayout.Label("Face:");
        //
        //    EditorGUILayout.ObjectField(typeof )
        //
        //    GUILayout.EndHorizontal();
        //
        //}

        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members



        #endregion
    }
}