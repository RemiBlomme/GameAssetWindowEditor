using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class ParameterCurve
    {
        #region Public Members

        public HPMax m_hPMax;
        public MPMax m_mPMax;
        public Attack m_atack;
        public Defense m_defense;
        public AttackM m_attackM;
        public DefenseM m_defenseM;
        public Agility m_agility;
        public Luck m_luck;

        #endregion
    }
}
