using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuicStore2.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}" , ApplyFormatInEditMode = true)]
        public string YearReleased { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public bool Feature { get; set; }
        [Display(Name ="Featured Artist")]
        public string FeaturedArtist { get; set; }
        public string Genre { get; set; }
        [Display(Name = "Album Cover")]
        public string ImagePath { get; set; }
        
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
