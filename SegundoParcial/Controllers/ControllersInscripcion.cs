using Microsoft.EntityFrameworkCore;
using SegundoParcial.Data;
using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SegundoParcial.Controllers
{
    public class ControllersInscripcion
    {
        public bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Inscripciones.Add(inscripciones);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(inscripciones).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;

        }
        public Inscripciones Buscar(int id)
        {
            Inscripciones inscripciones = new Inscripciones();
            Contexto contexto = new Contexto();

            try
            {
                inscripciones = contexto.Inscripciones.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripciones;

        }
        
        public bool Eliminar(int id)
        {
            Inscripciones inscripciones = new Inscripciones();
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var eliminar = contexto.Inscripciones.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;

        }

        public List<Inscripciones> GetList(Expression<Func<Inscripciones,bool>>expression)
        {
            List<Inscripciones> listaInscripciones = new List<Inscripciones>();
            Contexto contexto = new Contexto();


            try
            {
                listaInscripciones = contexto.Inscripciones.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return listaInscripciones;

        }


    }
}
