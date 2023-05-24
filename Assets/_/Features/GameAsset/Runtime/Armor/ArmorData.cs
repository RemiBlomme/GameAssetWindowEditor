using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu]
    public class ArmorData : ScriptableObject   
    {
        public ParameterChange m_parameterChange;
        public Traits m_traits;
        public GeneralParametersArmor m_generalParametersArmor;
    }
}
