﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Satelites
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Distance  { get; set; }
        [Required]
        public string[] Message { get; set; }
    }
}