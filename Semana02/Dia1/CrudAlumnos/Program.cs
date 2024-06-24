List<Dictionary<string, string>> listaAlumnos = new List<Dictionary<string, string>>();
Dictionary<string, string> alumnoMuestra = new Dictionary<string, string>
{
    {"nombre", "Juan Quispe" },
    {"email", "juanvquispe@gmail.com" },
    {"Celular", "981413307" }
};
listaAlumnos.Add(alumnoMuestra); ;

int opcion = 0;
const int ANCHO = 50;

void MostrarTítulo (string título)
{
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 15) + título);
    Console.WriteLine(new string('=', ANCHO));
}

while (opcion != 5)
{
    Console.Clear();
    MostrarTítulo("CRUD DE ALUMNOS");
    Console.WriteLine(@"
        [1] REGISTRAR ALUMNO
        [2] MOSTRAR ALUMNO
        [3] ACTUALIZAR ALUMNO
        [4] ELIMINAR ALUMNO
        [5] SALIR
    ");
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine("INGRESE UNA OPCION DEL MENU:  ");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            MostrarTítulo("[1] REGISTRAR ALUMNO");
            Console.WriteLine("NOMBRE:   ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL:   ");
            string email = Console.ReadLine();
            Console.WriteLine("CELULAR:   ");
            string celular = Console.ReadLine();
            Dictionary<string, string> nuevoAlumno = new Dictionary<string, string>
            {
                {"nombre", nombre },
                {"email", email},
                {"Celular", celular}
            };
            listaAlumnos.Add(nuevoAlumno);
            Console.Clear();
            MostrarTítulo("ALUMNO REGISTRADO CON EXITO");
            System.Threading.Thread.Sleep(1000);
            break;
        case 2:
            MostrarTítulo("[2] MOSTRAR ALUMNO");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', ANCHO));
                foreach (var dicalumno in alumno)
                {
                    Console.WriteLine($"{dicalumno.Key} : {dicalumno.Value}");
                }
            }
            MostrarTítulo("PRESIONE UN TECLA PARA CONTINUAR");
            Console.ReadLine();
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            MostrarTítulo("SALIENDO DEL SISTEMA.....");
            break;
        default:
            MostrarTítulo("OPCION NO VALIDA");
            System.Threading.Thread.Sleep(1000);
            break;

    }



}