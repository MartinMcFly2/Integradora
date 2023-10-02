﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppRegistrosA.Models
{
    public class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int IDEmp { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string ApellidoPaterno { get; set; }

        [MaxLength(50)]
        public string ApellidoMaterno { get; set; }

        public int Edad {  get; set; }

        public int Telefono { get; set;}
    }
}
