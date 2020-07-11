using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int Pages { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public bool FinishedReading { get; set; }
    }
}
