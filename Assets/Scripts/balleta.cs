using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Assets.Scripts
{
    public class balleta
    {
        public int _danio;
        public int _alcance;

        public balleta()
        {
            Debug.Log("instancia de un constructor vacio de la clase balleta");

        }
        public balleta(int danio, int alcance)
        {
            _danio = danio;
            _alcance = alcance;
        }

        public void Disparar()
        {
            Debug.Log("Disparando..............");
        }


        public void Recarga()
        {
            Debug.Log("Recargando balleta.......");
        }

        public void DispararAEscudo(Escudo _escudo)
        {
            Disparar();
            _escudo.Danio(_danio);
        }
    }
}
