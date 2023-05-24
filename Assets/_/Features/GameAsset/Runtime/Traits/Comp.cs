using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Comp : TraitsParent
    {
        #region Public Members

        //Add type Skill
        public SkillTypeData m_skillTypes;

        //Seal Type Skill
        public SkillTypeData m_skillTypesSeal;

        //Add Skill
        public SkillData m_skills;

        //Seal Skill
        public SkillData m_skillsSeal;

        #endregion

    }
}
