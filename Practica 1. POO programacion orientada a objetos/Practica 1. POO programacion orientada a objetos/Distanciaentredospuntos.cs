using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica_1.POO_programacion_orientada_a_objetos
{
    class Distanciaentredospuntos : Coordenadas
    {
        

    public void Distancia(double Coordenadax1, double Coordenadax2, double Coordenaday1, double Coordenaday2)
        {
            Coordenadas Coordenadas1;
            Coordenadas1 = new Coordenadas();
            Coordenadas1.ConjuntoP(Coordenadax1, Coordenadax2, Coordenaday1, Coordenaday2);
        }

    public double ConocerDistancia(double Coordenadax1 , double Coordenadax2, double Coordenaday1, double Coordenaday2)
        {
            double distancia;
            distancia = Math.Sqrt((Math.Pow((Coordenadax2 - Coordenadax1), 2)) + (Math.Pow((Coordenaday2 - Coordenaday1),2)));
            return distancia;
        }
    }
}
