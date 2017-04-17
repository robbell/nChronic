using Chronic.Core.Tags;

namespace Chronic.Core.Tests.Utils
{
    class DummyTag1 : Tag<string>
    {
        public DummyTag1(string value) : base(value)
        {
            
        }
    }

    class DummyTag2 : Tag<string>
    {
        public DummyTag2(string value)
            : base(value)
        {

        }
    }
}
