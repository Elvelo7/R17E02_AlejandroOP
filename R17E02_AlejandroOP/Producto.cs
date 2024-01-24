using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17E02_AlejandroOP
{
    internal class Producto
    {
        // CONSTANTES PRIVADAS
        const float PRECIO_MIN = 50;
        const float PRECIO_MAX = 350;

        // INICIALIZACIÓN OBJETOS
        private string? _nombre;
        private float _precio;

        // MÉTODOS
        public string? Nombre
        {
            get
            {
                if (string.IsNullOrEmpty(_nombre)) throw new Exception
                        ("CADENA VACÍA");
                return _nombre;
            }
            set
            {
                _nombre = value;    
            }
        }

        public float Precio
        {
            get
            {
                // Comprobacion de valor establecido
                if (_precio == 0) throw new Exception("ERROR: El precio" +
                    "no se ha establecido");

                return _precio;
            }
            set
            {
                // Validación del precio
                if (value < PRECIO_MIN) throw new Exception("El precio" +
                    $"es menoR al mínimo --> {PRECIO_MIN}");
                if (value > PRECIO_MAX) throw new Exception("El precio" +
                    $"es mayor al máximo --> {PRECIO_MAX}");

                _precio = value;
            }
        }

        public float PrecioIVA()
        {
            // CONSTANTE
            const float IVA = 0.21f;

            // RECURSO LOCAL
            // float precioIva = 0;
            float precioIva = -1;
            

            // PROCESO
            // precioIva = Precio * (1 + IVA) --> Si lo dejamos así y no
            // se establece el Precio salta la excepción que hemos puesto 
            // arriba.

            // Ahora con el try catch anulamos la excepción anterior
            try
            {
                precioIva = Precio * (1 + IVA);
            }
            catch(Exception ex)
            {/* precioIva = -1;*/}   /* precioIva = -1 -> si lo hubieramos
                                        inicializado a 0 */


            // SALIDA - Método
            return precioIva;
        }
    }
}
