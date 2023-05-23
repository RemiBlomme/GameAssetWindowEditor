using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "New actor", menuName = "Game Database/Actor")]
    public class ActorData : ScriptableObject
    {
        #region Public Members

        [Header("General Settings")]
        public string m_name;
        public string m_surname;
        //public ClassData m_class; // TODO change variable type
        public int m_initialLevel;
        public int m_maxLevel;
        public string m_profile;
        [Space]
        [Header("Images")]
        public Sprite m_faceSprite;
        public Sprite[] m_characterSprites;
        public Sprite m_fightingSprite;
        //[Header("Initial Equipment")]
        //public WeaponData m_weapon; // TODO change variable type
        //public ShieldData m_shield; // TODO change variable type
        //public HeadData m_head; // TODO change variable type
        //public BodyData m_bodies; // TODO change variable type
        //public AccessoryData m_accessories; // TODO change variable type


        #endregion


        #region Unity API



        #endregion


        #region Main Methods

        

        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members


        #endregion
    }
}