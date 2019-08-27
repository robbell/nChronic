namespace Chronic.Core.Tags.Repeaters
{
    public abstract class RepeaterUnit : Repeater<UnitName>
    {
        protected RepeaterUnit(UnitName type)
            : base(type)
        {
        }
    }
}
