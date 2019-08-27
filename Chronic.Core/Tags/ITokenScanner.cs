using System.Collections.Generic;

namespace Chronic.Core.Tags
{
    public interface ITokenScanner
    {
        IList<Token> Scan(IList<Token> tokens, Options options);
    }
}