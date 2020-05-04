using System;
using System.Collections.Generic;

namespace graphQlServer.Models
{
    public partial class Artist
    {

        //TODO: commentaar stukken terug inschakelen
        // public Artist()
        // {
        //     Album = new HashSet<Album>();
        // }

        public int ArtistId { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Album> Album { get; set; }
    }
}
