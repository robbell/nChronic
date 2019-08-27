using System.Collections.Generic;

namespace Chronic.Core.Handlers
{
    public interface IHandler
    {
        Span Handle(IList<Token> tokens, Options options);
    }



}