﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Entidades
{
    public class Maestro : Entidad
    {

        public string Direccion { get; set; }
        public string Telefono { get; set; }


        public Maestro(string nombre, string apellido, string email, string direcion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Direccion = direcion;
            Telefono = telefono;

            //usar regex para validar email
            if (string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                throw new InvalidOperationException("El email no es valido");
            }

            Email = email;

        }

        public override string ToString()
        {
            return Nombre + "," + Apellido + "," + Email + "," + Direccion + "," + Telefono;
        }
        public override  void ReadTxt(string linea)
            {
            var valores = linea.Split(',');
            Nombre= valores[(int)MaestroColum.Nombre]; 
            Apellido= valores[(int)MaestroColum.Apellido];
            Email= valores[(int)MaestroColum.Email];
            Direccion = valores[(int)MaestroColum.Direccion];
            Telefono = valores[(int)MaestroColum.Telefono];

            
        }
        public Maestro(): base()
        {
            
        }
        public enum MaestroColum : int
        {
            
            Nombre=0,
            Apellido,
            Email,
            Direccion,
            Telefono
        }

    }
}
