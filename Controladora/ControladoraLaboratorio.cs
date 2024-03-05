﻿using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLaboratorio
    {
        Context context;

        private ControladoraLaboratorio()
        {
            context = new Context();
        }

        private static ControladoraLaboratorio instancia;

        public static ControladoraLaboratorio Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraLaboratorio();
                return instancia;
            }
        }

        public string AgregarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                var listaLaboratorios = context.Laboratorios.ToList().AsReadOnly();
                var laboratorioEncontrado = listaLaboratorios.FirstOrDefault(l => l.NombreLaboratorio.ToLower() == laboratorio.NombreLaboratorio.ToLower()); //busco el laboratorio por nombre en la lista de laboratorios para evitar que se repitan
                if (laboratorioEncontrado == null) //si no se encuentra el laboratorio, lo agrego
                {
                    context.Laboratorios.Add(laboratorio);
                    int insertados = context.SaveChanges(); //guardo los cambios
                    if (insertados > 0) //insertados es la cantidad de registros afectados
                    {
                        return $"El laboratorio se agregó correctamente";
                    }
                    else return $"El laboratorio no se ha podido agregar";
                }
                else return $"El laboratorio ya existe";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el laboratorio", ex);
            }
        }

        //modificar laboratorio, busco el laboratorio por id y por nombre, si lo encuentro, modifico los datos y guardo los cambios
        public string ModificarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                var laboratorioEncontrado = context.Laboratorios.FirstOrDefault(l => l.LaboratorioId == laboratorio.LaboratorioId && l.NombreLaboratorio.ToLower() == laboratorio.NombreLaboratorio.ToLower());
                if (laboratorioEncontrado != null)
                {
                    laboratorioEncontrado.CapacidadMaxima = laboratorio.CapacidadMaxima;
                    laboratorioEncontrado.NombreLaboratorio = laboratorio.NombreLaboratorio;
                    int modificados = context.SaveChanges();
                    if (modificados > 0)
                    {
                        return $"El laboratorio se modificó correctamente";
                    }
                    else return $"El laboratorio no se ha podido modificar";
                }
                else return $"El laboratorio no existe";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el laboratorio", ex);
            }
        }

        //eliminar laboratorio, busco el laboratorio por id y por nombre, si lo encuentro, lo elimino y guardo los cambios
        public string EliminarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                var laboratorioEncontrado = context.Laboratorios.FirstOrDefault(l => l.LaboratorioId == laboratorio.LaboratorioId && l.NombreLaboratorio.ToLower() == laboratorio.NombreLaboratorio.ToLower());
                if (laboratorioEncontrado != null)
                {
                    context.Laboratorios.Remove(laboratorioEncontrado);
                    int eliminados = context.SaveChanges();
                    if (eliminados > 0)
                    {
                        return $"El laboratorio se eliminó correctamente";
                    }
                    else return $"El laboratorio no se ha podido eliminar";
                }
                else return $"El laboratorio no existe";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el laboratorio", ex);
            }
        }

        //buscar laboratorio por id y por nombre, usar try catch con mensajes de laboratorio encontrado y laboratorio no encontrado

        public string BuscarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                var laboratorioEncontrado = context.Laboratorios.FirstOrDefault(l => l.LaboratorioId == laboratorio.LaboratorioId && l.NombreLaboratorio.ToLower() == laboratorio.NombreLaboratorio.ToLower());
                if (laboratorioEncontrado != null)
                {
                    return $"Laboratorio encontrado: {laboratorioEncontrado.NombreLaboratorio}";
                }
                else
                {
                    return "Laboratorio no encontrado";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el laboratorio", ex);
            }
        }
    }
}