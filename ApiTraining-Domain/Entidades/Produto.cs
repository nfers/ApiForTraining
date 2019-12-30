﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiTraining.Domain.Entidades
{
    public class Produto : Base
    {
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
