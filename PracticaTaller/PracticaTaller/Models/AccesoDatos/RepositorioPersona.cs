using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioPersona
    {
        TALLEREntities BaseDatos = new TALLEREntities();

        public List<Persona> Listar()
        {
            return BaseDatos.Persona.ToList();
        }
        public void GuardarPersona(Persona persona)
        {
            BaseDatos.Persona.Add(persona);
            BaseDatos.SaveChanges();
        }
        public Persona obtenerPorId(int id)
        {
            var personaObtenida = BaseDatos.Persona.FirstOrDefault(x => x.Codigo == id);
            return personaObtenida;
        }
        public void Modificar(Persona persona)
        {
            var modificarPersona = BaseDatos.Persona.FirstOrDefault(x => x.Codigo == persona.Codigo);
           
            modificarPersona.Nombre = persona.Nombre;
            modificarPersona.Apellido = persona.Apellido;
            modificarPersona.Dni = persona.Dni;
            BaseDatos.SaveChanges();

        }
        
    }
}