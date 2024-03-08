﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    internal class Cliente
    {
        string nombre = "";
        string apellido = "";
        int dni = 0;

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Dni { get { return dni; } }

        public Cliente(string nom, string ap, int dni)
        {
            nombre = nom;
            apellido = ap;
            this.dni= dni;
        }

        public override string ToString()
        {
            return $"Cliente;{nombre};{apellido};{dni}";
        }
    }
}
