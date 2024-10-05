using System;
using System.Diagnostics;

/* CONTOSO Pets Appálication */

/*
 * TODO
 *
 * Add predefined sample data to the pets array.
 * Iterate a "menu options and user selection" code block to establish
 *   the outer loop of your application.
 * Implement code branches corresponding to the user's menu selections.
 * Display all the information contained in the array used to store pet
 *   data (based on user's menu selection).
 * Iterate an "add new animal information" code block that enables the 
 *   user to add one or more new animals to the pets array (based on 
 *   user's menu selection).
 */

/* 
 * TODO
 *
 * Store application data in a multidimensional string array named ourAnimals.
 * The ourAnimals array includes the following "pet characteristics" for each animal:
 *  - Pet ID #.
 *  - Pet species (cat or dog).
 *  - Pet age (years).
 *  - A description of the pet's physical condition/characteristics.
 *  - A description of the pet's personality.
 *  - The pet's nickname.
 *
 * Implement a sample dataset that represents dogs and cats currently in your care.
 * Display menu options to access the main features of the application.
 *
 * The main features enable the following tasks:
 * - List the pet information for all animals in the ourAnimals array.
 * - Add new animals to the ourAnimals array. The following conditions apply:
 *   - The pet species (dog or cat) must be entered when a new animal is added to the ourAnimals array.
 *   - A pet ID must be programmatically generated when a new animal is added to the ourAnimals array.
 *   - Some physical characteristics for a pet may be unknown until a veterinarian's examination.
 *       For example: age, breed, and neutered/spayed status.
 *   - An animal's nickname and personality may be unknown when a pet first arrives.
 * - Ensure animal ages and physical descriptions are complete. This may be required after a
 *     veterinarian's examination.
 * - Ensure animal nicknames and personality descriptions are complete (this action can occur
 *     after the team gets to know a pet).
 * - Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).
 * - Edit an animal’s personality description (a pet may behave differently after spending more time in our care).
 * - Display all cats that meet user specified physical characteristics.
 * - Display all dogs that meet user specified physical characteristics.
 */

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult; // When reading user entered values with the Console.ReadLine() method, it's best to use a nullable type.
string menuSelection = "";

/* Using a nullable string is best practice for capturing input from the ReadLine() method. Once you verify that the input value isn't null, you assign the value to a standard string variable named menuSelection. This process enables you to evaluate the menu selection value without a concern for null values. Many of the methods that accept strings as an input parameter will generate an error if they're passed a null value. If you don't follow this input pattern, the code compiler is likely to generate a warning when you build your project. */

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options
    Console.Clear();
    Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.Trim().ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    // readResult = Console.ReadLine();

    switch(menuSelection)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("List all of our current pet information\n");

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i,j]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Add a new animal friend to the ourAnimals array");

            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;
                }
            }

            Console.WriteLine($"\nWe currently have {petCount} pets that need homes.\nWe can manage {(maxPets - petCount)} more.\n");

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;
                // get the pet's species
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.Trim().ToLower();

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                animalID = animalSpecies.Substring(0,1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry. 
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult.Trim();
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.Trim().ToLower();

                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.Trim().ToLower();

                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.Trim().ToLower();

                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");



                /* Display latest entries */
                Console.Clear();
                Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
                Console.WriteLine("Add a new animal friend to the ourAnimals array\n");
                Console.WriteLine("Please review your entries and confirm:");
                Console.WriteLine($"Animal Species     : {animalSpecies}");
                Console.WriteLine($"Animal ID          : {animalID}");
                Console.WriteLine($"Animal Age         : {animalAge}");
                Console.WriteLine($"Animal Description : {animalPhysicalDescription}");
                Console.WriteLine($"Animal Personality : {animalPersonalityDescription}");
                Console.WriteLine($"Animal Nickname    : {animalNickname}");

                string confirm = "n";
                do{

                    Console.WriteLine("\nAre the above details correct? Enter 'y' to accept and save, 'n' to restart.");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        confirm = readResult.Trim().ToLower();

                        if (confirm != "y" && confirm != "n")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                if (confirm == "y")
                {
                    // store the pet information in the ourAnimals array (zero based)
                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
                    petCount++;
                }

                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet? (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.Trim().ToLower();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Ensure animal ages and physical descriptions are complete");
            Console.WriteLine("this app feature is under construction - please check back to see progress.");

            // string anotherPet = "y";
            // int petCount = 0;

            goto through the array of all the stored pets.
            Check which ones which have ID not set to default value.
           If one is found, check if age is set
           If age is not set ask user to enter a valid age wrap in do while
           and validate age. 
           Check if it has a description - wrap in do while
           validate
           Add age and description to current pet
           Move to next pet and repeat



            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // petCount++;
                }
            }







            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Edit an animal’s age");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Edit an animal’s personality description");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Display all cats with a specified characteristic");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("Display all dogs with a specified characteristic");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "exit":
            Console.Clear();
            Console.WriteLine("\u001b[4mCONTOSO Pets Application\u001b[0m\n\n");
            Console.WriteLine("You have now exited the application.\n\n");
            break;
        default:
            break;

    }


} while (menuSelection != "exit");

/* 

https://learn.microsoft.com/en-us/training/modules/guided-project-develop-conditional-branching-looping/5-exercise-build-loop-new-array-data

        CONTINUE from step Check your work

 */
