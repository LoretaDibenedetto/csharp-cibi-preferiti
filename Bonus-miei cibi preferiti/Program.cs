
Console.WriteLine("--------------quanti cibi preferiti hai?---------------------------");

Console.WriteLine("inserisci quanti cibi preferiti hai");
//strnga che prende input di quanti cibi preferiti ha l'user
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