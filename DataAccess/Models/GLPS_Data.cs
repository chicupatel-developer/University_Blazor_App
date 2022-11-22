using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Models
{
    public class GLPS_Data
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GLPS_DataId { get; set; }

        [Required]
        [ForeignKey(nameof(GL_Posting))]
        public int PostingsId { get; set; }
        public GL_Posting GL_Posting { get; set; }

        public int POS { get; set; }
        public string GLACCTNO { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
