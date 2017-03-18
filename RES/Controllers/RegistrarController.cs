using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication.Controllers
{
    public class RegistrarController : Controller
    {
        // 
        // GET: /Index/

        public IActionResult Index()
        {
            ViewData["HoraIngreso"] = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(string txtID, string txtNombre, string txtApellido, string txtDateTime, string txtMotivo)
        {
            using (var context = new DBContext())
            {
                var entrada = new entradas { Ent_Ingreso = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")),
                                             Ent_MotivoVisita = txtMotivo,
                                             Ent_IDVisitante = Convert.ToInt32(txtID),
                                             Ent_NombreVisitante = txtNombre,
                                             Ent_ApellidoVisitante = txtApellido };
                context.Entradas.Add(entrada);

                System.Console.WriteLine("aca");
                context.SaveChanges();
                System.Console.WriteLine("aqui");
            }
            return RedirectToAction("Index");
        }
    }
}