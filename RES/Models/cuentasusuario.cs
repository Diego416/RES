using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class cuentasusuario
    {
        public int cuentasusuarioId { get; set; }

        [MaxLength(25)]
        public string CU_Usuario { get; set; }

        [MaxLength(30)]
        public string CU_Password { get; set; }

        public int CU_Perfil { get; set; }
    }
}