using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu]
    public class ClassData : ScriptableObject
    {
        #region Public Member
        public int m_maxChange;
        public string m_name;
        public int m_baseValue;
        public int m_supValue;
        public int m_acceleratorA;
        public int m_acceleratorB;
        public int[] m_XP;
        public int[] m_TotalXP;
        //l'index du tableau sert pour le niveau
        public int[] m_hpMaxValue;
        public int[] m_mpMaxValue;
        public int[] m_attackValue;
        public int[] m_defenseValue;
        public int[] m_attackMValue;
        public int[] m_defenseMValue;
        public int[] m_agilityValue;
        public int[] m_luckValue;
        //public AnimationCurve m_hpMaxCurve;

        #endregion


        public void OnDisable()
        {
            
        }
    }
}
