using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "ObjectData", menuName = "Game Database/Object")]
    public class ObjectData : ScriptableObject
    {
        #region Public Members

        public GeneralParametersObject m_generalParameters;
        public Summon m_summon;
        public Damages m_damages;
        public Effects[] m_effects;
        public Comment m_comment;

        #endregion
    }
}