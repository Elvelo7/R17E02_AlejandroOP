namespace GestionNominasV4_Eficiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // RECURSOS
            // Defino que recursos voy a utilizar
            /* Ahora mismo nominaEmpleado (que sería el objeto)
             * vale NULL porque aun no se le ha asignado memoria */
            Nomina nominaEmpleado;

            // INICIALIZACIÓN
            // Se le asigna una porción de memoria pero ahora mismo no tiene nada.
            nominaEmpleado = new Nomina();

            // ENTRADA
            // Método para captar el nombre del empleado dándole un valor directamente
            //nominaEmpleado.nombre = "Alex";

            /* Podría asignarle otra clase por ejemplo: */
            nominaEmpleado.nombre = Interfaz.Leerdatos("nombre");
            nominaEmpleado.apellidos = Interfaz.Leerdatos("apellidos");
            nominaEmpleado.puesto = Interfaz.Leerdatos("puesto");

            // Captación de las horas trabajadas
            Interfaz.LeerHoras("horas trabajadas", nominaEmpleado);

            // Captación del salario por hora del trabajador
            Interfaz.LeerSalarioHora("salario x hora", nominaEmpleado);
            Console.Clear();

            Interfaz.MostrarNomina(nominaEmpleado);

        }
    }
}