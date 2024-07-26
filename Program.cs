string? readResult;
string menuSelection = "";

// string[,] ourAnimals = new string[maxPets, 7];

// top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to FITR:");
    Console.WriteLine(" 1. Start recording your combos");
    Console.WriteLine(" 2. Change notation settings");
    Console.WriteLine(" 3. Change keybindings");
    Console.WriteLine(" 4. Change your input device");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":

            string[] searchingIcons = { " |", " /", "--", " \\", " *" };

            System.ConsoleKey? exitSelection;
            exitSelection = Console.ReadKey(intercept: true);
            do
            {
                foreach (string icon in searchingIcons)
                {
                    Console.Write($"\rRecording... {icon}");
                    Thread.Sleep(100);
                }
                // Console.Write($"\r{new String(' ', Console.BufferWidth)}");
            }
            while (exitSelection != "q");

            // list all pet info
            // for (int i = 0; i < maxPets; i++)
            // {
            //     if (ourAnimals[i, 0] != "ID #: ")
            //     {
            //         Console.WriteLine();

            //         for (int j = 0; j < 7; j++)
            //         {
            //             Console.WriteLine(ourAnimals[i, j].ToString());
            //         }
            //     }
            // }

            // Console.WriteLine("\r\nPress the Enter key to continue");
            // readResult = Console.ReadLine();

            break;

        case "2":
            // // #1 Display all dogs with a multiple search characteristics

            // string dogCharacteristics = "";

            // while (dogCharacteristics == "")
            // {
            //     // #2 have user enter multiple comma separated characteristics to search for
            //     Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
            //     readResult = Console.ReadLine();

            //     if (readResult != null)
            //     {
            //         dogCharacteristics = readResult.ToLower();
            //         Console.WriteLine();
            //     }
            // }

            // string[] dogSearches = dogCharacteristics.Split(",");
            // // trim leading and trailing spaces from each search term
            // for (int i = 0; i < dogSearches.Length; i++)
            // {
            //     dogSearches[i] = dogSearches[i].Trim();
            // }

            // Array.Sort(dogSearches);
            // // #4 update to "rotating" animation with countdown
            // string[] searchingIcons = {" |", " /", "--", " \\", " *"};

            // bool matchesAnyDog = false;
            // string dogDescription = "";

            // // loops through the ourAnimals array to search for matching animals
            // for (int i = 0; i < maxPets; i++)
            // {
            //     if (ourAnimals[i, 1].Contains("dog"))
            //     {

            //         // Search combined descriptions and report results
            //         dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
            //         bool matchesCurrentDog = false;

            //         foreach (string term in dogSearches)
            //         {
            //             // only search if there is a term to search for
            //             if (term != null && term.Trim() != "")
            //             {
            //                 for (int j = 2; j > -1 ; j--)
            //                 {
            //                     // #5 update "searching" message to show countdown
            //                     foreach (string icon in searchingIcons)
            //                     {
            //                         Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
            //                         Thread.Sleep(100);
            //                     }

            //                     Console.Write($"\r{new String(' ', Console.BufferWidth)}");
            //                 }

            //                 // #3a iterate submitted characteristic terms and search description for each term
            //                 if (dogDescription.Contains(" " + term.Trim() + " "))
            //                 {
            //                     // #3b update message to reflect current search term match 

            //                     Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

            //                     matchesCurrentDog = true;
            //                     matchesAnyDog = true;
            //                 }
            //             }
            //         }

            //         // #3d if the current dog is match, display the dog's info
            //         if (matchesCurrentDog)
            //         {
            //             Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
            //         }
            //     }
            // }

            // if (!matchesAnyDog)
            // {
            //     Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristics);
            // }

            // Console.WriteLine("\n\rPress the Enter key to continue");
            // readResult = Console.ReadLine();

            break;

        default:
            break;
    }
}
while (menuSelection != "exit");
