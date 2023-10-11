using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practicos3_LDVP.METODOS
{
    internal class Metodos
    {
        public void Eje1()
        {
            int[,] ejercicio1 = new int[3, 3];
            for (int i = 0; i < ejercicio1.GetLength(0); i++)
            {
                for (int j = 0; j<ejercicio1.GetLength(1); j++)
                {
                    ejercicio1[i,j] = (ejercicio1.GetLength(1) * i) + (j + 1);
                    Console.Write(ejercicio1[i,j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }


        public void Eje2()
        {
            string[,] ejercicio2 = new string[2,2];

            ejercicio2[0, 0] = "rojo";
            ejercicio2[0, 1] = "verde";
            ejercicio2[1, 0] = "azul";
            ejercicio2[1, 1] = "amarillo";

            for (int i = 0; i < ejercicio2.GetLength(0); i++)
            {
                for (int j = 0; j < ejercicio2.GetLength(1); j++)
                {
                    Console.Write(ejercicio2[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }


        public void Eje3()
        {
            double[,] ejercicio3 = new double[4, 3];
            ejercicio3[0, 0] = 55.5;
            ejercicio3[0, 1] = 47.5;
            ejercicio3[0, 2] = 35.5;

            ejercicio3[1, 0] = 21.5;
            ejercicio3[1, 1] = 55.5;
            ejercicio3[1, 2] = 12.5;

            ejercicio3[2, 0] = 45.5;
            ejercicio3[2, 1] = 6.5;
            ejercicio3[2, 2] = 7.5;

            ejercicio3[3, 0] = 4.5;
            ejercicio3[3, 1] = 5.5;
            ejercicio3[3, 2] = 2.5;

            double suma = 0;
            for (int i = 0; i < ejercicio3.GetLength(0); i++)
            {
                for(int j = 0; j< ejercicio3.GetLength(1);  j++)
                {
                    suma += ejercicio3[i, j];
                    Console.Write(ejercicio3[i, j] + " ");
                }
                Console.WriteLine("");
                
            }
            Console.WriteLine("La suma de todo es: " + suma);
            Console.ReadLine();
        }

        public void Eje4()
        {
            char[,] ejercicio4 = new char[2,4];
            ejercicio4[0, 0] = 'A';
            ejercicio4[0, 1] = 'B';
            ejercicio4[0, 2] = 'C';
            ejercicio4[0, 3] = 'D';

            ejercicio4[1, 0] = 'F';
            ejercicio4[1, 1] = 'G';
            ejercicio4[1, 2] = 'H';
            ejercicio4[1, 3] = 'I';

            for (int i = 0; i <  ejercicio4.GetLength(0);  i++)
            {
                for (int j = 0; j<ejercicio4.GetLength(1); j++)
                {
                    Console.Write(ejercicio4[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
