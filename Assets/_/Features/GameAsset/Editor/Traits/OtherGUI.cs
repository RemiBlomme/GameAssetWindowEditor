using GameAsset.Runtime;
using UnityEditor;

namespace GameAsset.Editor
{
    public class OtherGUI : EditorWindow
    {
        #region Main Methods
        public void Initialize(Other actorOther)
        {
            _actorOther = actorOther;
        }
        public void ShowOther()
        {
            //Start of the first ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _actionTimeActive = EditorGUILayout.BeginToggleGroup("Temps d'action", _actionTimeActive);

            EditorGUILayout.BeginVertical();

            EditorGUILayout.FloatField(_actorOther.m_actionTimes);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the second ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _specialFlagActive = EditorGUILayout.BeginToggleGroup("Drapeau Spécial", _specialFlagActive);

            EditorGUILayout.BeginVertical();

            _actorOther.m_specialFlag = (Other.SpecialFlags)EditorGUILayout.EnumPopup(_actorOther.m_specialFlag);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the second ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _collapseEffectActive = EditorGUILayout.BeginToggleGroup("Effets Effondrement", _collapseEffectActive);

            EditorGUILayout.BeginVertical();

            _actorOther.m_collapseEffect = (Other.CollapseEffects)EditorGUILayout.EnumPopup(_actorOther.m_collapseEffect);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the second ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _partyAbilityActive = EditorGUILayout.BeginToggleGroup("Capacité Groupe", _partyAbilityActive);

            EditorGUILayout.BeginVertical();

            _actorOther.m_partyAbility = (Other.PartyAbilities)EditorGUILayout.EnumPopup(_actorOther.m_partyAbility);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            DisableOthersHandle();
        }

        private void DisableOthersHandle()
        {
            if (_actionTimeActive && !_actionTimeIsActived)
            {
                _specialFlagActive = false;
                _collapseEffectActive = false;
                _partyAbilityActive = false;

                _actionTimeIsActived = true;
                _specialFlagIsActived = false;
                _collapseEffectIsActived = false;
                _partyAbilityIsActived = false;

                //ToggleActive(_SpParamGroupIsActived);
            }
            else if (_specialFlagActive && !_specialFlagIsActived)
            {
                _actionTimeActive = false;
                _collapseEffectActive = false;
                _partyAbilityActive = false;

                _actionTimeIsActived = false;
                _specialFlagIsActived = true;
                _collapseEffectIsActived = false;
                _partyAbilityIsActived = false;

                //ToggleActive (_ExParamGroupIsActived);
            }
            else if (_collapseEffectActive && !_collapseEffectIsActived)
            {
                _actionTimeActive = false;
                _specialFlagActive = false;
                _partyAbilityActive = false;

                _actionTimeIsActived = false;
                _specialFlagIsActived = false;
                _collapseEffectIsActived = true;
                _partyAbilityIsActived = false;

                //ToggleActive(_paramGroupIsActived);
            }
            else if (_partyAbilityActive && !_partyAbilityIsActived)
            {
                _actionTimeActive = false;
                _specialFlagActive = false;
                _collapseEffectActive = false;

                _actionTimeIsActived = false;
                _specialFlagIsActived = false;
                _collapseEffectIsActived = true;
                _partyAbilityIsActived = false;

                //ToggleActive(_paramGroupIsActived);
            }
        }

        #endregion


        #region Private and Protected

        Other _actorOther;

        bool _actionTimeActive;
        bool _specialFlagActive;
        bool _collapseEffectActive;
        bool _partyAbilityActive;

        bool _actionTimeIsActived;
        bool _specialFlagIsActived;
        bool _collapseEffectIsActived;
        bool _partyAbilityIsActived;

        #endregion
    }
}
