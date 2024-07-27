#region Enunciado
/*
 Módulo 1 - Ejercicio Práctico (OBLIGATORIO) (Tipos de Datos y Estructuras de Control)

 Crear una aplicación simple de consola para el siguiente escenario:

 Escenario: Weather Forecast

    1. Solicitar al usuario que introduzca la temperatura actual (en grados Celsius). 

    2. Basándose en la temperatura introducida, la aplicación debería mostrar un mensaje:
       - Si la temperatura es inferior a 0, mostrar "Hace mucho frío afuera, asegúrate de abrigarte bien."
       - Si la temperatura está entre 0 y 20, mostrar "El clima está fresco, una chaqueta ligera sería perfecta."
       - Si la temperatura es superior a 20, mostrar "Hace calor afuera, no necesitas una chaqueta."

    3. Luego, la aplicación debería preguntar al usuario si quiere conocer el pronóstico para los próximos cinco días (sí/no).

    4. Si el usuario responde 'sí', la aplicación debería generar y mostrar un pronóstico simple.

    5. Finalmente, la aplicación debería preguntar al usuario si quiere consultar otro pronóstico. Si el usuario responde 'sí', la aplicación debería comenzar de nuevo. 
       Si el usuario responde 'no', la aplicación debería mostrar un mensaje de despedida y terminar.
*/
#endregion

// Declaración de Variables
int temperaturaActual, temperaturaAleatoria, min = -50, max = 50;
string msg = "", respuesta = "";
bool isFinished = false;

//Declaracion de un Objeto random para generar un número aleatorio
Random random = new Random();


do
{
    Console.WriteLine("\t\t***** App Weather Forecast *****\n\n");

    Console.Write("Ingrese la temperatura actual (en grados Celsius): ");
    if (!Int32.TryParse(Console.ReadLine(), out temperaturaActual))
    {
        Console.WriteLine("Valor de temperatura ingresado Invalido!! Se ha generado uno al azar");
        temperaturaActual = random.Next(min, max);        
    }

    if (temperaturaActual < 0)
    {
        msg = "Hace mucho frío afuera, asegúrate de abrigarte bien.";
    }
    else if (temperaturaActual >= 0 && temperaturaActual <= 20)
    {
        msg = "El clima está fresco, una chaqueta ligera sería perfecta.";
    }
    else
    {
        msg = "Hace calor afuera, no necesitas una chaqueta.";
    }
    Console.WriteLine(msg);

    Console.Write("\nDesea conocer el pronóstico para los próximos cinco días (sí/no)?: ");
    respuesta = Console.ReadLine();

    if (respuesta == "si" || respuesta == "SI") {
        for (int i = 1; i <= 5; i++)
        {
            temperaturaAleatoria = random.Next(min, max);
            msg = $"-> Día {i}: {temperaturaAleatoria}°C ";
            switch (temperaturaAleatoria)
            {
                case < 0:
                    msg += "- Mucho Frio";
                    break;
                case >= 0 and <= 20:
                    msg += "- Clima Fresco o Templado";
                    break;
                case > 20:
                    msg += "- Clima Calido o Caluroso";
                    break;
                default:
                    break;
            }
            Console.WriteLine(msg);
        }
    }
    Console.Write("\nDesea consultar otro pronóstico (sí/no)?: ");

    respuesta = Console.ReadLine();

    if (respuesta == "no" || respuesta == "NO")
    {
        Console.WriteLine("\nEl programa \"Weather Forecast\" ha finalizado. Gracias por su participación.");
        isFinished = true;
    } else
    {
        Console.Clear();
    }    

} while (!isFinished);