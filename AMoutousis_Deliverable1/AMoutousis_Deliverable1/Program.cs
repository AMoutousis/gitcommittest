using System;

namespace AMoutousis_Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            string travelSuggestion;
            string destination;
            int groupSize;


            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();

            if (vacationType == "musical")
                destination = "New Orleans";
            else if (vacationType == "tropical")
                destination = "Beach Vacation in Mexico";
            else
                destination = "Whitewater Rafting the Grand Canyon";

            Console.WriteLine("How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());
                

            if (groupSize <= 2)
                travelSuggestion = "First Class";
            else if (groupSize <= 5)
                travelSuggestion = "Helicopter";
            else
                travelSuggestion = "Charter Flight";
            

            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelSuggestion + " to a " + destination + "!";
            Console.WriteLine(result);
        }
    }
}
