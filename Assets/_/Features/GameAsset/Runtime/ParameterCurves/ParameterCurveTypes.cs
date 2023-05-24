using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameAsset.Runtime
{
    public class ParameterCurveTypes
    {

        #region Public Members

        public ParameterCurve m_hp;
        public ParameterCurve m_mp;
        public ParameterCurve m_attack;
        public ParameterCurve m_defense;
        public ParameterCurve m_attackM;
        public ParameterCurve m_defenseM;
        public ParameterCurve m_agility;
        public ParameterCurve m_luck;

        public ParameterCurveTypes(ParameterCurve hp, ParameterCurve mp,
                                ParameterCurve attack, ParameterCurve defense,
                                ParameterCurve attackM, ParameterCurve defenseM,
                                ParameterCurve agility, ParameterCurve luck)
        {
            m_hp = hp;
            m_mp = mp;
            m_attack = attack;
            m_defense = defense;
            m_attackM = attackM;
            m_defenseM = defenseM;
            m_agility = agility;
            m_luck = luck;
        }

        #endregion

    }
}
