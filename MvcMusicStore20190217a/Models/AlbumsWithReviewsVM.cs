using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore20190217a.Models
{
    public class AlbumsWithReviewsVM
    {
        public string AlbumTitle { get; set; }

        public List<string> ReviewContent { get; set; }
    }
}