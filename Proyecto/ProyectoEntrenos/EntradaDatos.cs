using System.ComponentModel;

class EntradaDatos
{

    public int entero()
    {
        int numero = 0;
        bool valido;

        do{
            string? numeroTexto = Console.ReadLine();
            Console.WriteLine();
            valido = int.TryParse(numeroTexto, out numero);

            if(!valido)
            {
                Console.WriteLine("Entrada no valida, prueba otra vez");
            }

        }while(!valido);
        
        return numero;
    }
    public int enteroRango(int min, int max)
    {
        int numero = 0;
        bool valido;

        do{
            string? numeroTexto = Console.ReadLine();
            Console.WriteLine();
            valido = int.TryParse(numeroTexto, out numero);

            if(!valido)
            {
                Console.WriteLine("Entrada no valida, prueba otra vez");
            }else if(numero < min || numero > max)
            {
                valido = false;
                Console.WriteLine("Entrada no valida, prueba otra vez");
            }

        }while(!valido);
        
        return numero;
    }

    public double doble()
    {
        double numero = 0;
        bool valido;

        do{
            string? numeroTexto = Console.ReadLine();
            Console.WriteLine();
            valido = double.TryParse(numeroTexto, out numero);

            if(!valido)
            {
                Console.WriteLine("Entrada no valida, prueba otra vez");
            }

        }while(!valido);
        
        return numero;
    }
    
}