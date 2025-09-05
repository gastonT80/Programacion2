using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public  class Guerrero:Maqueta
    {
        private int _edad;
        public Guerrero(string nombre, int vida, int edad) : base(nombre, vida)
        {
            _edad = edad;
        
        }

        public void Autocuracion()
        {
            Debug.Log("curando!!!!!!!!");
        }
    

    }
}
