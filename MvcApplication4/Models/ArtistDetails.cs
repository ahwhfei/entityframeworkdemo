using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class ArtistDetails
    {
        [Key()]
        public int ArtistID { get; set; }

        public string Bio { get; set; }
        public vitual Artist Artist { get; set; }
    }
}