namespace GameAsset.Runtime
{
    public class EffectsParameters
    {
        public enum EffectsParametersActions
        {
            AddBuff,
            AddDenuff,
            RemoveBuff,
            RemoveDebuff,
        }

        public EffectsParametersActions m_action;
        public ParametersEnum m_parameter;
        public int m_numberOfRounds;
    }
}