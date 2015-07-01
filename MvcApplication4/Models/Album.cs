using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist{ get; set; }
    }
}