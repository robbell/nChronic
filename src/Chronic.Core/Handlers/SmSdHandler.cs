using System.Collections.Generic;
using Chronic.Core.System;
using Chronic.Core.Tags;

namespace Chronic.Core.Handlers
{
    public class SmSdHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var month = (int)tokens[0].GetTag<ScalarMonth>().Value;
            var day = (int)tokens[1].GetTag<ScalarDay>().Value;
            var now = options.Clock();
            var start = Time.New(now.Year, month, day);
            var end = start.AddMonths(1);
            return new Span(start, end);
        }
    }
}