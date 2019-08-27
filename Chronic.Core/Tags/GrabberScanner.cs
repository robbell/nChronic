using System.Collections.Generic;
using Chronic.Core.System;

namespace Chronic.Core.Tags
{
    public class GrabberScanner : ITokenScanner
    {
        static readonly dynamic[] _matches = new dynamic[]
            {
                new { Pattern = "last", Tag = new Grabber(Grabber.Type.Last) },
                new { Pattern = "next", Tag = new Grabber(Grabber.Type.Next) },
                new { Pattern = "this", Tag = new Grabber(Grabber.Type.This) }
            };

        public IList<Token> Scan(IList<Token> tokens, Options options)
        {
            tokens.ForEach(ApplyGrabberTags);
            return tokens;
        }

        static void ApplyGrabberTags(Token token)
        {
            foreach (var match in _matches)
            {
                if (match.Pattern == token.Value)
                {
                    token.Tag(match.Tag);
                }
            }
        }
    }
}