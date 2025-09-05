using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Mago:Maqueta
    {
        public Mago(string nombre, int vida) : base(nombre, vida)
        {
        }

        public void Hechizo()
        {
            Debug.Log("lanza encantamiento");
        }

      
    }
}
