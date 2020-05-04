using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using graphQlServer.Repositories;

namespace graphQlServer.Types
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IArtistRepository artistRepository)
        {
            Field<ListGraphType<ArtistType>>("artists", resolve: context => artistRepository.GetAllArtists());

            Field<ListGraphType<ArtistType>>("filteredArtists",
                arguments: new QueryArguments
                {
                    new QueryArgument<StringGraphType> {Name = "name"}
                },
                resolve: context =>
                {
                    string name = context.GetArgument<string>("name");
                    return artistRepository.GetAllArtists().Where(_ => _.Name.ToLower() == name.ToLower()).ToList();
                });
        }
    }
}
