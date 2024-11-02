using System;
using System.Collections.Generic;

List <string> FilmNames= new List<string>(); //Create a new list of string type.
List<double> FilmImdbScores = new List<double>();  //Create a new list of double type.

string Name = ""; //Required variables defined.
double ImdbScore = 0;
string Choise = "";

Start: //A starting point for the user to return to.

while (true) //We receive infinite input from the user with while loop.
{  
    Console.Write("Please enter a movie name: ");
    Name = Console.ReadLine();

    Imdb: //A starting point for the user to return to.
    Console.Write("Please enter a film Imdb Score(1-10):");
    ImdbScore = Convert.ToInt32(Console.ReadLine());

    if(ImdbScore < 1 || ImdbScore > 10) //If the condition is not met, it will be asked again with "goto".
    {
        Console.WriteLine("\nIncorrect enter. Please enter a number 1 between 10.\n");
        goto Imdb;
    }

    Console.Write("\nWould you like to add new movies?(Y/N): ");
    Choise = Console.ReadLine().ToUpper();
   
    FilmNames.Add(Name); //Inputs from the user have been added to the list.
    FilmImdbScores.Add(ImdbScore);

    if (Choise == "Y") //The process will continue or stop depending on the user's response.
    {
        goto Start;
    }
    else if (Choise == "N")
    {
        Console.WriteLine("\nMovie List: "); 
        for (int i = 0; i < FilmNames.Count; i++) //A query was written according to condition and the list was printed.
        {
            Console.WriteLine($"\nName: {FilmNames[i]}, IMDb Score: {FilmImdbScores[i]}");
        }

        Console.WriteLine("\nMovie List (Imdb score is 4 between 10): ");
        for (int i = 0; i < FilmImdbScores.Count; i++) //A query was written according to a different condition and the list was printed.
        {

            if (FilmImdbScores[i] > 4 && FilmImdbScores[i] <= 10)
            {
                Console.WriteLine($"\nName: {FilmNames[i]}");
            }
            else
            {
                Console.WriteLine("\nNo movie found Imdb score is 4 between 10.");
            }
        }

        Console.WriteLine("\nMovie List (Movies whose names start with 'A' and their Imdb socres): ");
        for (int i = 0; i < FilmNames.Count; i++) //A query was written according to a different condition and the list was printed.
        {
            if (FilmNames[i][0] == 'A') 
            {
                Console.WriteLine($"\nName: {FilmNames[i]}, IMDb Score: {FilmImdbScores[i]}");
            }
            else
            {
                Console.WriteLine("\nNo movie found movies whose names start with 'A'.");
            }
        }
        return;
    }
    else
    {
        Console.WriteLine("Incorrect entered, please try again."); //If the input was not what was requested, the user was reset to the beginning.
        goto Start;
    }
}
Console.ReadKey();
