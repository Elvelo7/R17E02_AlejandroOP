using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV4_Eficiente
{
    internal class Comprobaciones
    {
        /// <summary>
        /// Validar las horas trabajadas
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static int ValidarHoras(string? cadena)
        {
            // CONSTANTES - NO hace falta porque no se usa aquí y esta en la Clase (get, set)
            //const int LIMITE = 60;

            // VARIABLES
            int numeroHoras = 0;

            // PROCESO - Detección de errores
            // Cadena Vacía
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena Vacía");
            // Conversión
            numeroHoras = Convert.ToInt32(cadena);
            // Rango de Horas - La Validación la realiza la Clase ( get, set)
            //if (numeroHoras <= 0) throw new Exception("Horas inferiores o iguales a 0");
            //if (numeroHoras > LIMITE) throw new Exception($"Horas superiores a {LIMITE} horas");

            // SALIDA - Método
            return numeroHoras;
        }

        /// <summary>
        /// Validar el salario x hora
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static float ValidarSalarioHora(string? cadena)
        {
            // CONSTANTES
            //const float SALARIO_MAX = 22.5f;
            //const float SALARIO_MIN = 1.0f;

            // RECURSOS LOCALES
            float euros = 0.0f;

            // PROCESO - Detección de errores
            // Detección de la cadena vacía
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            // Conversión del valor numérico
            euros = Convert.ToSingle(cadena);
            // Rango de valores
            //if (euros < SALARIO_MIN) throw new Exception($"Valor inferior a {SALARIO_MIN} Euros");
            //if (euros > SALARIO_MAX) throw new Exception($"Valor superior a {SALARIO_MAX} Euros");

            // SALIDA - Método
            return euros;
        }
    }
}
