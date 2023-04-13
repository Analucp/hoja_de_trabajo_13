using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hoja de trabajo - 13 de abril - Ana Lucía Chávez");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione el programa  que desea ejecutar");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Calcular el área de una figura");
            Console.WriteLine("2. Calcular el precio final de un electrodoméstico");
            Console.WriteLine("3. Calcular los divisores de un número");
            Console.WriteLine("4. Salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccione la figura de la cual desea calcular el área:");
                    Console.WriteLine("1. Círculo");
                    Console.WriteLine("2. Cuadrado");
                    Console.WriteLine("3. Triángulo");

                    int figura = Convert.ToInt32(Console.ReadLine());

                    switch (figura)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el radio del círculo a utilizar:");
                            double radio = Convert.ToDouble(Console.ReadLine());
                            double areaCirculo = Math.PI * Math.Pow(radio, 2);
                            Console.WriteLine("El área del círculo es: " + areaCirculo);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el lado del cuadrado a utilizar:");
                            double lado = Convert.ToDouble(Console.ReadLine());
                            double areaCuadrado = Math.Pow(lado, 2);
                            Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
                            break;
                        case 3:
                            Console.WriteLine("Ingrese la base del triángulo a utilizar:");
                            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del triángulo:");
                            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                            Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                            break;
                        default:
                            Console.WriteLine("Opción inválida, ingrese de nuevo otra opción");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Precio final de un electrodoméstico");

                    Console.Write("Ingrese el precio inicial del electrodoméstico: ");
                    double basePrice = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el consumo energético (A, B, C, D o E): ");
                    string energyConsumption = Console.ReadLine().ToUpper();

                    double energyPrice = 0;
                    switch (energyConsumption)
                    {
                        case "A":
                            energyPrice = 100;
                            break;
                        case "B":
                            energyPrice = 80;
                            break;
                        case "C":
                            energyPrice = 60;
                            break;
                        case "D":
                            energyPrice = 50;
                            break;
                        case "E":
                            energyPrice = 30;
                            break;
                        default:
                            Console.WriteLine("Consumo energético inválido, ingrese de nuevo una opción");
                            break;
                    }

                    Console.Write("Ingrese el color que desea (blanco, negro o gris): ");
                    string color = Console.ReadLine().ToLower();

                    double colorPrice = 0;
                    switch (color)
                    {
                        case "blanco":
                            colorPrice = 50;
                            break;
                        case "negro":
                            colorPrice = 80;
                            break;
                        case "gris":
                            colorPrice = 60;
                            break;
                        default:
                            Console.WriteLine("Color inválido, ingrese de nuevo un color");
                            break;
                    }

                    Console.Write("Ingrese el peso debe de ser en kilogramos: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    double weightPrice = 0;
                    if (weight < 20)
                    {
                        weightPrice = 10;
                    }
                    else if (weight >= 20 && weight < 50)
                    {
                        weightPrice = 50;
                    }
                    else if (weight >= 50 && weight < 100)
                    {
                        weightPrice = 80;
                    }
                    else if (weight >= 100)
                    {
                        weightPrice = 100;
                    }

                    double totalPrice = basePrice + energyPrice + colorPrice + weightPrice;
                    Console.WriteLine("El precio final del electrodoméstico es: " + totalPrice);
                    break;
                case 3:
                    Console.WriteLine("Divisores de un número");

                    Console.Write("Ingrese un número entero que sea positivo: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Los divisores de " + num + " son: ");
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    break;

            }
        } while (true);
    }
}