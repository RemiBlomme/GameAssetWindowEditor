using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersActor : GeneralParameters
    {
        #region Public Members

        public string m_username;
        public string m_profile;
        public string m_class; // TODO Change variable type
        public int m_initialLevel;
        public int m_maxLevel;

        #endregion
    }
}