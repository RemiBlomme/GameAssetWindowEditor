using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "SkillData", menuName = "Game Database/Skill")]
    public class SkillData : ScriptableObject
    {
        #region Public Members

        public GeneralParametersSkill m_generalParameters;
        public Summon m_summon;
        public Message m_message;
        public WeaponRequired m_weaponRequired;
        public Damages m_damages;
        public Effects m_effects;
        public Comment m_comment;

        #endregion
    }
}