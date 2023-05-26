using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class SkillToLearn
    {
        #region Public Members

        public int m_level;
        public SkillData m_skill;
        public string m_comment;

        #endregion
    }
}