using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV4_Eficiente
{
    public class Nomina
    {
        // CONSTANTES
        // const int LIMITE_HORAS = 60;  --> Es privado por defecto
        private const int LIMITE_HORAS = 60;  // Lo pongo así para enterarme mejor al principio

        // Para el salario del trabajador
        private const float SALARIO_MAX = 22.5f;
        private const float SALARIO_MIN = 1.0f;

        // Constante para el calculo de las horas extra
        const int HORAS_SEMANALES = 35;         // NO pongo privado porque es privado de serie

        // Constante para el calculo del salario extra
        const float INCR_EXTRA = 1.5f;

        // Constante para los Impuestos
        const float PORCENTAJE_IMP = 0.16f;

        // MIEMBROS - CAMPOS - ATRIBUTOS (Son Sinónimos)
        /* Cuando definimos los miembros dentro de una clase, 
         * siempre son privados por defecto.
         * Para hacerlo público se pone el termino "public" delante.*/

        public string? nombre;
        public string? apellidos;
        public string? puesto;

        private int _horasTrabajadas;
        private float _salarioHora;


        // PROPIEDADES
        /// <summary>
        /// 
        /// </summary>
        public int HorasTrabajadas
        {
            get    /* Se activa cuando se consulta el valor del miembro, es decir:
                    * Resultado = -----.HorasTrabajadas - 10; */
            {
                //if (_salarioHora == null) throw new Exception("Horas trabajadas no establecidas");
                return _horasTrabajadas;
            }
            set    /* Se activa cuando se le asigna a la propiedad un valor 
                    * Ejemplo: ----.HorasTrabajadas = 34; */
            {
                // Comprobación 1: Horas no superiores al límite
                if (value > LIMITE_HORAS) throw new Exception($"Las horas son superiores a " +
                    $"{LIMITE_HORAS} horas");

                // Comprobación 2: Horas inferiores o iguales a 0
                if (value <= 0) throw new Exception($"Horas inferiores o iguales a 0");

                _horasTrabajadas = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float SalarioHora
        {
            get
            {
                if (_salarioHora == 0) throw new Exception("Salario x Hora no establecido");
                return _salarioHora;
            }
            set
            {
                // Comprobación salario superior al mínimo
                if (value < SALARIO_MIN) throw new Exception
                        ($"Valor inferior a {SALARIO_MIN} Euros");

                // Comprobación salario superior al máximo
                if (value > SALARIO_MAX) throw new Exception
                        ($"Valor superior a {SALARIO_MAX} Euros");

                _salarioHora = value;
            }
        }

        #region MÉTODOS PÚBLICOS
        
        /// <summary>
        /// Calculo Horas Extra
        /// </summary>
        /// <returns>Horas Extra</returns>
        public int HorasExtra()
        {
            int horasExtra = 0;

            // PROCESO
            if (HorasTrabajadas > HORAS_SEMANALES) horasExtra = HorasTrabajadas - HORAS_SEMANALES;

            return horasExtra;
        }

        /// <summary>
        /// Calculo Salario Base
        /// </summary>
        /// <returns>Salario Base</returns>
        public float SalarioBase()
        {
            float salarioBase = 0;

            // PROCESO
            if (HorasTrabajadas > HORAS_SEMANALES) salarioBase = HORAS_SEMANALES * SalarioHora;
            else salarioBase = HorasTrabajadas * SalarioHora;

            return salarioBase;
        }

        /// <summary>
        /// Calculo Salario Extra
        /// </summary>
        /// <returns>Salario Extra</returns>
        public float SalarioExtra()
        {
            float salarioExtra = 0;

            // PROCESO
            salarioExtra = HorasExtra() * SalarioHora * INCR_EXTRA;

            return salarioExtra;
        }

        /// <summary>
        /// Calculo Salario Bruto
        /// </summary>
        /// <returns>Salario Bruto</returns>
        public float SalarioBruto()
        {
            float salarioBruto = 0;

            salarioBruto = SalarioBase() + SalarioExtra();

            return salarioBruto;
        }

        /// <summary>
        /// Cálculo Impuestos
        /// </summary>
        /// <returns>Impuestos</returns>
        public float Impuestos()
        {
            float impuestos = 0;

            // PROCESO
            impuestos = SalarioBruto() * PORCENTAJE_IMP;

            return impuestos;
        }

        /// <summary>
        /// Cálculo Salario Neto
        /// </summary>
        /// <returns>Salario Neto</returns>
        public float SalarioNeto()
        {
            float salarioNeto = 0;

            // PROCESO
            salarioNeto = SalarioBruto() - Impuestos();

            return salarioNeto;
        }

        #endregion
    }
}
