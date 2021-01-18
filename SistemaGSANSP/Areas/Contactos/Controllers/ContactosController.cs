using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaGSANSP.Areas.Contactos.Models;
using SistemaGSANSP.Controllers;
using SistemaGSANSP.Data;
using SistemaGSANSP.Library;
using SistemaGSANSP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGSANSP.Areas.Contactos.Controllers
{
    [Area("Contactos")]
    [Authorize]
    public class ContactosController : Controller
    {
        private TContacto _contacto;
        private LContactos _lcontacto;
        private SignInManager<IdentityUser> _signInManager;
        private static DataPaginador<TContacto> models;

        public ContactosController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _lcontacto = new LContactos(context);
        }

        public IActionResult Contacto()
        {
            if (_signInManager.IsSignedIn(User))
            {
                models = new DataPaginador<TContacto>
                {
                    Input = new TContacto()
                };
                return View(models);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }            
        }

        [HttpPost]
        public String GetContactos(DataPaginador<TContacto> model)
        {
            if(model.Input.nombres != null && model.Input.apellidos != null)
            {
                return "Hola";
            }
            else
            {
                return "Llene los campos requeridos";
            }
        }
    }
}
