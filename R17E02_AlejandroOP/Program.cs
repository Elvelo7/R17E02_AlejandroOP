namespace R17E02_AlejandroOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INICIALIZACION CLASE
            Producto InfoProducto = new Producto();

            InfoProducto.Nombre = "iPhone 15 Pro Max Titanium";
            InfoProducto.Precio = 300;
           
            Console.WriteLine($"Nombre: {InfoProducto.Nombre}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"Precio: {InfoProducto.Precio}");
            Console.WriteLine($"Precio + IVA: {InfoProducto.PrecioIVA()}");
        }

    }
}