using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore20190217a.Models
{
    public class MvcMusicStore20190217aContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcMusicStore20190217aContext() : base("name=MvcMusicStore20190217aContext")
        {
        }

        public System.Data.Entity.DbSet<MvcMusicStore20190217a.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MvcMusicStore20190217a.Models.Review> Reviews { get; set; }
    }
}
