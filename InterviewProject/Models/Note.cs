using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is requiered.")]
        [DisplayName("Text")]
        [Column(TypeName = "nvarchar(256)")]
        public string Text { get; set; }

        public string TextTransalted { get; set; }

        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

    }
}
