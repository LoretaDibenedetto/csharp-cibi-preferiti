

using System.Collections;

string[] favoritFood = { "pomodori all'insalata", "carbonara", "patate al forno", "focaccia barese", "sushi", "patatine fritte con cheddar" };

    Console.WriteLine("i miei cibi preferiti in totale sono: " +  favoritFood.Length);


    Console.WriteLine("---------------------------------------------------------------");

ArrayList(favoritFood);





void ArrayList(string[] array)
{
        Console.WriteLine("-----inizio lista di cibi preferiti--------");
    for (int i = 1; i < array.Length; i++)
    {
        Console.WriteLine((i) + " " + array[i]);
    }

       Console.WriteLine("---------fine lista-------------------------");
    preferAndWorstFood(array);
}

void preferAndWorstFood(string[] array)

{
    Console.WriteLine("----cibo preferito tra tutti e cibo meno preferito--------------");
    Console.WriteLine("il mio preferito fra tutti e': " + array[3]);
    Console.WriteLine("il mio cibo meno preferito e': " + array[4]);

}



