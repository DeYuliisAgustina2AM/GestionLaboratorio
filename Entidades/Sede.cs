using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sede
    {
        public int SedeId { get; set; } 

        public string DireccionSede { get; set; }
        public string NombreSede { get; set; }
      
        public ICollection<Laboratorio> Laboratorios { get; set; } = new List<Laboratorio>(); //una sede tiene de 0 a muchos laboratorios
        public static List<Sede> Sedes { get; set; } = new List<Sede>(); // una sede tiene de 0 a muchas sede

    }
}
