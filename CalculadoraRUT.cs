using System;
using System.Linq;

namespace CalculadoraRUT
{
    /// <summary>
    /// Programa: Calculadora de Dígito Verificador del RUT Chileno
    /// Descripción: Calcula el dígito verificador de un RUT chileno usando el algoritmo oficial
    /// </summary>
    class Program
    {
        /// <summary>
        /// Punto de entrada principal del programa
        /// </summary>
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarEncabezado();

                // Solicitar y validar el RUT
                string rutSinDV = SolicitarRUT();

                Console.WriteLine("\n" + new string('-', 60));
                Console.WriteLine("PROCESO DE CÁLCULO:");
                Console.WriteLine(new string('-', 60));

                // Calcular el dígito verificador
                string digitoVerificador = CalcularDigitoVerificador(rutSinDV);

                Console.WriteLine(new string('-', 60));

                // Formatear y mostrar el RUT completo
                string rutCompleto = FormatearRUT(rutSinDV, digitoVerificador);
                MostrarResultado(rutCompleto, digitoVerificador);

                // Preguntar si desea calcular otro RUT
                continuar = PreguntarContinuar();

                if (continuar)
                {
                    Console.Clear();
                }
            }

            Console.WriteLine("\n¡Gracias por usar el programa!");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra el encabezado del programa
        /// </summary>
        static void MostrarEncabezado()
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("  CALCULADORA DE DÍGITO VERIFICADOR - RUT CHILENO");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine();
        }

        /// <summary>
        /// Solicita el RUT al usuario y valida la entrada
        /// </summary>
        /// <returns>RUT sin dígito verificador (limpio de puntos y guiones)</returns>
        static string SolicitarRUT()
        {
            string rutInput;
            string rutLimpio;

            while (true)
            {
                Console.Write("Ingrese el número de RUT (sin dígito verificador): ");
                rutInput = Console.ReadLine().Trim();

                // Limpiar el RUT de puntos y guiones
                rutLimpio = LimpiarRUT(rutInput);

                // Validar la entrada
                if (ValidarEntrada(rutLimpio))
                {
                    return rutLimpio;
                }
                else
                {
                    Console.WriteLine("  ❌ Entrada inválida. Por favor, ingrese solo números.\n");
                }
            }
        }

        /// <summary>
        /// Limpia el RUT eliminando puntos y guiones
        /// </summary>
        /// <param name="rut">RUT con posibles puntos y guiones</param>
        /// <returns>RUT limpio</returns>
        static string LimpiarRUT(string rut)
        {
            return rut.Replace(".", "").Replace("-", "");
        }

        /// <summary>
        /// Valida que el RUT sea numérico y tenga longitud correcta
        /// </summary>
        /// <param name="rut">RUT a validar</param>
        /// <returns>True si es válido, False en caso contrario</returns>
        static bool ValidarEntrada(string rut)
        {
            // Verificar que solo contenga dígitos
            if (!rut.All(char.IsDigit))
            {
                return false;
            }

            // Verificar longitud (RUT chileno típicamente tiene 7-9 dígitos sin DV)
            if (rut.Length < 7 || rut.Length > 9)
            {
                Console.WriteLine("  ⚠️  El RUT debe tener entre 7 y 9 dígitos.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calcula el dígito verificador del RUT usando el algoritmo oficial chileno
        /// </summary>
        /// <param name="rutSinDV">RUT sin dígito verificador</param>
        /// <returns>Dígito verificador ('0'-'9' o 'K')</returns>
        static string CalcularDigitoVerificador(string rutSinDV)
        {
            // Invertir el RUT para multiplicar de derecha a izquierda
            char[] rutArray = rutSinDV.ToCharArray();
            Array.Reverse(rutArray);
            string rutInvertido = new string(rutArray);

            // Multiplicadores del 2 al 7, que se repiten cíclicamente
            int[] multiplicadores = { 2, 3, 4, 5, 6, 7 };

            // Variable para acumular la suma de productos
            int suma = 0;

            // Recorrer cada dígito del RUT invertido
            for (int i = 0; i < rutInvertido.Length; i++)
            {
                // Obtener el dígito actual
                int digito = int.Parse(rutInvertido[i].ToString());

                // Obtener el multiplicador correspondiente (ciclo de 2 a 7)
                int multiplicador = multiplicadores[i % 6];

                // Calcular el producto
                int producto = digito * multiplicador;

                // Acumular en la suma
                suma += producto;

                // Mostrar el proceso
                Console.WriteLine($"  Dígito: {digito} × {multiplicador} = {producto}");
            }

            Console.WriteLine($"\n  Suma total: {suma}");

            // Calcular el resto de la división por 11
            int resto = suma % 11;
            Console.WriteLine($"  Resto (suma % 11): {resto}");

            // Calcular el dígito verificador: 11 - resto
            int resultado = 11 - resto;
            Console.WriteLine($"  Resultado (11 - resto): {resultado}");

            // Determinar el dígito verificador según las reglas
            string dv;
            if (resultado == 11)
            {
                dv = "0";
            }
            else if (resultado == 10)
            {
                dv = "K";
            }
            else
            {
                dv = resultado.ToString();
            }

            return dv;
        }

        /// <summary>
        /// Formatea el RUT en el formato estándar chileno: XX.XXX.XXX-DV
        /// </summary>
        /// <param name="rutSinDV">RUT sin dígito verificador</param>
        /// <param name="dv">Dígito verificador</param>
        /// <returns>RUT formateado</returns>
        static string FormatearRUT(string rutSinDV, string dv)
        {
            // Invertir el RUT para formatear de derecha a izquierda
            char[] rutArray = rutSinDV.ToCharArray();
            Array.Reverse(rutArray);
            string rutInvertido = new string(rutArray);

            // Formatear con puntos cada 3 dígitos
            string rutFormateado = "";
            for (int i = 0; i < rutInvertido.Length; i++)
            {
                // Agregar punto cada 3 dígitos (excepto al inicio)
                if (i > 0 && i % 3 == 0)
                {
                    rutFormateado = "." + rutFormateado;
                }
                rutFormateado = rutInvertido[i] + rutFormateado;
            }

            // Agregar el dígito verificador con guion
            return $"{rutFormateado}-{dv}";
        }

        /// <summary>
        /// Muestra el resultado final del cálculo
        /// </summary>
        /// <param name="rutCompleto">RUT completo formateado</param>
        /// <param name="dv">Dígito verificador</param>
        static void MostrarResultado(string rutCompleto, string dv)
        {
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("  RESULTADO:");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"\n  ✅ RUT completo: {rutCompleto}");
            Console.WriteLine($"  ✅ Dígito Verificador: {dv}");
            Console.WriteLine("\n" + new string('=', 60));
        }

        /// <summary>
        /// Pregunta al usuario si desea calcular otro RUT
        /// </summary>
        /// <returns>True si desea continuar, False en caso contrario</returns>
        static bool PreguntarContinuar()
        {
            Console.Write("\n¿Desea calcular otro RUT? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToUpper();

            return respuesta == "S" || respuesta == "SI" || respuesta == "SÍ";
        }
    }
}