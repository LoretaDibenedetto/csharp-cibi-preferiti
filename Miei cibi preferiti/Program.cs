

using System.Collections;

string[] favoritFood = { "pomodori all'insalata", "carbonara", "patate al forno", "focaccia barese", "sushi", "patatine fritte con cheddar" };

    Console.WriteLine("i miei cibi preferiti in totale sono: " +  favoritFood.Length);


    Console.WriteLine("------------------------------------------------------------");

ArrayList(favoritFood);





void ArrayList(string[] array)
{
        Console.WriteLine("-----inizio lista di cibi preferiti--------");
    for (int i = 1; i < array.Length; i++)
    {
        Console.WriteLine((i) + " " + array[i]);
    }

       Console.WriteLine("---------fine lista----------------");
    preferFood(array);
}

void preferFood(string[] array)
{
    Console.WriteLine("il mio preferito fra tutti e': " + array[3]);

}