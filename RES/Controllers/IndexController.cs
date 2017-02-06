using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication.Controllers
{
    public class IndexController : Controller
    {
        const string SessionCode = "_Code";
        // 
        // GET: /Index/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Index/Home/ 
        [HttpPost]
        public ActionResult Home(string txtUser, string txtPassword)
        {
            ViewData["user"] = txtUser;
            ViewData["password"] = txtPassword;
            bool match = false;
            using (var context = new DBContext())
            {    
                foreach (var cuenta in context.CuentasUsuario)
                {
                    if(cuenta.CU_Usuario == txtUser && cuenta.CU_Password == txtPassword){
                        ViewData["codigo"] = cuenta.cuentasusuarioId;
                        ViewData["perfil"] = cuenta.CU_Perfil;
                        HttpContext.Session.SetInt32(SessionCode, cuenta.cuentasusuarioId);
                        match = true;
                    }
                    if(match)   break;
                }
            }
            if(match){
                return View();
            }else{
                ViewData["message"] = "true";
                return View("~/Views/Index/Index.cshtml");
            }
        }
    }
}