using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.POO_programacion_orientada_a_objetos
{
    class Coordenadas
    {
        private double punto1X;
        private double punto2X;
        private double punto3Y;
        private double punto4Y; 

    public double Coordenada1
        {
            get =>
                punto1X;
            set =>
                punto1X = value;
        }

        public double Coordenada2
        {
            get =>
                punto2X;
            set =>
                punto2X = value;
        }

        public double Coordenada3
        {
            get =>
                punto3Y;
            set =>
                punto3Y = value;
        }

        public double Coordenada4
        {
            get =>
                punto4Y;
            set =>
                punto4Y = value;
        }

        public void ConjuntoP (double Coordenadax1, double Coordenadax2, double Coordenaday1, double Coordenaday2)
        {
            punto1X = Coordenadax1;
            punto2X = Coordenadax2;
            punto3Y = Coordenaday1;
            punto4Y = Coordenaday2;
        }       
    }
}
