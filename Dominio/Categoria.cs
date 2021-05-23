﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio

{
    public class Categoria
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public Categoria(string name) {

            Nombre = name;

        }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;

        }


        public override string ToString()
        {
            return Nombre;
        }


    }
}