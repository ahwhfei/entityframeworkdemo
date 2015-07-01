using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class ArtistDetails
    {
        [Key()]
        [ForeignKey("Artist")]
        public int ArtistId { get; set; }

        public string Bio { get; set; }
        public virtual Artist Artist { get; set; }
    }
}