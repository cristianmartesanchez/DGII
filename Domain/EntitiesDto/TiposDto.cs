﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.Domain.EntitiesDto
{
    public class TiposDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
