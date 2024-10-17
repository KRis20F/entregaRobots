class Program {

    public static void Main(string[] args)
    {
        List<Robots> listaRobots = new List<Robots>(){
            new DroideProtocolo("Aless", 1, 80),
            new DroideAstromecanic("Alvardross", 2, 69, DateTime.Now),
            new DroideCombate("Reifas'Pissa", 3, 50, 10),
        };


        int userOption = 0;

        do
        {
            viewOption();
            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                    AddRobot(listaRobots);
                    break;
                case 2:
                    MostrarTodosLosRobots(listaRobots);
                    break;
                case 3:
                    Console.Write("Ingrese la categoría de robots a mostrar: ");
                    int categoria = int.Parse(Console.ReadLine()!);
                    MostrarRobotsPorCategoria(listaRobots, categoria);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (userOption != 4);
        
        Console.WriteLine("Programa finalizado.");
    }

    // Menú de opciones
    static void viewOption()
    {
        Console.WriteLine("Hola, bienvenido a ramdons robots jefe");
        Console.WriteLine("1. Insertar Robot");
        Console.WriteLine("2. mostrar todos los robots");
        Console.WriteLine("3. Mostrar robots por categoria");
        Console.WriteLine("4. Exit");
        Console.Write("Insert your option: ");
    }


    static public void AddRobot(List<Robots> robots)
    {

        Console.WriteLine("Elige el tipo de robot a agregar:");
        Console.WriteLine("1. Droide Astromecánico");
        Console.WriteLine("2. Droide de Combate");
        Console.WriteLine("3. Droide de Protocolo");
        int tipoRobot = int.Parse(Console.ReadLine());

        Console.Write("Introduce el nombre del robot: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Introduce el nivel de batería: ");
        int bateria = int.Parse(Console.ReadLine());

        switch (tipoRobot)
        {
            case 1:
                Console.Write("Introduce la fecha de la última reparación (dd/mm/yyyy): ");
                DateTime ultimaReparacion = DateTime.Parse(Console.ReadLine());
                robots.Add(new DroideAstromecanic(nombre,tipoRobot , bateria, ultimaReparacion));
                break;
            case 2:
                Console.Write("Introduce el nivel de potencia de fuego: ");
                int potenciaFuego = int.Parse(Console.ReadLine());
                robots.Add(new DroideCombate(nombre, tipoRobot,bateria, potenciaFuego));
                break;
            case 3:
                robots.Add(new DroideProtocolo(nombre, tipoRobot,bateria));
                break;
            default:
                Console.WriteLine("Tipo de robot no válido.");
                break;
        }

        Console.WriteLine($"Robot {nombre} añadido correctamente.");

    }

    static public void MostrarRobotsPorCategoria(List<Robots> robots ,int categoria)
    {
        Console.WriteLine($"\nMostrando robots de tipo {categoria}:");

        foreach (Robots robot in robots)
        {
            if (robot.TipoUnidad == categoria)
            {
                robot.viewDetails();
            }
        }
    }

    static public void MostrarTodosLosRobots(List<Robots> robots)
    {
        Console.WriteLine("\nMostrando todos los robots:");
        foreach (Robots robot in robots)
        {
            robot.viewDetails();
        }
    }    


}