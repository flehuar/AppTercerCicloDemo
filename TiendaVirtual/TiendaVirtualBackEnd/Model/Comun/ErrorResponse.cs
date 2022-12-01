﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Comun
{
    public class ErrorResponse
    {
        public string code { get; set; }
        public long idError { get; set; }
        public string mensaje { get; set; }
        public string mensajeSistema { get; set; }

        public ErrorResponse()
        {
            code = "ERROR";
            idError = 500;
            mensaje = "Ocurrio un problema en el servidor";
        }

        public ErrorResponse(string code, int id_Error, string mensaje)
        {
            this.code = code;
            idError = id_Error;
            this.mensaje = mensaje;
        }
    }
}
