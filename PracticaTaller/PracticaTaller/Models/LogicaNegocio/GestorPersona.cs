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
        public void GuardarPersona(Persona persona)
        {
            repo.GuardarPersona(persona);
        }
    }
}