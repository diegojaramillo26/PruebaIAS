﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIAS.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int IdNumber { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
