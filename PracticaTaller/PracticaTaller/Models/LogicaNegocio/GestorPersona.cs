using PracticaTaller.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.LogicaNegocio
{
    public class GestorPersona
    {

        RepositorioPersona repo = new RepositorioPersona();
        public List<Persona> Listar()
        {
            return repo.Listar();
        }
        public void GuardarPersona(Persona persona)
        {
            repo.GuardarPersona(persona);
        }
        public Persona obtenerPorId(int id)
        {
           return repo.obtenerPorId(id);
        }
        
        public void Modificar (Persona persona)
        {
            repo.Modificar(persona);
        }
            
    }
}