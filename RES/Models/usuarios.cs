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
        [Key]
        public int UsuarioId { get; set; }

        [MaxLength(45)]
        public string Usu_Nombre { get; set; }

        [MaxLength(45)]
        public string Usu_Apellido { get; set; }

        [MaxLength(45)]
        public string Usu_Email { get; set; }
    }
}