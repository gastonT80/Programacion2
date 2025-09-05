using Assets.Scripts;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Practica : MonoBehaviour
{
    balleta miballeta;
    //balleta miballeta2;

    Escudo miEscudo;

    Mago gandalf;
    Guerrero ari;

    void Start()
    {
        //miballeta2 = new balleta();
        miballeta = new balleta(130, 200);

        miEscudo = new Escudo(100);

        //miballeta2._alcance = 33;
        //miballeta2._danio = 300;


        //miballeta.Disparar();
        //miballeta.Recarga();
        //MostrarArma(miballeta);
        
        
        miballeta.DispararAEscudo(miEscudo);

        gandalf=new Mago("gandalf",400);
        ari = new Guerrero("Ari", 10000, 19);

        //gandalf.Saludar();

        //ari.Saludar();
    }

    void MostrarArma(balleta _balleta)
    {
        print(_balleta._alcance);
        print(_balleta._danio);
    }

    void MostrarArma(balleta _balleta, int Escuado)
    {

    }

    //void UsarBallesta()
    //{
    //    print("se disparo balleta");
    //    miEscudo._dureza -= miballeta._danio;
    //    if (miEscudo._dureza <=0)
    //    {
    //        print("se ha roto la escudo");
    //    }
    //    else
    //    {
    //        print("escudo tiene vida");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
