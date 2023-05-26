using GameAsset.Runtime;
using UnityEditor;

namespace GameAsset.Editor
{
    public class AttackGUI : EditorWindow
    {
        #region Main Methods
        public void Initialize(Attack actorAttack)
        {
            _actorAttack = actorAttack;
        }

        public void ShowAttack()
        {
            //Start of the first ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _attackElementActive = EditorGUILayout.BeginToggleGroup("Elément d'attaque", _attackElementActive);

            EditorGUILayout.BeginVertical();

            _elementType = EditorGUILayout.ObjectField("Elément d'attaque", _elementType, typeof(ElementTypeData), true) as ElementTypeData;


            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the second ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _attackStateActive = EditorGUILayout.BeginToggleGroup("Etat d'attaque", _attackStateActive);

            EditorGUILayout.BeginVertical();

            _actorAttack.m_stateAttack = (States)EditorGUILayout.EnumPopup(_actorAttack.m_stateAttack);
            EditorGUILayout.FloatField(_actorAttack.m_percentageAttack);


            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the third ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _attackSpeedActive = EditorGUILayout.BeginToggleGroup("Vitesse d'attaque", _attackSpeedActive);

            EditorGUILayout.BeginVertical();

            EditorGUILayout.FloatField(_actorAttack.m_attackSpeed);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            //Start of the third ToggleGroup
            EditorGUILayout.BeginHorizontal();
            _attackTimesActive = EditorGUILayout.BeginToggleGroup("Vitesse d'attaque", _attackTimesActive);

            EditorGUILayout.BeginVertical();

            EditorGUILayout.FloatField(_actorAttack.m_attackTimes);

            EditorGUILayout.EndVertical();
            EditorGUILayout.EndToggleGroup();
            EditorGUILayout.EndHorizontal();

            DisableOthersHandle();
        }

        private void DisableOthersHandle()
        {
            if (_attackElementActive && !_attackElementIsActived)
            {
                _attackTimesActive = false;
                _attackStateActive = false;
                _attackSpeedActive = false;

                _attackElementIsActived = true;
                _attackStateIsActived = false;
                _attackSpeedIsActived = false;
                _attackTimesIsActived = false;

                //ToggleActive(_SpParamGroupIsActived);
            }
            else if (_attackStateActive && !_attackStateIsActived)
            {
                _attackElementActive = false;
                _attackTimesActive = false;
                _attackSpeedActive = false;

                _attackElementIsActived = false;
                _attackStateIsActived = true;
                _attackSpeedIsActived = false;
                _attackTimesIsActived = false;
                //ToggleActive (_ExParamGroupIsActived);
            }
            else if (_attackSpeedActive && !_attackSpeedIsActived)
            {
                _attackElementActive = false;
                _attackStateActive = false;
                _attackTimesActive = false;

                _attackElementIsActived = false;
                _attackStateIsActived = false;
                _attackSpeedIsActived = true;
                _attackTimesIsActived = false;

                //ToggleActive(_paramGroupIsActived);
            }
            else if (_attackTimesActive && !_attackTimesIsActived)
            {
                _attackElementActive = false;
                _attackStateActive = false;
                _attackSpeedActive = false;

                _attackElementIsActived = false;
                _attackStateIsActived = false;
                _attackSpeedIsActived = false;
                _attackTimesIsActived = true;
            }
        }
        #endregion


        #region Private and Protected

        Attack _actorAttack;
        ElementTypeData _elementType;

        bool _attackElementActive;
        bool _attackStateActive;
        bool _attackSpeedActive;
        bool _attackTimesActive;

        bool _attackElementIsActived;
        bool _attackStateIsActived;
        bool _attackSpeedIsActived;
        bool _attackTimesIsActived;
        #endregion
    }
}
