//main

string userInput = GetUserInput(); // prime read
while(userInput != "4") //argument
{
    string navigationPrompt = Navigation(userInput);
    string activity = TravelServiceActivity(navigationPrompt);
    string arrival = TravelServiceArrival (activity);
    ConvertCurrency(navigationPrompt);
    ShippingInvoice(navigationPrompt);
    if (userInput == "3")
    {
        DisplayTravelPlans(activity, arrival);
    }
    ConsumerSurvey();
    userInput = GetUserInput(); //update read
}
System.Console.WriteLine("Thank you :)");

//end main

static string GetUserInput()
{
    System.Console.WriteLine("\nSelect what you want.\n1. Convert Currency\n2. Shipping Invoice\n3. Travel Service\n4. Exit\n");
    return Console.ReadLine().ToLower();
}

static string Navigation(string userInput)
{
    switch (userInput)
    {
        case "1":
            System.Console.WriteLine("Please enter what currency you would like to convert to U.S. Dollars:\n\nJapanese Yen\nChinese Yuan\nBritish Pound\nDoubloons\nAlgerian Dinar\n");
            break;
        case "2":
            return "shipping invoice";
            break;
        case "3":
            System.Console.WriteLine("Please enter where you like to go:\n\n1. Booty Cove\n2. Rum Runner's Retreat\n3. Scurvy Sands\n4. Planwalker's Paradice\n5. Pegleg Point\n6. Yo Ho Ho Island\n7. Cursed Coconut Cave");
            break;
        case "4":
            return "exit";
            break;
        default:
            System.Console.WriteLine("Invalid Response. Please try again.");
            break;
    }
    return Console.ReadLine();
}

static string TravelServiceActivity(string navigationPrompt)
{
    switch (navigationPrompt)
    {
        case "1":
            return "dig up burried treasure or go to the 'Best Pirate Laugh' contest";
            break;
        case "2":
            return "compete in the legendary 'Drink 'n' Duel' or go coconut bowling with cannonballs";
            break;
        case "3":
           return "play 'Catch the Lime' or race crabs on the beach";
            break;
        case "4":
            return "bet on who can walk the plank the fastest or play hide-and-seek in a shipwreck";
            break;
        case "5":
            return "have a pegleg relay race or craft a matching pegleg with your parrot";
            break;
        case "6":
            return "do sea shanty karaoke or carve your name into the 'Wall of Scallywags'";
            break;
        case "7":
            return "play coconut dodgeball or attempt to break the cave's legendary 'Unbreakable Coconut'";
            break;
        default:
            return "Invalid please try again";
            break;
    }
}

static string TravelServiceArrival(string activity)
{
    switch (activity)
    {
        case "dig up burried treasure or go to the 'Best Pirate Laugh' contest":
            return "arrive in an inflatable pirate ship to show the enemy that you are not a threat.";
            break;
        case "compete in the legendary 'Drink 'n' Duel' or go coconut bowling with cannonballs":
            return "arrive on a raft made up of used rum barrels. Our enemies are love recycling so they will only let you pass if they see that your raft is made out of used barrels.";
            break;
        case "play 'Catch the Lime' or race crabs on the beach":
            return "arrive riding on one of our sea turtles.";
            break;
        case "bet on who can walk the plank the fastest or play hide-and-seek in a shipwreck":
            return "arrive by catapult. We have a catapult placed on a neighboring island. We have also placed a solf cushion where we hope you will land. Good Luck!";
            break;
        case "have a pegleg relay race or craft a matching pegleg with your parrot":
            return "arrive on a standard raft but to be permitted on the island you must perform an underwater synchonized dance.";
            break;
        case "do sea shanty karaoke or carve your name into the 'Wall of Scallywags'":
            return "arrive singing the sea shanty 'Yo Ho A Pirate's Life Is For Me'.";
            break;
        case "play coconut dodgeball or attempt to break the cave's legendary 'Unbreakable Coconut'":
            return "arrive with a flock of seagulls that you caught on your travels.";
            break;
        default:
            return "invalid";
            break;
    }
}

static void DisplayTravelPlans(string activity, string arrival)
{
    System.Console.WriteLine($"Have so much fun with your plans! Your options for your destination are to {activity}. You must know that you should {arrival} Safe travels on the deadly seven seas!");
}

static void ConvertCurrency(string navigationPrompt)
{
    if (navigationPrompt == "Japanese Yen" || navigationPrompt == "japanese yen")
    {
        System.Console.WriteLine("Please enter the amount of Yen");
        double yen = int.Parse(Console.ReadLine());
        double yenToDollar = yen*0.0064;
        System.Console.WriteLine($"The amount in USD is ${yenToDollar}");
    }
    if (navigationPrompt == "Chinese Yuan" || navigationPrompt == "chinese yuan")
    {
        System.Console.WriteLine("Please enter the amount of Yuan");
        double yuan = int.Parse(Console.ReadLine());
        double yuanToDollar = yuan*0.14;
        System.Console.WriteLine($"The amount in USD is ${yuanToDollar}");
    }
    if (navigationPrompt == "British Pound" || navigationPrompt == "british pound")
    {
        System.Console.WriteLine("Please enter the amount of British Pounds");
        double pound = int.Parse(Console.ReadLine());
        double poundToDollar = pound*1.22;
        System.Console.WriteLine($"The amount in USD is ${poundToDollar}");
    }
    if (navigationPrompt == "Doubloons" || navigationPrompt == "doubloons")
    {
        System.Console.WriteLine("Please enter the amount of Doubloons");
        double doubloons = int.Parse(Console.ReadLine());
        double doubloonsToDollar = doubloons*8.4;
        System.Console.WriteLine($"The amount in USD is ${doubloonsToDollar}");
    }
    if(navigationPrompt == "Algerian Dinar" || navigationPrompt == "algerian dinar")
    {
        System.Console.WriteLine("Please enter the amount of Dinar");
        double dinar = int.Parse(Console.ReadLine());
        double dinarToDollar = dinar*0.0074;
        System.Console.WriteLine($"The amount in USD is ${dinarToDollar}");
    }
}

