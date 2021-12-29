﻿namespace SurveyAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Answer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Reply { get; set; }
        public Question Question { get; set; }
    }
}
