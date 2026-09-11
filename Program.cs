//Chris Estrada
//9-11-26
//Mini-Challenge 6
//created a program with an if else loop within a do while loop that asks the user to enter a whole number
// and tells them if it's even or odd using modulo. Then the program asks the user to play again, looping if 
// the answer is yes and stopping if the answer is no
//Peer Review:
//Review:

string playerAnswer;
do
{
Console.WriteLine("Please enter a whole number");

string oddOrEven = Console.ReadLine();

int newOddOrEven = Convert.ToInt32 (oddOrEven) % 2;

if(newOddOrEven == 0)
{
    Console.WriteLine ("Your number is Even");
} 
else
{
    Console.WriteLine ("Your Number is Odd");
}

    Console.WriteLine("Would you like to play again? YES/NO?");
    playerAnswer = Console.ReadLine().ToUpper(); 
    
if (playerAnswer == "NO")
    {
        Console.WriteLine("OK, See you later!");
    }


} while (playerAnswer == "YES");
