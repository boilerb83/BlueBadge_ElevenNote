using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Display(Name = "NoteID")]

        [Required]
        public Guid OwnerId { get; set; }
        [Display(Name = "Guid")]

        [Required]
        public string Title { get; set; }
        [Display(Name = "Title")]

        [Required]
        public string Content { get; set; }
        [Display(Name = "Content")]

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