static void ShippingInvoice(string navigationPrompt)
{
    if (navigationPrompt == "shipping invoice")
    {
        System.Console.WriteLine("How many Tons are you shipping?");
        double tons = double.Parse(Console.ReadLine());
        double weightCost = (tons*220.40);
        System.Console.WriteLine($"Right now your shipping cost is ${weightCost}.\n");

        System.Console.WriteLine("Is your parcle perishable?");
        string perishable = Console.ReadLine();
        if (perishable == "yes"|| perishable =="Yes"|| perishable=="YES")
        {
            double perishableCost = ((weightCost/tons)*230);
            System.Console.WriteLine($"\n${perishableCost} will be added to your order.\n");

            System.Console.WriteLine("Would you like express shipping?");
            string express = Console.ReadLine();
            if (express == "yes"|| express == "Yes"|| express =="YES")
            {
                double expressCost = ((weightCost+perishableCost)*0.25)+(weightCost+perishableCost);
                System.Console.WriteLine($"\nYour total cost is ${expressCost} \n  {weightCost} for the weight \n+ {perishableCost} for shipping a perishable\n+ 25% for express\n= {expressCost}");
                System.Console.WriteLine($"You owe ${expressCost} how much would you like to pay");
                double amountPaid = double.Parse(Console.ReadLine());
                if (amountPaid == expressCost)
                {
                    System.Console.WriteLine("Thank for your payment!");
                }
                if (amountPaid>expressCost)
                {
                    System.Console.WriteLine($"You have paid too much. Your change is ${amountPaid - expressCost}");
                }
                if (amountPaid<expressCost)
                {
                    System.Console.WriteLine($"You have paid too little please pay the rest: ${expressCost-amountPaid}");
                }
            
            } else
            {
                if (express == "no" || express == "No"|| express == "NO")
                {
                    double expressCost = weightCost + perishableCost;
                    System.Console.WriteLine($"\nYour total cost is ${expressCost} \n  {weightCost} for the weight \n+ {perishableCost} for shiiping a perishable\n= {expressCost}");

                    System.Console.WriteLine($"You owe ${expressCost} how much would you like to pay");
                    double amountPaid = double.Parse(Console.ReadLine());
                    if (amountPaid == expressCost)
                    {
                        System.Console.WriteLine("Thank for your payment!");
                    }
                    if (amountPaid>expressCost)
                    {
                        System.Console.WriteLine($"You have paid too much. Your change is ${amountPaid - expressCost}");
                    }
                    if (amountPaid<expressCost)
                    {
                        System.Console.WriteLine($"You have paid too little please pay the rest: ${expressCost-amountPaid}");
                    }
                }
            }
        } else 
         {
            if (perishable == "no" || perishable == "No"|| perishable == "NO")
            {
                System.Console.WriteLine("Would you like express shipping?");
                string express = Console.ReadLine();
                if (express == "yes"|| express == "Yes"|| express =="YES")
                {
                    double expressCost = (weightCost*0.25)+weightCost;
                    System.Console.WriteLine($"\nYour total cost is ${expressCost} \n  {weightCost} for the weight \n+ 25% for express\n= {expressCost}");
                    System.Console.WriteLine($"You owe ${expressCost} how much would you like to pay");
                    double amountPaid = double.Parse(Console.ReadLine());
                    if (amountPaid == expressCost)
                    {
                        System.Console.WriteLine("Thank for your payment!");
                    }
                    if (amountPaid>expressCost)
                    {
                        System.Console.WriteLine($"You have paid too much. Your change is ${amountPaid - expressCost}");
                    }
                    if (amountPaid<expressCost)
                    {
                        System.Console.WriteLine($"You have paid too little please pay the rest: ${expressCost-amountPaid}");
                    }
            
                } else
                {
                    if (express == "no" || express == "No"|| express == "NO")
                    {
                        double expressCost = weightCost;
                        System.Console.WriteLine($"\nYour total cost is ${expressCost} \n  {weightCost} for the weight \n= ${expressCost}");

                        System.Console.WriteLine($"You owe ${expressCost} how much would you like to pay");
                        double amountPaid = double.Parse(Console.ReadLine());
                        if (amountPaid == expressCost)
                        {
                            System.Console.WriteLine("Thank for your payment!");
                        }
                        if (amountPaid>expressCost)
                        {
                            System.Console.WriteLine($"You have paid too much. Your change is ${amountPaid - expressCost}");
                        }
                        if (amountPaid<expressCost)
                        {
                            System.Console.WriteLine($"You have paid too little please pay the rest: ${expressCost-amountPaid}");
                        }
                    }
                }
            }
         }
    }
}

static void ConsumerSurvey()
{
    System.Console.WriteLine("\nOn a scale of 1-10 how would you rate this sevice on quality");
    double quality = double.Parse(Console.ReadLine());
    System.Console.WriteLine("\nOn a scale of 1-10 how effective was this service");
    double effective = double.Parse(Console.ReadLine());
    System.Console.WriteLine("\nOn a scale of 1-10 how happy did this service make you");
    double happiness = double.Parse(Console.ReadLine());
    double rating = (quality+effective+happiness)/3;
    System.Console.WriteLine($"Thank you for rating this service! You rated it {rating}");
}