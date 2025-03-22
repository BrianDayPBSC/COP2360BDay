using System.Collections;
using System.Collections.Generic;

public class dictionaryProject
{
    public static void Main()
    {
        Dictionary<int, string> myDictionary = new Dictionary<int, string> // This is the creation of the dictioanry. -Brian
        {
            {1, "Good"},
            {2, "morning"},
            {3, "everyone"}
        };

        Console.WriteLine("What would you like to do?"); // This is the question for the user to choose which part of the switch statement they would like to do. -Brian
        string toDo = Console.ReadLine();

        switch (toDo)
        {
            case "Display": // This is to display the contents of the dictionary. -Brian
                foreach (KeyValuePair<int, string> kvp in myDictionary)
                {
                    Console.WriteLine(kvp.Key + " ");
                    Console.WriteLine(kvp.Value);
                }
                break;
            case "Remove": //This is to remove a key value pair from the dictionary. -Brian
                myDictionary.Remove(1);
                foreach (KeyValuePair<int, string> kvp in myDictionary)
                {
                    Console.WriteLine(kvp.Key + " ");
                    Console.WriteLine(kvp.Value);
                }
                break;
            case "Add":
                myDictionary.Add(4, ":)"); // This is to add a new key value pair to the dictionary. -Brian
                foreach (KeyValuePair<int, string> kvp in myDictionary)
                {
                    Console.WriteLine(kvp.Key + " ");
                    Console.WriteLine(kvp.Value);
                }
                break;
            case "Update": // This is to change a value for a key in the dictionary. -Brian
                myDictionary[2]="Night";
                foreach (KeyValuePair<int, string> kvp in myDictionary)
                {
                    Console.WriteLine(kvp.Key + " ");
                    Console.WriteLine(kvp.Value);
                }
                break;
            default: // This is for if the user inputs a command that is not covered by the switch statment. -Brian
                Console.WriteLine("Not an option");
                break;
        }
    }
}