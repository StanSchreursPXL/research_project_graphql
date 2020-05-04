using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using graphQlServer.Models;
using graphQlServer.Repositories;

namespace graphQlServer.Types
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation(IArtistRepository artistRepository)
        {
            Field<ArtistType>(
                "addArtist", 
                arguments: new QueryArguments
                {
                    new QueryArgument<InputArtistType>(){ Name = "artist" }
                },
                resolve: context =>
                {
                    var artist = context.GetArgument<Artist>("artist");
                    return artistRepository.AddArtist(artist);
                }
                );
        }
    }
}
