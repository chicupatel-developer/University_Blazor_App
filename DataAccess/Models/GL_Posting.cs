using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class GL_Posting
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostingsId { get; set; }
        
        [MaxLength(2), MinLength(2)]
        public string Source { get; set; }
        public string RefNo { get; set; }
        public DateTime TRDate { get; set; }

        public ICollection<GLPS_Data> GLPSDatas { get; set; }
    }
}
