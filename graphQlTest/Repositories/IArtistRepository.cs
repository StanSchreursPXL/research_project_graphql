using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphQlServer.Models;

namespace graphQlServer.Repositories
{
    public interface IArtistRepository
    {
        IList<Artist> GetAllArtists();

        void UpdateArtist(Artist existingArtist);

        Artist AddArtist(Artist newArtist);
    }
}
