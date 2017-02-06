using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class usuarios
    {
        public int usuariosId { get; set; }

        [MaxLength(25)]
        public string Usu_Nombre { get; set; }

        [MaxLength(25)]
        public string Usu_Apellido { get; set; }

        //[ForeignKey("cuentasusuario")]
        public int CuentasUsuarioId { get; set; }
    }
}