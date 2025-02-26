﻿// See https://aka.ms/new-console-template for more information
//.NET DELIVERABLE 2: The COIN FLIP CHALLENGE


//Program Variables
string userName = "User";
//Declare a Random variable for use in random number generation later.
Random ranNum = new Random();
int score = 0;
int roundNum = 0;


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
    }
}