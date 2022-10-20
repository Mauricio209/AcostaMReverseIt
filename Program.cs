
//Mauricio Acosta
//10-19-22
//GitHub Reverse It

string playAgain = "yes";
while (playAgain == "yes")
{
Console.WriteLine("Im a reverse machiene type in any number or word and ill reverse it for you");

string userInput = Console.ReadLine();


for(int i = userInput.Length - 1; i >= 0; i--)
{
Console.WriteLine(userInput[i]);
}

Console.WriteLine("Type yes to play again or no to quit");
playAgain = Console.ReadLine();

}