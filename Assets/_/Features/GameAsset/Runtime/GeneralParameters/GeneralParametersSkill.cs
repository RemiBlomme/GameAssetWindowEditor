using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersSkill : GeneralParameters
    {
        #region Public Members

        public Sprite m_icone;
        public string m_description;
        public SkillTypeData m_skillType; 
        public int m_mpCost;
        public int m_tpCost;
        public ApplicationField m_applicationField;
        public UsageCondition m_usageCondition;

        #endregion
    }
}