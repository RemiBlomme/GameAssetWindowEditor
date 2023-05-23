using UnityEngine;

[CreateAssetMenu]
public class WeaponData : ScriptableObject
{
    #region Public Members

    public enum WeaponType
    {
        Sword,
        Hammer,
        Axe
    }

    public string m_name, m_description;
    public Texture m_icon;
    public WeaponType m_type;
    public int m_price;

    public int m_damage, m_defense, m_magicDamage, m_magicDefense, m_agility, m_luck, m_maxHP, m_maxMP;

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