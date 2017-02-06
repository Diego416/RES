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
            return View();
        }
    }
}