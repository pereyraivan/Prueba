using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models.AccesoDatos
{
    public class RepositorioPersona
    {
        TALLEREntities BaseDatos = new TALLEREntities();

        public void GuardarPersona(Persona persona)
        {
            BaseDatos.Persona.Add(persona);
            BaseDatos.SaveChanges();
        }
        //public void Modificar(int dni)
        //{
        //    var modificarPersona = BaseDatos.Persona.FirstOrDefault(x => x.Dni = dni);
        //}
    }
}