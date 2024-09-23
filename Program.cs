using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Ejecicios_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ejercicio;
            bool salir = false;
            do
            {
                Console.WriteLine("Elegir el ejercicio: \n" +
                    "Ejercicio 1. \n" +
                    "Ejercicio 2. \n" +
                    "Ejercicio 3. \n" +
                    "Ejercicio 4. \n" +
                    "Ejercicio 5. \n" +
                    "Ejercicio 6. \n" +
                    "Ejercicio 7. \n" +
                    "Ejercicio 8. \n" +
                    "Ejercicio 9. \n" +
                    "Ejercicio 10. \n" +
                    "Ejercicio 11. \n" +
                    "Ejercicio 12. \n" +
                    "Ejercicio 13. \n" +
                    "Salir 0. \n");
                Ejercicio = int.Parse(Console.ReadLine());

                switch (Ejercicio)
                {
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;

                }


            } while (salir);
        }
        static void Ejercicio1()
        {//Crea un arreglo con 5 calificaciones. Muestra todas las calificaciones,
         //verifica cuál fue el valor de la última nota cargada y calcula el promedio de las mismas.

            //double[] Calificaciones = new int[5];

            double[] Calificaciones = { 5, 5, 8, 9, 10 };
            /*foreach (double calificacion in Calificaciones) { Console.WriteLine(calificacion); };

            double ultcalific = Calificaciones[Calificaciones.Length - 1];
            Console.WriteLine("ultima calificaciones " + ultcalific);
            double promedio = 0;
            for (int i = 0; i < Calificaciones.Length; i++)
            {
                promedio += Calificaciones[i];
            }
            Console.WriteLine("El promedio de notas es: " + promedio / Calificaciones.Length);
            */

            foreach (double calificacion in Calificaciones) { Console.WriteLine(calificacion); };

            double ultcalific = Calificaciones[Calificaciones.Length - 1];
            Console.WriteLine("ultima calificaciones " + ultcalific);

            double suma = 0;
            double Promedio = 0;

            foreach (int calificacion in Calificaciones)
            {
                suma += calificacion;
            }

            Promedio = suma / 5;

            Console.WriteLine("Promedio: " + Promedio);

        }
        static void Ejercicio2()
        { //Crea un arreglo que contenga nombres de frutas.
          //Cuenta cuántas veces aparecen "manzanas" y "naranjas" en el arreglo.
            string[] Frutas = new string[8];

            Frutas[0] = "manzanas";
            Frutas[1] = "bananas";
            Frutas[2] = "naranjas";
            Frutas[3] = "manzanas";
            Frutas[4] = "naranjas";
            Frutas[5] = "naranjas";
            Frutas[6] = "naranjas";
            Frutas[7] = "naranjas";
            int contadorManzanas = 0;
            int contadorNaranjas = 0;


            foreach (string Fruta in Frutas)
            {
                if (Fruta == "manzanas") { contadorManzanas++; }

                if (Fruta == "naranjas") { contadorNaranjas++; }


            }
            Console.WriteLine("La cantidad de manzanas es:" + contadorManzanas);
            Console.WriteLine("La cantidad de naranjas es:" + contadorNaranjas);

        }
        static void Ejercicio3()
        {
            //Crea una lista con varios números enteros.Muestra el número más alto de la lista.
            /*List<int> numeros = new List<int>();
          numeros.Add(10);
          numeros.Add(50);
          numeros.Add(200);
          numeros.Add(856);
          numeros.Add(90);
          numeros.Add(60);
          numeros.Add(99);
        */
            List<int> numeros = new List<int>() { 2, 1, 80, 90, 900, 654, 1002, 488, 781 };
            int numeroMaximo = numeros.Max();

            Console.WriteLine("El numero mas alto es: " + numeroMaximo);


        }
        static void Ejercicio4()
        {
            /*Crea un programa que gestione una lista de tareas.El sistema debe permitir:
            Agregar una nueva tarea a la lista.
             Eliminar una tarea existente.
             Modificar una tarea existente.
            Eliminar todas las tareas de la lista.
            */
            List<string> Tareas = new List<string>();
            bool opcion = false;
            do
            {
                Console.WriteLine("Que quieres hacer?");
                Console.WriteLine("1. Agregar una nueva tarea a la lista." +
                    "\n2. Eliminar una tarea existente." +
                    "\n3. Modificar una tarea existente." +
                    "\n4. Eliminar todas las tareas de la lista." +
                    "\n5. Mostrar Tareas");
                int opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 0:
                        opcion = true;
                        break;
                    case 1:
                        Console.WriteLine("ingrese la nueva tarea");
                        Tareas.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("que tarea desea eliminar?");
                        Tareas.Remove(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("que tarea desea modificar?");
                        int index = Tareas.IndexOf(Console.ReadLine());
                        Tareas.RemoveAt(index);
                        Console.WriteLine("ingrese la nueva tarea");
                        Tareas.Insert(index, Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("eliminando todas las tareas");
                        Tareas.Clear();
                        break;
                    case 5:
                        foreach (string tarea in Tareas)
                        {
                            Console.WriteLine(tarea);
                        };
                        break;
                }

            } while (!opcion);

            Console.ReadLine();

        }
        static void Ejercicio5()
        {
            /*5.Crea un programa que permita registrar los montos de ventas de un negocio. Al final, muestra:
                El número total de ventas registradas.
                El monto promedio por venta.
                La cantidad de ventas con un monto mayor a 5,000.
                Mostrar el historial de ventas.
            */
        }
    }
}
      
