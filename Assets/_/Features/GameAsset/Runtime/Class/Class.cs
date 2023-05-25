using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName="class", menuName ="Game Database/Class")]
    public class Class : ScriptableObject
    {
        #region Public Member

        public GeneralParametersClass m_generalParametersClass;
        public ParameterCurve m_parameterCurve;
        public SkillsToLearn m_skillsToLearn;
        public Traits m_traits;
        public Comment m_comment;
	
    	#endregion
	
	
    	#region Unity API
	
    	void Awake()
    	{
		
    	}
	
        void Start()
        {
        
        }

        void Update()
        {
        
        }
	
    	void FixedUpdate()
    	{
		
    	}
	
    	#endregion
	
    	#region Main Methods
	
    	#endregion
	
    	#region Private And Protect
	
    	#endregion
    }
}
