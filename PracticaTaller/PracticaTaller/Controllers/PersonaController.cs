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
        public ActionResult Listar()
        {
            var listaPersona = gestor.Listar();
            return View(listaPersona);
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
            return RedirectToAction("Listar");
        }

        public ActionResult Modificar(int id)

        {
            var personaParaModificar = gestor.obtenerPorId(id);
            return View(personaParaModificar);
        }
        public ActionResult GuardarModificacion(Persona persona)
        {
            gestor.Modificar(persona);
            return RedirectToAction("Listar");
                 

        }
    }
}