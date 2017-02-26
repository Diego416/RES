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
    public class RegistrosController : Controller
    {
        // 
        // GET: /Index/

        public IActionResult Index()
        {
            ViewBag.HtmlStr = "";
            using (var context = new DBContext())
            {
                foreach (var entrada in context.Entradas)
                {
                    ViewBag.HtmlStr +="<tr><td>"+entrada.entradasId+
                                    "</td><td>"+entrada.Ent_Ingreso+
                                    "</td><td>"+entrada.Ent_MotivoVisita+
                                    "</td><td>"+entrada.Ent_IDVisitante+
                                    "</td><td>"+entrada.Ent_NombreVisitante+
                                    "</td><td>"+entrada.Ent_ApellidoVisitante+"</td></tr>";
                }
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Filtrar(string txtID)
        {
            ViewBag.HtmlStr = "";
            using (var context = new DBContext())
            {
                foreach (var entrada in context.Entradas)
                {
                    if(entrada.Ent_IDVisitante == Convert.ToInt32(txtID))
                        ViewBag.HtmlStr +="<tr><td>"+entrada.entradasId+
                                        "</td><td>"+entrada.Ent_Ingreso+
                                        "</td><td>"+entrada.Ent_MotivoVisita+
                                        "</td><td>"+entrada.Ent_IDVisitante+
                                        "</td><td>"+entrada.Ent_NombreVisitante+
                                        "</td><td>"+entrada.Ent_ApellidoVisitante+"</td></tr>";
                }
            }

            return View("~/Views/Registros/Index.cshtml");
        }
    }
}