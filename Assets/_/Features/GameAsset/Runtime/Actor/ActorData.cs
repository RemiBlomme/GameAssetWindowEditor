using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "ActorData", menuName = "Game Database/Actor")]
    public class ActorData : ScriptableObject
    {
        #region Public Members

        public GeneralParametersActor m_generalParameters;
        public Images m_images;
        public InitialEquipement m_initialEquipement;
        public Traits m_traits;
        public Comment m_comment;

        #endregion
    }
}