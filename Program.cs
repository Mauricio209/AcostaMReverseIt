
//Mauricio Acosta
//10-19-22
//GitHub Reverse It

string playAgain = "yes";
while (playAgain == "yes")
{
Console.WriteLine("Choose several numbers");

string userInput = Console.ReadLine();


for(int i = userInput.Length - 1; i >= 0; i--)
{
Console.WriteLine(userInput[i]);
}

Console.WriteLine("Type yes to play again");
playAgain = Console.ReadLine();

}