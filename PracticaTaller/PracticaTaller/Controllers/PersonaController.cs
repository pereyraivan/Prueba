using PracticaTaller.Models.AccesoDatos;
using PracticaTaller.Models.LogicaNegocio;
using PracticaTaller.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaTaller.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        GestorPersona gestor = new GestorPersona();
        public ActionResult Crear()
        {
            return View(new PersonaViewModel());
        }
        public ActionResult GuardarPersona(PersonaViewModel persona)
        {
            var per = new Persona
            {
                Apellido = persona.Apellido,
                Nombre = persona.Nombre,
                Dni = persona.Dni,

            };
            gestor.GuardarPersona(per);
            return null;
        }
    }
}