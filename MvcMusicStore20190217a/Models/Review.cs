using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore20190217a.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        //new added
        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        [Display(Name = "Contents-评论内容")]
        public string Contents { get; set; }

        [Required()]
        [Display(Name ="电子邮箱")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}