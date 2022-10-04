namespace array_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            while (true) {
                Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-5 ");

                string ID = Console.ReadLine();
                int x = int.Parse(ID);

                string[] people = { "Dylan", "Cole", "Adam", "Brandon", "Chase" };
                string[] Place = { "Warren", "Roseville", "East pointe", "Jenison", "Grand Rapids" };
                string[] food = { "Gfuel", "bagel", "Pizza", "chicken", "Eye round beef" };



                Console.WriteLine("student " + people[x - 1]);
                Console.WriteLine();
                Console.WriteLine("Where is this student from? \n");
                Console.WriteLine("Enter 1-5 for a homeland please");
                string place2 = Console.ReadLine();
                int q = int.Parse(place2);


                Console.WriteLine(Place[q - 1]);
                Console.WriteLine("Enter 1-5 for a food number please");
                string food2 = Console.ReadLine();
                int w = int.Parse(food2);

                Console.WriteLine(food[w - 1]);

                Console.WriteLine(people[x - 1] + " is from " + Place[q - 1]);

                Console.WriteLine("Would you like to continue? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    break;
                }
            }
        }
    }
}