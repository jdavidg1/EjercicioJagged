using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir una matriz de calificaciones tipo Jagged o escalonada para definir las calificaciones de un colegio con varios salones y en cada uno diferente
            //cantidad de alumnos y por último imprime las notas solicitadas

            int i; //Variable para el ciclo externo, salones
            int j; //Variable para el ciclo interno, alumnos

            int salones = 0;
            int alumnos = 0;


            //Pedir la cantidad de salones

            Console.WriteLine("Cual es la cantidad de salones: ");

            salones = Convert.ToInt32(Console.ReadLine());

            //Organizar el arreglo Jagged que se llamará Calificaciones

            double[][] Calificaciones = new double[salones][];


            //Pedir los alumnos por cada salón

            for (i=0; i<salones;i++)
            {
                Console.WriteLine("Salón {0}: ", i+1);
                Console.WriteLine("Cual es la cantidad de alumnos: ");

                alumnos = Convert.ToInt32(Console.ReadLine());

                //Asignar los alumnos (instanciar el arreglo)

                Calificaciones[i] = new double[alumnos];

            }

            //Dejar un espacio

            Console.WriteLine();

            //Pedir las calificaciones

            for(i=0; i<salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);

                for(j=0; j<Calificaciones[i].GetLength(0);j++)
                {
                    Console.WriteLine("Dame la calificación del alumno {0}", j + 1);
                    Calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                }

            }

            //Mostrar la información

            Console.WriteLine("Información");

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < Calificaciones[i].GetLength(0); j++)
                {
                    Console.WriteLine("El alumno {0}, tiene calificación {1}", j + 1, Calificaciones[i][j]); 
                }

            }
                Console.ReadKey();
        }


    }
}
