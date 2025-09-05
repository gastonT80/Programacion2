using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Assets.Scripts
{
    public  class Escudo
    {
        public int _dureza;

        public Escudo(int dureza) 
        {
            _dureza=dureza;
        }

        private void Roto()
        {
            Debug.Log("Escudo roto!!!!!!!!");
        }
        private void Defenderse()
        {
            Debug.Log("Escudo con energia!!!!!!!!");
        }
        public void Danio(int _danio)
        {
            _dureza -= _danio;
            if (_dureza <= 0)
            {
                Roto();
            }
            else
            {
                Defenderse();
            }
        }
    }
}
