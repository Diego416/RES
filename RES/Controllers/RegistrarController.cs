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
        const string SessionCode = "_Code";
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
                /*var entrada = new entradas();

                entrada.Ent_Ingreso = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                entrada.Ent_MotivoVisita = txtMotivo;
                entrada.Ent_IDVisitante = Convert.ToInt32(txtID);
                entrada.Ent_NombreVisitante = txtNombre;
                entrada.Ent_ApellidoVisitante = txtApellido;
                entrada.usuariosId = (int)HttpContext.Session.GetInt32(SessionCode);

                context.Entradas.Add(entrada);*/
                /*var user = new cuentasusuario { cuentasusuarioId = 1152217168, CU_Usuario = "diego", CU_Password = "diegoverde", CU_Perfil = 1 };
                context.CuentasUsuario.Add(user);

                var user1 = new usuarios { usuariosId = 1152217168, Usu_Nombre = "diego", Usu_Apellido = "sanchez", CuentasUsuarioId = 1152217168 };
                context.Usuarios.Add(user1);

                var salida = new salidas { Sal_Salida = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")), EntradasId = 30, usuariosId = 1152217167 };
                context.Salidas.Add(salida);*/

                var entrada = new entradas { Ent_Ingreso = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")),
                                             Ent_MotivoVisita = txtMotivo,
                                             Ent_IDVisitante = Convert.ToInt32(txtID),
                                             Ent_NombreVisitante = txtNombre,
                                             Ent_ApellidoVisitante = txtApellido,
                                             usuariosId = (int)HttpContext.Session.GetInt32(SessionCode) };
                context.Entradas.Add(entrada);

                System.Console.WriteLine("aca");
                context.SaveChanges();
                System.Console.WriteLine("aqui");
            }
            return RedirectToAction("Index");
        }
    }
}