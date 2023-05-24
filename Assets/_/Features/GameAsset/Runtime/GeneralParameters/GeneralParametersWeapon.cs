using System;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersWeapon : GeneralParameters
    {
        #region Public Members

        public Sprite m_icon;
        public string m_description;
        public WeaponTypeData m_weaponType;
        public int m_price;

        #endregion
    }
}