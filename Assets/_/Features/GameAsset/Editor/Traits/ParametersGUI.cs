using GameAsset.Runtime;
using UnityEditor;

namespace GameAsset.Editor
{
    public class ParametersGUI : EditorWindow
    {
        #region Main Methods

        public void Initialize(Params actorParams)
        {
            _actorParams = actorParams;
        }

        public void ShowParameters()
        {

            //Beginning of the tab

            //Start of the first ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _paramGroupActive = EditorGUILayout.BeginToggleGroup("Paramètre", _paramGroupActive);

            EditorGUILayout.BeginVertical();

            _actorParams.m_parametre = (ParametersEnum)EditorGUILayout.EnumPopup(_actorParams.m_parametre);
            EditorGUILayout.FloatField(_actorParams.m_percentageParametre);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the Second ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _ExParamGroupActive = EditorGUILayout.BeginToggleGroup("Ex-Paramètre", _ExParamGroupActive);
            
            EditorGUILayout.BeginVertical();

            _actorParams.m_exParameter = (Params.ExParameters)EditorGUILayout.EnumPopup(_actorParams.m_exParameter);
            EditorGUILayout.FloatField(_actorParams.m_percentageExParam);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the Third ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _SpParamGroupActive = EditorGUILayout.BeginToggleGroup("Sp-Paramètre", _SpParamGroupActive);

            _actorParams.m_spParameter = (Params.SpParameters)EditorGUILayout.EnumPopup(_actorParams.m_spParameter);
            EditorGUILayout.FloatField(_actorParams.m_percentageSpParam);
            
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            DisableOthersHandle();
        }

       private void DisableOthersHandle()
       {
            if (_SpParamGroupActive && !_SpParamGroupIsActived)
            {
                _paramGroupActive = false;
                _ExParamGroupActive = false;

                _paramGroupIsActived = false;
                _ExParamGroupIsActived = false;
                _SpParamGroupIsActived = true;

                //ToggleActive(_SpParamGroupIsActived);
            }
            else if (_ExParamGroupActive && !_ExParamGroupIsActived)
            {
                _paramGroupActive = false;
                _SpParamGroupActive = false;

                _paramGroupIsActived = false;
                _ExParamGroupIsActived = true;
                _SpParamGroupIsActived = false;

                //ToggleActive (_ExParamGroupIsActived);
            }
            else if (_paramGroupActive && !_paramGroupIsActived)
            {
                _SpParamGroupActive = false;
                _ExParamGroupActive = false;

                _paramGroupIsActived = true;
                _ExParamGroupIsActived = false;
                _SpParamGroupIsActived = false;

                //ToggleActive(_paramGroupIsActived);
            }
       }

       private void ToggleActive(bool activeGroup)
       {
            _paramGroupIsActived = false;
            _ExParamGroupIsActived = false;
            _SpParamGroupIsActived = false;

            activeGroup = true;
       }

        #endregion


        #region Private and Protected

        Params _actorParams;

        bool _paramGroupActive;
        bool _ExParamGroupActive;
        bool _SpParamGroupActive;

        bool _paramGroupIsActived;
        bool _ExParamGroupIsActived;
        bool _SpParamGroupIsActived;

        //bool _isToggled;

        #endregion
    }
}
