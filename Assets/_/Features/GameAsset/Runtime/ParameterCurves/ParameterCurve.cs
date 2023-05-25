using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class ParameterCurve
    {
        #region Public Members

        public CurveHPMax m_hPMax;
        public CurveMPMax m_mPMax;
        public CurveAttack m_attack;
        public CurveDefense m_defense;
        public CurveMagicAttack m_magicAttack;
        public CurveMagicDefense m_magicDefense;
        public CurveAgility m_agility;
        public CurveLuck m_luck;

        #endregion
    }
}
