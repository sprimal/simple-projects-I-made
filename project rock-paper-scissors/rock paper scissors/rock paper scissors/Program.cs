//simple rock paper scissors game
// in the random.next(0,3) 0 is the lower bound and 3 is the upper bound so the number generated will be 0,1,2 do if 0 then rock if 1 then scissor if 2 then paper
int playerscore = 0;
int enemyscore = 0;
Random random = new Random();
Console.WriteLine("welcome to rock paper scissors!!");
//the game will end when the player or the enemy will reach 4 scores first
while(playerscore != 3 && enemyscore != 3)
{
    Console.WriteLine($"player score-{playerscore} enemy score-{enemyscore}");
    Console.WriteLine("please enter r for rock, s for scissors, p for paper");
    string playerchoice= Console.ReadLine();
    int  enemychoice= random.Next(0,3);
    switch (enemychoice)
    {
        case 0:
            Console.WriteLine("the enemy choses rock");
            switch (playerchoice)
            {
                case "r":
                    Console.WriteLine("IT'S A TIE");
                    break;
                case "s":
                    Console.WriteLine("you lose!!!");
                    enemyscore++;
                    break;
                case "p":
                    Console.WriteLine("you win!");
                    playerscore++;
                    break;

            }
        break;
        case 1:
            Console.WriteLine("the enemy choses paper");
            switch (playerchoice)
            {
                case "r":
                    Console.WriteLine("you lose!!!");
                    enemyscore++;
                    break;
                case "s":
                    Console.WriteLine("you win!");
                    playerscore++;
                    break;
                case "p":
                    Console.WriteLine("IT'S A TIE!!");
                    break;

            }
            break;
        case 2:
            Console.WriteLine("the enemy choses scissors");
            switch (playerchoice)
            {
                case "r":
                    Console.WriteLine("you win!");
                    playerscore++;
                    break;
                case "s":
                    Console.WriteLine("IT'S A TIE!!!");
                    break;
                case "p":
                    Console.WriteLine("you lose!!!");
                    enemyscore++;
                    break;

            }
            break;
  

    }
}
if (playerscore == 3)
{
    Console.WriteLine("congratsyou smashed it");
}
else
{
    Console.WriteLine("better luck next time");
}
