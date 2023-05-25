using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "Object", menuName = "Game Database/Object")]
    public class ObjectData : ScriptableObject
    {
        #region Public Members

        public Summon m_summon;
        public Damages m_damages;
        public Effects[] m_effects;
        public string m_remarque;

        #endregion
    }
}