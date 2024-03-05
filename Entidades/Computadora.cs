using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora
    {


        public enum EstadoComputadora { actualizada, error, rota, soporteTecnico, freezada }
        public enum CondicionComputadora { hardware, software, red }


        //ID de la computadora
        public int ComputadoraId { get; set; }
        public int LaboratorioId { get; set; }
        public int TicketId { get; set; }

        public string CodigoComputadora { get; set; }
        public string DescripcionComputadora { get; set; }
        public Laboratorio laboratorio { get; set; }
        public Ticket Ticket { get; set; } //una computadora tiene un ticket
        public EstadoComputadora estado { get; set; }
        public CondicionComputadora condicion { get; set; }

    }
}
