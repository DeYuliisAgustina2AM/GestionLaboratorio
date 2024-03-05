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
    public class ControladoraComputadora
    {
        Context context;

        private ControladoraComputadora()
        {
            context = new Context();
        }

        private static ControladoraComputadora instancia;
        public static ControladoraComputadora Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraComputadora();
                return instancia;
            }
        }

        public ReadOnlyCollection<Computadora> RecuperarComputadoras()
        {
            try
            {
                return context.Computadoras.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar las computadoras", ex);
            }
        }


        //meotodo para agregar computadora a un laboratorio, se debe verificar que el laboratorio exista y que no supere la capacidad maxina, no se debe repitir el codigo de computadora y que la computadora no exista en el mismo laboratorio
        public string AgregarComputadora(Computadora computadora)
        {
            try
            {
                var listaLaboratorios = context.Laboratorios.ToList().AsReadOnly();
                var laboratorioEncontrado = listaLaboratorios.FirstOrDefault(l => l.LaboratorioId == computadora.LaboratorioId); //busco el laboratorio por id para verificar que exista
                if (laboratorioEncontrado != null)
                {
                    if (laboratorioEncontrado.Computadoras.Count < laboratorioEncontrado.CapacidadMaxima) //verifico que no se supere la capacidad maxima
                    {
                        var listaComputadoras = context.Computadoras.ToList().AsReadOnly(); //recupero todas las computadoras para verificar que no se repita el codigo de computadora
                        var computadoraEncontrada = listaComputadoras.FirstOrDefault(c => c.CodigoComputadora.ToLower() == computadora.CodigoComputadora.ToLower() && c.LaboratorioId == computadora.LaboratorioId); //busco la computadora por codigo y laboratorio para verificar que no se repita
                        if (computadoraEncontrada == null)
                        {
                            context.Computadoras.Add(computadora);//si no se encuentra la computadora, la agrego al laboratorio seleccionado

                            int insertados = context.SaveChanges();
                            if (insertados > 0)
                            {
                                return $"La computadora se agregó correctamente";
                            }
                            else return $"La computadora no se ha podido agregar";
                        }
                        else
                        {
                            return $"La computadora ya existe";
                        }
                    }
                    else
                    {
                        return $"Capacidad superada, la capacidad maxima es de {laboratorioEncontrado.CapacidadMaxima} computadoras";
                    }
                }
                else
                {
                    return $"El laboratorio no existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }


        public string ModificarComputadora(Computadora computadora)
        {
            try
            {
                var listaLaboratorios = context.Laboratorios.ToList().AsReadOnly();
                var laboratorioEncontrado = listaLaboratorios.FirstOrDefault(l => l.LaboratorioId == computadora.LaboratorioId); //busco el laboratorio por id para verificar que exista
                if (laboratorioEncontrado != null)
                {
                    if (laboratorioEncontrado.Computadoras.Count < laboratorioEncontrado.CapacidadMaxima)
                    {
                        var listaComputadoras = context.Computadoras.ToList().AsReadOnly();
                        var computadoraEncontrada = listaComputadoras.FirstOrDefault(c => c.CodigoComputadora.ToLower() == computadora.CodigoComputadora.ToLower() && c.LaboratorioId == computadora.LaboratorioId); //busco la computadora por codigo y laboratorio para verificar que no se repita
                        if (computadoraEncontrada == null)
                        {
                            context.Computadoras.Update(computadora);
                            int insertados = context.SaveChanges();
                            if (insertados > 0)
                            {
                                return $"La computadora se modificó correctamente";
                            }
                            else return $"La computadora no se ha podido modificar";
                        }
                        else
                        {
                            return $"La computadora ya existe";
                        }
                    }
                    else
                    {
                        return $"Capacidad superada, la capacidad maxima es de {laboratorioEncontrado.CapacidadMaxima} computadoras";
                    }
                }

                {
                    return $"El laboratorio no existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }

        public string EliminarComputadora(Computadora computadora)
        {
            try
            {
                var listaComputadoras = context.Computadoras.ToList().AsReadOnly();
                var computadoraEncontrada = listaComputadoras.FirstOrDefault(c => c.CodigoComputadora.ToLower() == computadora.CodigoComputadora.ToLower() && c.LaboratorioId == computadora.LaboratorioId); //busco la computadora por codigo y laboratorio para verificar que exista
                if (computadoraEncontrada != null) //si la computadora existe, la elimino
                {
                    context.Computadoras.Remove(computadora);
                    int insertados = context.SaveChanges();
                    if (insertados > 0)
                    {
                        return $"La computadora se eliminó correctamente";
                    }
                    else return $"La computadora no se ha podido eliminar";
                }
                else
                {
                    return $"La computadora no existe";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }


        //metodo para buscar computadora por codigo y laboratorio, hacelo con la clase Computadora como parametro, devolver mensaje de no se encontro la computadora y si se encontro , devolver la computadora

        public string BuscarComputadora(Computadora computadora)
        {
            try
            {
                var listaComputadoras = context.Computadoras.ToList().AsReadOnly();
                var computadoraEncontrada = listaComputadoras.FirstOrDefault(c => c.CodigoComputadora.ToLower() == computadora.CodigoComputadora.ToLower() && c.LaboratorioId == computadora.LaboratorioId); //busco la computadora por codigo y laboratorio para verificar que exista
                if (computadoraEncontrada != null) //si la computadora existe, la devuelvo
                {
                    return $"La computadora se encontró";
                }
                else
                {
                    return $"La computadora no se ha encontrado";
                }
            }
            catch (Exception)
            {
                return "Error desconocido";
            }
        }


    }
}
