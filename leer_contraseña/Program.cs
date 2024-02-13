// See https://aka.ms/new-console-template for more information
Console.WriteLine("leer cantidad de numeros");
Console.WriteLine();


{
    string contraseña = "micha"; 
    int intentos = 3;

    while (intentos > 0)
    {
        Console.Write("Ingrese la contraseña: ");
        string entrada = Console.ReadLine();

        if (entrada == contraseña)
        {
            Console.WriteLine("¡Contraseña correcta!");
            return;
        }
        else
        {
            intentos--;
            Console.WriteLine("Contraseña incorrecta. Te quedan " + intentos + " intentos.");
        }
    }

    Console.WriteLine("Has agotado el número de intentos. El programa terminará.");
}


