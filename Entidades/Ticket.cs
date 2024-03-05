using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticket
    {
        public enum Categoria { hardware, software, red }
        public enum Tipo { servicio, incidencia }
        public enum Estado { abierto, progreso, resuelto }
        public enum Urgencia { critica, alta, media, baja }

        public int TicketId { get; set; }
        public int ComputadoraId { get; set; }
        public string CodigoComputadora { get; set; } 
        public string AgenteAsignado { get; set; }
        public string? DescripcionTicket { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Computadora computadora { get; set; } //un ticket pertenece a una computadora
        public Categoria categoria { get; set; }
        public Urgencia urgencia { get; set; }
        public Estado estado { get; set; }
        public Tipo tipo { get; set; }

       
   
        

    }
}
