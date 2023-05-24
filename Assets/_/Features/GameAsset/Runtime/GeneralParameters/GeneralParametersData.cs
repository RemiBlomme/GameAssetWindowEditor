using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(menuName = "Boxes/General Parameters")]
    public class GeneralParametersData : ScriptableObject
    {
        [Serializable]
        public struct Field
        {
            public Field(Type type, bool isEnabled)
            {
                m_type = type;
                m_isEnabled = isEnabled;
            }
            public Type m_type;
            public bool m_isEnabled;
        }

        #region Public Members
        
        public Field m_name = new(typeof(string), false);
        public Field m_username = new(typeof(string), false);
        public Field m_profile = new(typeof(string), false);
        public Field m_description = new(typeof(string), false);

        public Field m_initialLevel = new(typeof(int), false);
        public Field m_maxLevel = new(typeof(int), false);
        public Field m_experienceCurve = new(typeof(int[]), false);

        public Field m_mpCost = new(typeof(int), false);
        public Field m_tpCost = new(typeof(int), false);
        public Field m_price = new(typeof(int), false);

        public Field m_applicationField = new(typeof(ApplicationField), false);
        public Field m_usageCondition = new(typeof(UsageCondition), false);

        public Field m_icone = new(typeof(Sprite), false);

        public Field m_edibleness = new(typeof(bool), false);
        public Field m_class = new(typeof(string), false); //TODO Change Variable Type
        public Field m_skillType = new(typeof(string), false); //TODO Change Variable Type
        public Field m_weaponType = new(typeof(string), false); //TODO Change Variable Type
        public Field m_armorType = new(typeof(string), false); //TODO Change Variable Type
        public Field m_equipmentType = new(typeof(string), false); //TODO Change Variable Type
        public Field m_animation = new(typeof(AnimationClip), false);

        public enum ApplicationField
        {
            None,
            OneEnemy,
            AllEnemies,
            OneRandomEnemy,
            TwoRandomEnemies,
            ThreeRandomEnemies,
            FourRandomEnemies,
            OneAlly,
            AllAllies,
            OneAllyDead,
            AllAlliesDead,
            User
        }

        public enum UsageCondition
        {
            Always,
            BattleScreen,
            MenuScreen,
            Never
        }

        #endregion


        #region Unity API

        #endregion


        #region Main Methods



        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members



        #endregion
    }
}