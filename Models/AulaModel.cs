using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class AulaModel
    {
        public int Id { get; set; }
        public int Tittle { get; set; }
        public int Content { get; set; }
        public int Imagem { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}