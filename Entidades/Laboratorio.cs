﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Laboratorio
    {

        public int LaboratorioId { get; set; }

        public int SedeId { get; set; }
        public string NombreLaboratorio { get; set; }
        public int CapacidadMaxima { get; set; }
        public Sede sede { get; set; } //un laboratorio pertenece a una sede

        public ICollection<Computadora> Computadoras { get; set; } = new List<Computadora>(); // un laboratorio tiene de 0 a muchas computadoras
    }

}