using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Game Database/Weapon")]
    public class WeaponData : ScriptableObject
    {
        #region Public Members

        public GeneralParametersWeapon m_generalParametersWeapon;
        public ParameterChange m_parameterChange;
        public Traits m_traits;
        public Comment m_comment;

        #endregion
    }
}