using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using graphQlServer.Models;

namespace graphQlServer.Types
{
    public class ArtistType : ObjectGraphType<Artist>
    {
        public ArtistType()
        {
            Field(_ => _.ArtistId);
            Field(_ => _.Name);
        }
    }
}
