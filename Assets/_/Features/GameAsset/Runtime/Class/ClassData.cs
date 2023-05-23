using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    [CreateAssetMenu]
    public class ClassData : ScriptableObject
    {
        

        #region Public Member
        //-------------- |
        //Fenetre Classes (A mettre dans un autre script, la selection ne dois pas figurer dans chaque classe)
        //public string m_nameTitle;
        //public int m_maxChange;
        //-------------- |

        //Fenetre Parametres généraux 
        public string m_className;
        public int m_xpCourbBaseValue = 30;
        public int m_xpCourbSupValue = 20;
        public int m_xpCourbAcceleratorA = 30;
        public int m_xpCourbAcceleratorB = 30;

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


        #region Unity API
           public void OnDisable()
                {
            
                }
        #endregion

        #region Main Methods



        #endregion

        #region Utils
        #endregion

        #region Private and Protected Members
        #endregion
    }
}
