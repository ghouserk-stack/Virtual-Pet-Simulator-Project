using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Virtual Pet Simulator");

        // Variable declaration and initialization
        int hunger = 5;
        int happiness = 5;
        int health = 8;
        int petoption;
        string petname = "";
        int petaction;
        bool perform1;
        bool perform2;
       
        //Displaying pet types to get user's choice
        Console.WriteLine("Plese choose a type of pet");
        Console.WriteLine("1.Cat");
        Console.WriteLine("2.Dog");
        Console.WriteLine("3.Rabbit");
        Console.WriteLine("");
        Console.Write("Pet Type: ");

        petoption = int.Parse(Console.ReadLine());


        //while loop for invalid petoption

        while (perform1) 
        {
            if (petoption != 1 && petoption != 2 && petoption != 3)
            {
                Console.WriteLine("Invalid pet type!");
                Console.Write("Please enter valid pet type: ");
                petoption = int.Parse(Console.ReadLine());

            }
            if (petoption == 1 || petoption == 2 || petoption == 3)
            {
                break;
            }
        }


        Console.WriteLine("");
        Console.Write("Please name your pet: ");
        petname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Welcome " + petname + "! Let's take good care of you.");

        //While loop for Main Menu iterations
        while (perform2) 
        {
            //keeping hunger on scale of 1 to 10
            while (hunger < 1)
            {
                hunger++;
            }
            while (hunger > 10)
            {
                hunger--;
            }
            //keeping health on scale of 1 to 10
            while (health < 1)
            {
                health++;
            }
            while (health > 10)
            {
                health--;
            }
            //keeping happiness on scale of 1 to 10
            while (happiness < 1)
            {
               happiness++;
            }
            while (happiness > 10)
            {
               happiness--;
            }
            
            //Warning messages
            if (hunger >= 9)
            {
                Console.WriteLine("Warning: Your pet is too hungry!");
            }
         
            if (happiness <= 2)
            {
                Console.WriteLine("Warning: Your pet is very unhappy");
            }
          
            if (health <= 1)
            {
                Console.WriteLine("Warning: Your pet's health is very poor");
            }


            //Main Menu and getting petaction from user
            Console.WriteLine("");
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Feed " + petname);
            Console.WriteLine("2.Play with " + petname);
            Console.WriteLine("3.Let " + petname + " rest");
            Console.WriteLine("4.Check " + petname + "'s status");
            Console.WriteLine("5.Exit");
            Console.WriteLine("");
            Console.Write("Pet Action: ");
            petaction = int.Parse(Console.ReadLine());

            //pet action conditions

            if (petaction == 1) //feed
            {
                if (hunger <= 1)
                {
                    Console.WriteLine(petname + " is full and doesn't want to eat.");
                }
                else
                {
                    hunger = hunger - 1; // simulates passage of time
                    if (hunger < 1) hunger = 1;
                    health += 1; // simulates passage of time
                    if (health > 10) health = 10;
                    Console.WriteLine("You fed " + petname + ". His hunger decreased, health slightly increases.");
                   
                }
               

            }// end feed
            else if (petaction == 2) //play
            {
                if (hunger >= 9)
                {
                    Console.WriteLine(petname + " is too hungry and don't want to play. "); //Special message
                }
                else if(health <= 2)
                {
                    Console.WriteLine(petname + "'s health is too bad to play!"); //Special message
                }
                happiness += 1; //simulates passage of time
                if (happiness >10) happiness = 10;
                hunger += 1; // simulates passge of time
                if(hunger > 10) hunger = 10;
                Console.WriteLine("You played with " + petname + ". His happiness increases and hunger slightly increases.");


            }// end play
            else if (petaction == 3) //rest
            {
                health += 1; // simulates passage of time
                if(health > 10) health = 10;
                happiness -= 1; // simulates passage of time
                if (happiness < 1) happiness=1;
                Console.WriteLine(petname + " is resting. His health improves and happiness slightly decreases");
            }// end rest

            else if (petaction == 4) // status check
            {
                Console.WriteLine(petname + "'s status");
                Console.WriteLine("Hunger:" + hunger);
                Console.WriteLine("Happiness:" + happiness);
                Console.WriteLine("Health:" + health);
            }//end status

            else if(petaction == 5) //exit
            {
                Console.WriteLine("Thank you for playing with " + petname + ". Good Bye!");
                break;
            }// end exit

           
           
            //consequence for neglect case

            if (hunger >= 10)
            {
                health -= 1;
                if (health < 1) health = 1;
                Console.WriteLine(petname + " is too hungry. His health deteriorates.");
            }

            if (happiness < 1)
            {
                health -= 1;
                if (health < 1) health = 1;
                Console.WriteLine(petname + " is very unhappy. His health deteriorates.");

            }




        } //end while(perform2)
       

    }

}