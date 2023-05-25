using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersObject : GeneralParameters
    {
        #region Public Members

        public Sprite m_icon;
        public string m_description;
        public ObjectData m_objectType; 
        public int m_price;
        public bool m_isEdible;
        public ApplicationField m_applicationField;
        public UsageCondition m_usageCondition;

        #endregion
    }
}