using System;
using System.Linq;
using static UnityEngine.EventSystems.EventTrigger;
using UnityEngine;

namespace GameAsset.Runtime
{
    [Serializable]
    public class GeneralParametersClass : GeneralParameters
    {
        #region Public Members

        public int[] m_experienceCurve;

        public int m_baseValue;
        public int m_addedValue;

        public int m_accelerationA;
        public int m_accelerationB;

        #endregion

        #region Main Methods

        public void SetCurveSize(int size)
        {
            m_experienceCurve = new int[size];
        }

        public void GenerateCurve()
        {
            for (int i = 1; i < m_experienceCurve.Length; i++)
            {
                // TODO Complete this
            }
    }

    #endregion
    }
}