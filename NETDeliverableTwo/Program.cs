// See https://aka.ms/new-console-template for more information
//.NET DELIVERABLE 2: The COIN FLIP CHALLENGE


//Program Variables
string userName = "User";
//Declare a Random variable for use in random number generation later.
Random ranNum = new Random();
int score = 0;
int roundNum = 0;
int flipResult;
int userGuess;


//Challenge Begin Control Flow
Console.WriteLine("Welcome, " + userName + ". What's your name?");
//Update the userName variable based on user input.
userName = Console.ReadLine();
//Ask the user if they would like to play the challenge.
Console.WriteLine("Nice to meet you, " + userName + "! Would you like to do the COIN FLIP CHALLENGE?? Please enter 'yes' or 'no'.");
//The user's input is stored as a string to be compared later.
string gameStart = Console.ReadLine();

//If the user enters anything other than 'yes', end the program. (Will consider edge cases later)
if (gameStart != "yes")
{
    Console.WriteLine("Coward! Fine, maybe next time.");
}
//Assuming the user enters 'yes', the game begins!
else {
    Console.WriteLine("Great, let's play! You get five chances to guess whether I'll get 'heads' or 'tails'.");
    //Loop will run as long as the user has played fewer than five rounds, including the fifth round.
    while (roundNum < 5)
    {
        //Increment roundNum.
        roundNum++;
        //Generate a new random number to decide the flip outcome and update flipResult.
        flipResult = ranNum.Next(0, 2);     


        Console.WriteLine("Guess 'heads' or 'tails'.");

        string guessInput = Console.ReadLine();

        //If guessInput is valid, convert it to an int for comparison to flipResult. 
        if (guessInput == "heads" || guessInput == "tails")
        {
            //If guessInput is 'heads', update userGuess to 0. If it's 'tails', update guessInput to 1.
            if (guessInput == "heads")
            {
                userGuess = 0;
            } else
            {
                userGuess = 1;
            }
        //Update score based on whether or not the user guessed corerctly.
        if (userGuess == flipResult)
            {
                //Increment score.
                score++;
                Console.WriteLine("You got it! Plus one for you."); 
            } else
            {
                Console.WriteLine("Sorry, you guessed wrong. Better luck next time!");
            }
        } else 
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

//End of challenge flow.
Console.WriteLine("Challenge over! Your final score is: " + score);