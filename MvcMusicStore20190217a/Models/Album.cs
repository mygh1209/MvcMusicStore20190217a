using System.Collections.Generic;

namespace MvcMusicStore20190217a.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        //new added
        //public int ReviewID { get; set; }

        public virtual List<Review> Review { get; set; }

    }
}