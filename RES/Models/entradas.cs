using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class entradas
    {
        public int entradasId { get; set; }

        public DateTime Ent_Ingreso { get; set; }

        [MaxLength(45)]
        public string Ent_MotivoVisita { get; set; }

        public int Ent_IDVisitante { get; set; }

        [MaxLength(25)]
        public string Ent_NombreVisitante { get; set; }

        [MaxLength(25)]
        public string Ent_ApellidoVisitante { get; set; }

        //[ForeignKey("usuarios")]
        public int usuariosId { get; set; }
    }
}