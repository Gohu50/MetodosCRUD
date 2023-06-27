

using TallerCrud.Models;

class Program
{
    static void Main(string[] args)
    {
        consultarCliente();
        agregarCliente();
        Eliminar();
        modificarClientes();
    }

    public static void agregarCliente()
    {
        using (var contex = new ServicioContext())
        {
            Console.WriteLine("Metodo agregar Cliente");
            Cliente cli = new Cliente();
            {
                cli.Nombre = "darlyn";
                cli.Apellido = "Plua";
                cli.Dirección = "Monte SINAI";
                cli.Telefono = Convert.ToInt32("09541780");
                cli.FechaNacimiento = Convert.ToDateTime("2001-03-15");
                cli.Estado = true;
            };
            contex.Clientes.Add(cli);
            contex.SaveChanges();
            Console.WriteLine("Codigo: " + cli.Id + "Nombre: " + cli.Nombre + "Apellido: " + cli.Apellido + "Dirección: " + cli.Dirección + "Fecha Nacimiento: " + cli.FechaNacimiento + "Estado: " + cli.Estado);


        }
    }

    public static void Eliminar()
    {
        Console.WriteLine("Metodo eliminar estudiante por Id");
        ServicioContext context = new ServicioContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(4);
        context.Remove(cli);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre+ "Apellido: "+cli.Apellido+ "Dirección: " + cli.Dirección + "Fecha Nacimiento: " + cli.FechaNacimiento + "Estado: " + Convert.ToString(cli.Estado));
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        ServicioContext context = new ServicioContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(2);

        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }

    public static void modificarClientes()
    {
        Console.WriteLine("Metodo modificar estudiante");
        ServicioContext context = new ServicioContext();
        Cliente std = new Cliente();
        std = context.Clientes.Find(1);

        std.Nombre = "Perez";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.Id + " Nombre: " + std.Nombre);

    }


}

