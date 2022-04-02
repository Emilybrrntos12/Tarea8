using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8.Clases
{
    internal class carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public String Color { get; set; }

        public string owner { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }

        public carro(string _marca, int _modelo, string _color, int _maxvel)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = _maxvel;
            this.velocidad_actual = 0;

        }

        //contruir 2do constructor
        public carro(string _marca, int _maxvel, string _owner)
        {
            Marca = _marca;
            //Modelo = _modelo;
            MAXVELOCIDAD = 300;
            owner = _owner;
            this.velocidad_actual = 0;
        }
        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }

        public string EncenderMotor()
        {
            if (Encendido == 0)
            {

                Encendido = 1;
                this.velocidad_actual = 0;
                return "RUN RUN RUN RUN, LISTOS PARA CORRER";
            }
            else
            {
                return "Orale!!!! ya esta enciendio tu carro";
            }
        }

        public string acelerar1()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el ccarro apagado";
                return mensaje;
            }

            velocidad_actual += 10;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas vas muy rapido y ya llegaste al tope";
            }

            return mensaje;
        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                mensaje = $"{velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido DETENTE";
            }

            return mensaje;
        }

    }

}
