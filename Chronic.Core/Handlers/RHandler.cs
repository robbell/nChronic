using System.Collections.Generic;
using Chronic.Core.System;

namespace Chronic.Core.Handlers
{
    public class RHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var ddTokens = tokens.DealiasAndDisambiguateTimes(options);
            return ddTokens.GetAnchor(options);
        }
    }
}