// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido jugador a Adivinar el número");
Console.WriteLine("Te explico la reglas:");
Console.WriteLine("1. Tienes que adivinar un número del 1 al 15");

int random = new Random().Next(1, 15);
int contador  = 1;

const int numeroMaximoDeIntentos = 3;

do{
    Console.WriteLine("Mete un número del 1 al 15");
    int pedirNumeroAlUsuario = Int32.Parse(Console.ReadLine());
    
    if (pedirNumeroAlUsuario > 15 || pedirNumeroAlUsuario < 0 ){
        Console.WriteLine("El número tiene que ser un numero entre 15 y 0");
        
    }else{
        if(random == pedirNumeroAlUsuario){
            Console.WriteLine($"Perfecto, has acertado el numero en el {contador}º intento");
            break;
        }else{
            if (random < pedirNumeroAlUsuario){
            Console.WriteLine("Has fallado, tu numero está por debajo");
            }else if(random > pedirNumeroAlUsuario){
                Console.WriteLine("Has fallado, tu numero está por encima");
            }
            Console.WriteLine($"Ahora tienes {numeroMaximoDeIntentos - contador} intentos");
        }
        
        contador++;

        if (contador > numeroMaximoDeIntentos){
            Console.WriteLine("Te quedan 0 intentos. No tienes más intentos, tu juego a terminado");
            Console.WriteLine($"El numero era {random}");
            
            break;
        }
    }

} while (contador <= 4);
