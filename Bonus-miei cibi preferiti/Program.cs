
using System.ComponentModel.Design;

Console.WriteLine("--------------quanti cibi preferiti hai?---------------------------");

Console.WriteLine("inserisci quanti cibi preferiti hai");
//variabile che prende una strnga che prende input di quanti cibi preferiti ha l'user 
string inputUser = Console.ReadLine();

//conversione da stringa a num
int inputUserNumber = int.Parse(inputUser);


//dichiaro un array di stringhe con dentro l'input di sopra dell'user
string[] preferFoodUser = new string[inputUserNumber];



//ciclo l'array per la sua lunghezza e aggiungo i cibi preferiti attraverso l'input dell'user 
for(int i = 0; i < preferFoodUser.Length; i++)
{
    Console.WriteLine($"inserisci {i+ 1} cibo preferito");
    preferFoodUser[i] = Console.ReadLine();
}


printArraystr(preferFoodUser);

medianArrayPrint(preferFoodUser);


//funzione per stampare la lista 
void printArraystr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write((i + 1) + " " + array[i]);
        }
        else
        {
            Console.Write((i + 1) + " " + array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

void medianArrayPrint(string[] array)

{

   

    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length / 2)
            {
                Console.WriteLine("----------------la posizione a meta' e': " + array[i]);
            }
       
     }
    
}