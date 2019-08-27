namespace Chronic.Core.Tags.Repeaters
{
    public class RepeaterFortnight : RepeaterUnit
    {
        public RepeaterFortnight()
            : base(UnitName.Fortnight)
        {

        }
        public override int GetWidth()
        {
            throw new global::System.NotImplementedException();
        }

        protected override Span NextSpan(Pointer.Type pointer)
        {
            throw new global::System.NotImplementedException();
        }

        protected override Span CurrentSpan(Pointer.Type pointer)
        {
            throw new global::System.NotImplementedException();
        }

        public override Span GetOffset(Span span, int amount, Pointer.Type pointer)
        {
            throw new global::System.NotImplementedException();
        }
    }
}