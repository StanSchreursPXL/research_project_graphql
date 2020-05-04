using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphQlServer.Data;
using graphQlServer.Models;

namespace graphQlServer.Repositories
{
    public class ArtistRepository : IArtistRepository
    {

        private readonly MvcMusicStoreContext _mvcMusicStoreContext;

        public ArtistRepository(MvcMusicStoreContext context)
        {
            _mvcMusicStoreContext = context;
        }
        public IList<Artist> GetAllArtists()
        {
            return _mvcMusicStoreContext.Artist.ToList();
        }

        public void UpdateArtist(Artist existingArtist)
        {
            throw new NotImplementedException();
        }

        public Artist AddArtist(Artist newArtist)
        {
            _mvcMusicStoreContext.Artist.Add(newArtist);
            _mvcMusicStoreContext.SaveChanges();
            return newArtist;
        }
    }
}
