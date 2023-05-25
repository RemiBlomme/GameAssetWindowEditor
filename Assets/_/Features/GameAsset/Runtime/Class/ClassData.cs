using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName="ClassData", menuName ="Game Database/Class")]
    public class ClassData : ScriptableObject
    {
        #region Public Member

        public GeneralParametersClass m_generalParametersClass;
        public ParameterCurve m_parameterCurve;
        public SkillsToLearn m_skillsToLearn;        
        public List<Traits> m_traits;
        public Comment m_comment;
	
    	#endregion
    }
}