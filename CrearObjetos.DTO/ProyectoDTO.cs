﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearObjetos.DTO
{
    public class ProyectoDTO: GestorBaseDatosDTO
    {
        public string NombreProyecto { get; set; }
        public string NombreColaborador { get; set; }
    }
}