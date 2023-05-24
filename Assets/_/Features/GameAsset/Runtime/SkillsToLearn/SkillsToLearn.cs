using System;
using System.Collections.Generic;

namespace GameAsset.Runtime
{
    [Serializable]
    public class SkillsToLearn
    {
        #region Public Members

        public List<int> m_level;
        public List<SkillData> m_skill;
        public List<string> m_comment;

    	#endregion
    }
}