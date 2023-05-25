using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName ="ArmorData", menuName ="Game Database/Armor")]
    public class ArmorData : ScriptableObject   
    {
        public ParameterChange m_parameterChange;
        public List<Traits> m_traits = new List<Traits>();
        public GeneralParametersArmor m_generalParametersArmor;
        public Comment m_comment;
    }
}