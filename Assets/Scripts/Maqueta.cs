using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Maqueta
    {
        protected string _nombre;
        protected int _vida;

        public Maqueta(string nombre, int vida)
        {
            _nombre = nombre;   
            _vida = vida;
            Saludar();

        }


        public void Ataque()
        {
            Debug.Log("atacando!!!!!!!!");
        }

        public void Saludar()
        {
            Debug.Log("Hola soy: " + _nombre + "   en busqueda de combate");
        }
    }
}
