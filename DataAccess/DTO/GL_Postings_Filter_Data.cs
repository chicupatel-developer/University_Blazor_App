﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DTO
{
    public class GL_Postings_Filter_Data
    {
        public string Source { get; set; }
        public DateTime? FromTRDate { get; set; }
        public DateTime? ToTRDate { get; set; }
    }
}
