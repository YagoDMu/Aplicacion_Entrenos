using System.Collections;
using System.Net.Http.Headers;

class Usuario
{
    private string? nombre, correo,contraseña;

    List<Entreno> listaEntrenos = new List<Entreno>();



    public Usuario(){}

    public Usuario(string correo, string nombre, string contraseña)
    {
        this.correo = correo;
        this.contraseña = contraseña;
        this.nombre = nombre;
        
    }

// SETTERS
    public void setCorreo(string correo){
        this.correo = correo;
    }

    public void setConstraseña(string contraseña)
    {
        this.contraseña = contraseña;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

// GETTERS
    public string? getCorreo()
    {
        return correo;
    }

    public string? getContraseña()
    {
        return contraseña;
    }

    public string? getNombre(){
        return nombre;
    }

    public void registrarEntreno()
    {
        EntradaDatos entradaDatos = new EntradaDatos();
        Console.WriteLine("Introduce la distancia reocirrida (km):");
        double distancia = entradaDatos.doble();

        Console.WriteLine("Introduce el tiempo (min):");
        int tiempo = entradaDatos.entero();

        Entreno entreno = new Entreno(distancia,tiempo);
        listaEntrenos.Add(entreno);
        Console.WriteLine("Entreno registrado con éxito");
    }

    public void mostrarEntrenos()
    {
        foreach (Entreno item in listaEntrenos)
        {
            item.entrenoInfo();
        }
    }

    public void vaciarEntrenos()
    {
        listaEntrenos.Clear();
    }
}