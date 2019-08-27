using System;
using System.Collections.Generic;
using Chronic.Core.System;
using Chronic.Core.Tags;

namespace Chronic.Core.Handlers
{
    public class SySmHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var year = (int)tokens[0].GetTag<ScalarYear>().Value;
            var month = tokens[1].GetTag<ScalarMonth>().Value;

            try
            {
                var start = Time.New(year, month);
                return new Span(start, start.AddMonths(1));
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}