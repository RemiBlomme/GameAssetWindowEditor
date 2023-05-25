using System;

namespace GameAsset.Runtime
{
    [Serializable]
    public class Other : TraitsParent
    {
        public enum SpecialFlags
        {
            AutoBattle,
            Guard,
            Substitute,
            PreserveTP
        }

        public enum CollapseEffects
        {
            Normal,
            Boss,
            Instant,
            NoDisappear
        }

        public enum PartyAbilities
        {
            EncounterHalf,
            EncounterNone,
            CancelSurprise,
            RaisePreemptive,
            GoldDouble,
            DropItemDouble
        }

        #region Public Members

        //Action Time
        public float m_actionTimes;

        //Special Flag
        public SpecialFlags m_specialFlag;

        //Collapse Effects
        public CollapseEffects m_collapseEffect;

        //Party Ability
        public PartyAbilities m_partyAbility;

        #endregion

    }
}
