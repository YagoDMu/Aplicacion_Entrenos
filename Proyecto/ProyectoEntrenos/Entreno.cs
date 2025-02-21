class Entreno
{
    double distancia;

    int tiempo;
    EntradaDatos entradaDatos = new EntradaDatos();
    
    public Entreno()
    {
        
        Console.WriteLine("Introduce la distancia reocirrida (km):");
        distancia = entradaDatos.doble();

        Console.WriteLine("Introduce el tiempo (min):");
        tiempo = entradaDatos.entero();
        
    }

    public Entreno(double distancia, int tiempo)
    {
        this.distancia = distancia;
        this.tiempo = tiempo;
    }

    public void setDistancia(double distancia)
    {
        this.distancia = distancia;
    }
    public void setTiempo(int tiempo)
    {
        this.tiempo = tiempo;
    }
    public double getDistancia()
    {
        return distancia;
    }
    public int getTiempo()
    {
        return tiempo;
    }
    public void entrenoInfo()
    {
        Console.WriteLine("{0} Km // {1} min",distancia,tiempo);
    }

}