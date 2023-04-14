

using System.Collections;

string[] favoritFood = { "pomodori all'insalata", "carbonara", "patate al forno", "focaccia barese", "sushi", "patatine fritte con cheddar" };

    Console.WriteLine("i miei cibi preferiti in totale sono: " +  favoritFood.Length);


    Console.WriteLine("------------------------------------------------------------");

ArrayList(favoritFood);





void ArrayList(string[] array)
{
   for(int i  = 1; i < array.Length; i++)
    {
        Console.WriteLine((i) + " " + array[i]);
    }

   
}

