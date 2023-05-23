using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(menuName = "Game Database/Actor")]
    public class ActorData : ScriptableObject
    {
        #region Public Members



        #endregion


        #region Unity API



        #endregion


        #region Main Methods



        #endregion


        #region Utils



        #endregion


        #region Private and Protected Members

        [Header("Properties")]
        [SerializeField] private string _name;
        [SerializeField] private string _surname;
        [SerializeField] private string _profile;
        [Space]
        //[SerializeField] private ClassData _class; // TODO change variable type
        [Space]
        [SerializeField] private int _initialLevel;
        [SerializeField] private int _maxLevel;
        [Space]
        [Header("Initial Equipments")]
        //[SerializeField] private WeaponData _weapon; // TODO change variable type
        //[SerializeField] private ShieldData _shield; // TODO change variable type
        //[SerializeField] private EquipmentData _head; // TODO change variable type
        //[SerializeField] private EquipmentData _bodies; // TODO change variable type
        //[SerializeField] private EquipmentData _accessories; // TODO change variable type
        [Space]
        [Header("Sprites")]
        [SerializeField] private Sprite _faceSprite;
        [SerializeField] private Sprite[] _characterSprites;
        [SerializeField] private Sprite _fightingSprite;

        #endregion
    }
}