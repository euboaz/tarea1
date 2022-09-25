public class Program
{
    public static void Main(string[] args)
    {
        //Declaracion de Strings e Ingreso de Datos

        //Mensaje de Bienvenida
        Console.WriteLine("*** Bienvenido al sistema de Registro de Estudiantes ***");

        //Array de los nombre de los estudiantes
        string[] nombresEstudiantes = new string[5];
        Console.WriteLine("Ingrese el nombre del primer estudiante: ");
        nombresEstudiantes[0] = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del segundo estudiante: ");
        nombresEstudiantes[1] = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del tercer estudiante: ");
        nombresEstudiantes[2] = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del cuarto estudiante: ");
        nombresEstudiantes[3] = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del quinto estudiante: ");
        nombresEstudiantes[4] = Console.ReadLine();

        int[] notas = new int[5];
        Console.WriteLine("Ingrese la nota del primer estudiante: ");
        notas[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del segundo estudiante: ");
        notas[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del tercer estudiante: ");
        notas[2] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del cuarto estudiante: ");
        notas[3] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del quinto estudiante: ");
        notas[4] = Convert.ToInt32(Console.ReadLine());

        //Menu de Opciones

        int option = 0;
        Console.WriteLine("Ingrese la opcion a realizar: \n 1) Calcular Promedios\n 2) Calcular la nota mas alta\n 3)Mostrar Notas Mayores Y Menores al Promedio\n 4) Salir");
        option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:
                    //Calcular Promedios
                    Console.WriteLine("*** Opcion elegida (1) - Calculo de Promedios ***");
                    int totalnotas = notas.Sum();
                    int promedio = totalnotas / 5;
                    Console.WriteLine("El promedio de notas de los 5 estudiantes es de: " + promedio);
                    break;

                case 2:
                    //Calcular la nota mas alta
                    Console.WriteLine("*** Opcion elegida (2) - Calcular la nota mas alta ***");
                    int notaMasAlta = notas.Max();
                    Console.WriteLine("La nota mas alta obtenida por los estudiantes es: " + notaMasAlta);
                    break;

                case 3:
                    //Mostrar Notas Mayores Y Menores al Promedio
                    Console.WriteLine("*** Opcion elegida (3) - Mostrar Notas Mayores Y Menores al Promedio ***");
                    int total_notas = notas.Sum();
                    int prom = total_notas / 5;
                    Console.WriteLine("El promedio de las notas es: " + prom);
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] < prom)
                        {
                            Console.WriteLine("La nota: " + notas[i] + " se encuentra por debajo del promedio\n");
                        }
                        else
                        {
                            Console.WriteLine("La nota: " + notas[i] + " es igual o esta por encima del promedio\n");
                        }
                    };
                    break;

                case 4:
                    //Salir
                    Console.WriteLine("*** Gracias por utilizar nuestro sistema ***");
                    break;

                default:
                    //Contingencia de Errores
                    Console.WriteLine("*** Por favor, ingrese una opcion valida y vuelva a ingresar al sistema ***");
                    break;
            }
        }
    }

