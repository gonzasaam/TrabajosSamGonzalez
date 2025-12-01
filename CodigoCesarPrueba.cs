using System;

class Program
{

  // alfabeto que se utilizara para el cifrado
    static string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

    // corrimiento de 5
    static int distanciaFija = 5;

    public static void Main()
    {
        // solicitar mensaje a cifrar
        Console.WriteLine("Ingrese la frase a cifrar:");
        string msj = Console.ReadLine();

        // validar que el mensaje 
        while (string.IsNullOrEmpty(msj))
        {
            Console.WriteLine("Ingrese un mensaje no vacío:");
            msj = Console.ReadLine();
        }

        
        Program program = new Program();

        // cifrar el mensaje usando corrimiento fijo
        string cifrado = program.cifrar(msj, distanciaFija);
        Console.WriteLine("Mensaje cifrado: " + cifrado);

        // solicitar mensaje a descifrar
        Console.WriteLine("\nIngrese la frase a descifrar:");
        string msj1 = Console.ReadLine();

        // validar que el mensaje no esté vacío
        while (string.IsNullOrEmpty(msj1))
        {
            Console.WriteLine("Ingrese un mensaje no vacío:");
            msj1 = Console.ReadLine();
        }

        // descifrar el mensaje usando el mismo corrimiento
        string descifrado = program.descifrar(msj1, distanciaFija);
        Console.WriteLine("Mensaje descifrado: " + descifrado);
    }

    // método para cifrar un mensaje
    public string cifrar(string msj, int distancia)
    {
        string cifrado = "";

        // recorrer cada carácter del mensaje
        foreach (char c in msj)
        {
            int pos = alfabeto.IndexOf(c); // obtener la posición del carácter en el alfabeto

            if (pos != -1)
            {
                // calcular la nueva posición con corrimiento y usar módulo para no salir del alfabeto
                pos = (pos + distancia) % alfabeto.Length;
                cifrado += alfabeto[pos]; 
            }
            else
            {
                // si el carácter no está en el alfabeto, se agrega tal cual
                cifrado += c;
            }
        }

        return cifrado; // retornar mensaje cifrado
    }
    public string descifrar(string msj, int distancia)
    {
        string descifrado = "";

        // recorre cada carácter del mensaje cifrado
        foreach (char c in msj)
        {
            int pos = alfabeto.IndexOf(c); // obtiene la posición del carácter 

            if (pos != -1)
            {
                // calcula la posición original usando corrimiento inverso
                pos = (pos - distancia + alfabeto.Length) % alfabeto.Length;
                descifrado += alfabeto[pos]; // agregar carácter descifrado al resultado
            }
            else
            {
                // si el carácter no está en el alfabeto, se agrega tal cual
                descifrado += c;
            }
        }

        return descifrado; // retornar mensaje descifrado
    }
}
