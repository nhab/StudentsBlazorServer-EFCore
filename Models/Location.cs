﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorForms.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add city")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please add state")]
        [StringLength(50)]
        public string State { get; set; }

        public IEnumerable<Student> Student_R { get; set; }
    }
}
