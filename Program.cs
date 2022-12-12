// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido jugador a Adivinar el número");
Console.WriteLine("Te explico la reglas:");
Console.WriteLine("1. Tienes que adivinar el número del 1 al 15");
Console.WriteLine("2. Tienes que adivinar el número del 1 al 15");
string nombre = Console.ReadLine();
Console.WriteLine($"Tu nombre es {nombre}");


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido jugador a Adivinar el número");
Console.WriteLine("Te explico la reglas:");
Console.WriteLine("1. Tienes que adivinar el número del 1 al 15");

int random = new Random().Next(1, 15);
Console.WriteLine(random);

int i = 1;


do{
    Console.WriteLine("Mete un número del 1 al 15");
    int pedirNumeroAlUsuario = Int32.Parse(Console.ReadLine());
    if(random == pedirNumeroAlUsuario){
        Console.WriteLine("Perfecto, has acertado");
        break;
    }
    Console.WriteLine($"Has fallado, ahora tienes {3-i} intentos");
    i++;

    if (i == 3){
        Console.WriteLine($"Te quedan {3-i} intentos. No tienes más intentos, tu juego a terminado");
        Console.WriteLine($"El numero era {random}");
        
        break;
    }

} while (i <= 4);
