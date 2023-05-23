using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class SkillsData : ScriptableObject
{
    #region Public Members

    [Header("General Settings")]
    public string m_name;
    public string m_description;
    public Sprite m_icon;
    //public string[] m_type;
    public int m_mp;
    public int m_tp;
    //public ApplicationCaseData m_applicationCase;
    public string[] m_occasion;

    [Header("Summon")]
    public int m_speed;
    public int m_success;
    public int m_repeat;
    public int m_tpGain;
    public string m_hitType;
    public string m_animation;

    [Header("Message")]
    public string m_message;

    [Header("Weapon requirement")]
    public string[] m_weaponTypeOne;
    public string[] m_weaponTypeTwo;

    [Header("Dammages")]
    public string[] m_dammageType;
    public string[] m_element;
    public string m_formula;
    public int m_variance;
    public bool m_criticalHit;

    [Header("Effect")]
    public string[,] m_effect;

    [Header("Remark")]
    public string[] m_remark;

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