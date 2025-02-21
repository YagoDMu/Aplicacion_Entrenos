using System.ComponentModel;

class Entrada
{
    
    private static Dictionary<string,Usuario> listaUsuarios = new Dictionary<string,Usuario>();
    
    public static void Main(string[] args)
    {
        
        EntradaDatos entradaDatos = new EntradaDatos();


        int opcionUsuario=0;


        do
        {
            Console.WriteLine("Que operación desea realizar?");
            Console.WriteLine("(1) Registar usuario");
            Console.WriteLine("(2) Iniciar sesión");
            Console.WriteLine("(3) Salir");
            opcionUsuario = entradaDatos.enteroRango(1,3);

            switch(opcionUsuario)
            {
                case 1:
                    registrarUsuario();
                    break;

                case 2:
                    iniciarSesion();
                    break;

                case 3:
                    break;

                default:
                    break;
            }
        }while(opcionUsuario != 3);
    }

    public static void registrarUsuario()
    {
        bool contraseñaIgual = false;
        bool nombreRepetido;
        string nuevaContraseña = "1234";
        string nombreUsuario = "usuario";
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("REGISTRAR USUARIO");
        Console.WriteLine();
        Console.WriteLine("Introduce tu correo:");
        string? correoNuevo = Console.ReadLine();
        Console.WriteLine();
        

        if(!listaUsuarios.ContainsKey(correoNuevo))
        {
            do
            {
            nombreRepetido = false;
            Console.WriteLine("Introduce tu nombre de usuario:");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine();

                foreach (Usuario item in listaUsuarios.Values)
                {
                    if(string.Equals(item.getNombre(),nombreUsuario))
                    {
                        nombreRepetido = true;
                        Console.WriteLine("El nombre se usuario ya está en uso, por favor elige otro");
                        break;
                    }
                }

            }while(nombreRepetido);

            do
            {
                Console.WriteLine("Introduce tu contraseña:");
            nuevaContraseña = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Vuelve a introducir tu contraseña:");
            string compruebaContraseña = Console.ReadLine();
            Console.WriteLine();

            contraseñaIgual = string.Equals(nuevaContraseña,compruebaContraseña);
            if(!contraseñaIgual)
            {
                Console.WriteLine("Las contraseñas no son iguales");
            }

            } while(!contraseñaIgual);

            Usuario usuario = new Usuario(correoNuevo,nombreUsuario,nuevaContraseña);
            listaUsuarios.Add(correoNuevo,usuario);

            Console.WriteLine("USUARIO CREADO CON ÉXITO");
            Console.WriteLine();
            
        }else{
            Console.WriteLine("ESE CORREO YA ESTÁ REGISTRADO");
            Console.WriteLine();
        }



    }
    public static void iniciarSesion()
    {

        int opcion = 0;
        EntradaDatos entradaDatos = new EntradaDatos();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("INICIO DE SESIÓN");
        Console.WriteLine();
        Console.WriteLine("Introduce tu correo:");
        string? correoUsuario = Console.ReadLine();
        Console.WriteLine();

        if(!listaUsuarios.ContainsKey(correoUsuario))
        {
            Console.WriteLine("USUARIO NO ENCONTRADO");
            Console.WriteLine("Pruebe con otro correo o regístrese como nuevo usuario");
        }else
        {
            Console.WriteLine("Introduce tu contraseña:");
            string? contraseñaUsuario = Console.ReadLine();
            Console.WriteLine();

            Usuario usuario = listaUsuarios[correoUsuario];

            if(string.Equals(contraseñaUsuario,usuario.getContraseña()))
            {

                Console.WriteLine("Bienvenido, "+usuario.getNombre());
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Que operación deseas realizar?");
                    Console.WriteLine("(1) Registrar entreno");
                    Console.WriteLine("(2) Ver entrenos");
                    Console.WriteLine("(3) Vaciar lista de entrenos");
                    Console.WriteLine("(4) Cerrar sesión");
                    opcion = entradaDatos.enteroRango(1,4);

                    switch (opcion)
                    {
                    case 1:
                        usuario.registrarEntreno();
                        break;

                    case 2:
                        usuario.mostrarEntrenos();
                        break;

                    case 3:
                        usuario.vaciarEntrenos();
                        break;

                    case 4:
                        break;

                    default:
                        break;
                    }
                }while(opcion != 4);
            }
        }
    }
}