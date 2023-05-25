using GameAsset.Runtime;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Game Database/Weapon")]
    public class WeaponData : ScriptableObject
    {
        #region Public Members

        public GeneralParametersWeapon m_generalParametersWeapon;
        public ParameterChange m_change;
        public Traits m_traits;
        public Comment m_comment;

        #endregion Public Members

        #region Unity API

        #endregion Unity API

        #region Main Methods

        #endregion Main Methods

        #region Utils

        #endregion Utils

        #region Private and Protected Members

        #endregion Private and Protected Members
    }
}