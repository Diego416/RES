using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class salidas
    {
        public int salidasId { get; set; }

        public DateTime Sal_Salida { get; set; }

        //[ForeignKey("entradas")]
        public int 	EntradasId { get; set; }

        //[ForeignKey("usuarios")]
        public int usuariosId { get; set; }
    }
}