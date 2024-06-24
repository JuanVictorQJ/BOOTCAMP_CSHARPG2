List<Dictionary<string, string>> listaEmpresas = new List<Dictionary<string, string>>();
Dictionary<string, string> empresaMuestra = new Dictionary<string, string>
{
    {"NOMBRE DE LA EMPRESA", "AZZORTI" },
    {"RUC", "201245625246" },
    {"RAZON SOCIAL", "S.R.L." },
    {"DIRECCION", "MACROPOLIS" }
};
listaEmpresas.Add(empresaMuestra); ;

int opcion = 0;
const int ANCHO = 50;

void MostrarTítulo(string título)
{
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 15) + título);
    Console.WriteLine(new string('=', ANCHO));
}

while (opcion != 3)
{
    Console.Clear();
    MostrarTítulo("CRUD DE EMPRESAS");
    Console.WriteLine(@"
        [1] REGISTRAR EMPRESA
        [2] MOSTRAR EMPRESAS
        [3] SALIR
    ");
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine("INGRESE UNA OPCION DEL MENU:  ");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            MostrarTítulo("[1] REGISTRAR EMPRESA");
            Console.WriteLine("NOMBRE DE LA EMPRESA:   ");
            string nombreEmpresa = Console.ReadLine();
            Console.WriteLine("RUC:   ");
            string ruc = Console.ReadLine();
            Console.WriteLine("RAZON SOCIAL:   ");
            string razonsocial = Console.ReadLine();
            Console.WriteLine("DIRECCION:    ");
            String direccion = Console.ReadLine();
            Dictionary<string, string> nuevaEmpresa = new Dictionary<string, string>
            {
                {"NOMBRE DE LA EMPRESA", nombreEmpresa },
                {"RUC", ruc },
                {"RAZON SOCIAL", razonsocial},
                {"DIRECCION", direccion },
            };
            listaEmpresas.Add(nuevaEmpresa);
            Console.Clear();
            MostrarTítulo("EMPRESA REGISTRADA CON EXITO");
            System.Threading.Thread.Sleep(1000);
            break;
        case 2:
            MostrarTítulo("[2] MOSTRAR EMPRESAS");
            foreach (var empresa in listaEmpresas)
            {
                Console.WriteLine(new string('*', ANCHO));
                foreach (var dicempresa in empresa)
                {
                    Console.WriteLine($"{dicempresa.Key} : {dicempresa.Value}");
                }
            }
            MostrarTítulo("PRESIONE UN TECLA PARA CONTINUAR");
            Console.ReadLine();
            break;
        case 3:
            MostrarTítulo("SALIENDO DEL SISTEMA.....");
            break;
        default:
            MostrarTítulo("OPCION NO VALIDA");
            System.Threading.Thread.Sleep(1000);
            break;
    }



}