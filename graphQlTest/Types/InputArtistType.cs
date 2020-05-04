using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using graphQlServer.Models;

namespace graphQlServer.Types
{
    public class InputArtistType : InputObjectGraphType<Artist>
    {
        public InputArtistType()
        {
            Name = "InputArtistType";
            Field(_ => _.ArtistId);
            Field(_ => _.Name);
        }
    }
}
