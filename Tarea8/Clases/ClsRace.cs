using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8.Clases
{
    internal class ClsRace
    {
        private carro CarroA;
        private carro CarroB;
        private carro CarroC;


        public void PedidrDatos()
        {

            CarroA = GetData();
            Console.WriteLine("\nAhora datos del B");
            CarroB = GetData();
            Console.WriteLine("\nAhora datos del C");
            CarroC = GetData();
        }

        public void IniciarCarrera()
        {
            string msgCarroA, msgCarroB, msgCarroC;
            Random velRamdom = new Random();


            msgCarroA = CarroA.EncenderMotor();
            msgCarroB = CarroB.EncenderMotor();
            msgCarroC = CarroC.EncenderMotor();
            Console.WriteLine("\n\tINICIA LA CARREA");
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($"{CarroC.Marca} {msgCarroC}");

            for (int i = 0; i < 10; i++)
            {
                int acelerar; ;
                acelerar = velRamdom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelerar);
                acelerar = velRamdom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelerar);
                acelerar = velRamdom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelerar);
                Console.WriteLine($"{i + 1}- {CarroA.owner} {msgCarroA} // {CarroB.owner} {msgCarroB} // {CarroC.owner} {msgCarroC}");
            }

            if ((CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual()) && (CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual()))
            {
                Console.WriteLine($"GANO {CarroA.owner}!!");

            }
            else if ((CarroB.GetVelocidadActual() > CarroA.GetVelocidadActual()) && (CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual()))
            {
                Console.WriteLine($"GANO {CarroB.owner}!!");
            }
            else if ((CarroC.GetVelocidadActual() > CarroA.GetVelocidadActual()) && (CarroC.GetVelocidadActual() > CarroB.GetVelocidadActual()))
            {
                Console.WriteLine($"GANO {CarroC.owner}!!");
            }
        }

        private carro GetData()
        {
            string marca;
            //int modelo;
            int velocidad = 300;
            string propietario;
            carro carrotemporal;

            Console.WriteLine("Ingrese marca");
            marca = Console.ReadLine();

            //Console.WriteLine("Ingrese modelo");
            //modelo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese velocidad max");
            //velocidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La maxima velocidad es de {velocidad}");

            Console.WriteLine("Ingrese propietario");
            propietario = Console.ReadLine();
            carrotemporal = new carro(marca, velocidad, propietario);
            return carrotemporal;
        }

    }
}
