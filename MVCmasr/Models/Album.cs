using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MVCmasr.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Album Name")]
        [MinLength(2)]
        [MaxLength(int.MaxValue)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        [Range(0, 20)]
        [Required]
        public int SongsNumber { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType("money")]
        public decimal Price { get; set; }

        [Range(0, 500)]
        public int CountInStock { get; set; }
        public bool IsAvailable => CountInStock == 0;
        public string Image { get; set; }
        
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        public virtual ICollection<Song> Songs { get; set; } = new HashSet<Song>();
        public virtual ICollection<Artist> Artists { get; set; } = new HashSet<Artist>();
        public virtual ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();
        //public virtual ICollection<AlbumGenre> AlbumGenre { get; set; } = new HashSet<AlbumGenre>();
        


    }
}
