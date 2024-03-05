using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSede
    {
        Context context;

        private ControladoraSede()
        {
            context = new Context();
        }

        private static ControladoraSede instancia;

        public static ControladoraSede Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraSede();
                return instancia;
            }
        }

        //recupero todas las sedes dando una excepcion si no se puede con un mensaje de error
        public ReadOnlyCollection<Sede> RecuperarSedes()
        {
            try
            {
                return context.Sedes.ToList().AsReadOnly();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string AgregarSede(Sede sede)
        {
            try
            {
                var listaSedes = context.Sedes.ToList().AsReadOnly();
                var sedeEncontrada = listaSedes.FirstOrDefault(x => x.NombreSede.ToLower() == sede.NombreSede.ToLower()); //busco la sede por nombre en la lista de sedes para evitar que se repitan
                if (sedeEncontrada == null) //si no se encuentra la sede, la agrego
                {
                    context.Sedes.Add(sede);
                    int insertados = context.SaveChanges(); //guardo los cambios
                    if (insertados > 0) //insertados es la cantidad de registros afectados
                    {
                        return $"La sede se agregó correctamente";
                    }
                    else return $"La sede no se ha podido agregar";
                }
                else
                {
                    return $"La sede ya existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string ModificarSede(Sede sede)
        {
            //Modifico la sede, busco por id y nombre, actualizo los campos y guardo los cambios en la base de datos
            try
            {
                var listaSedes = context.Sedes.ToList().AsReadOnly();
                var sedeEncontrada = listaSedes.FirstOrDefault(s => s.SedeId == sede.SedeId || s.NombreSede.ToLower() == sede.NombreSede.ToLower());
                if (sedeEncontrada != null)
                {
                    sedeEncontrada.NombreSede = sede.NombreSede;
                    sedeEncontrada.DireccionSede = sede.DireccionSede;
                    int insertados = context.SaveChanges();
                    if (insertados > 0)
                    {
                        return $"La sede se modificó correctamente";
                    }
                    else return $"La sede no se ha podido modificar";
                }
                else
                {
                    return $"La sede no existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }

        }

        public string EliminarSede(Sede sede)
        {
            try
            {
                var listaSedes = context.Sedes.ToList().AsReadOnly();
                var sedeEncontrada = listaSedes.FirstOrDefault(s => s.NombreSede.ToLower() == sede.NombreSede.ToLower());
                if (sedeEncontrada != null) //si la sede existe, la elimino
                {
                    context.Sedes.Remove(sede);
                    int insertados = context.SaveChanges();
                    if (insertados > 0)
                    {
                        return $"La sede se eliminó correctamente";
                    }
                    else return $"La sede no se ha podido eliminar";
                }
                else
                {
                    return $"La sede no existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string BuscarSede(Sede sede)
        {
            try
            {
                var listaSedes = context.Sedes.ToList().AsReadOnly();
                var sedeEncontrada = listaSedes.FirstOrDefault(s => s.NombreSede.ToLower() == sede.NombreSede.ToLower() || s.SedeId == sede.SedeId);
                if (sedeEncontrada != null)
                {
                    return $"La sede {sedeEncontrada.NombreSede} se ha encontrado";
                }
                else
                {
                    return $"La sede no se ha encontrado";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

    }
}
