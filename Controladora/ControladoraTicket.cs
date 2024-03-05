using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTicket
    {
        Context context;

        private ControladoraTicket()
        {
            context = new Context();
        }

        private static ControladoraTicket instancia;

        public static ControladoraTicket Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraTicket();
                return instancia;
            }
        }

        //metodo para agregar un ticket
        public string AgregarTicket(Ticket ticket)
        {
            try
            {
                context.Tickets.Add(ticket);
                int insertados = context.SaveChanges();
                if (insertados > 0)
                {
                    return $"El ticket se agregó correctamente";
                }
                else return $"El ticket no se ha podido agregar";
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        //metodo para mdificar un ticket
        public string ModificarTicket(Ticket ticket)
        {
            try
            {
                context.Tickets.Update(ticket);
                int modificados = context.SaveChanges();
                if (modificados > 0)
                {
                    return $"El ticket se modificó correctamente";
                }
                else return $"El ticket no se ha podido modificar";
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        //metodo para eliminar un ticket
        public string EliminarTicket(Ticket ticket)
        {
            try
            {
                context.Tickets.Remove(ticket);
                int eliminados = context.SaveChanges();
                if (eliminados > 0)
                {
                    return $"El ticket se eliminó correctamente";
                }
                else return $"El ticket no se ha podido eliminar";
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        //asignar un ticket a una computadora por codigo de computadora, se busca en la lista de la clase computadora si existe el codigo de computadora y si existe se asigna el ticket a esa computadora 

    }
}
