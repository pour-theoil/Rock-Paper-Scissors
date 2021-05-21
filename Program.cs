using System;

void RockHand(int pick)
{
    if (pick == 1)
    {

        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
    ");
    }
    if (pick == 2)
    {
        Console.WriteLine(@"
     _______
-- - '  ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    }
    if (pick == 3)
    {
        Console.WriteLine(@"
    _______
-- - '   ____)____
            ______)
       __________)
      (____)
-- -.__(___)
    ");
    }

}


int playerscore = 0;
int computerscore = 0;
Play();
void Play()
{
    Console.Clear();
    if (playerscore == 3)
    {
        Console.WriteLine("You win!!!");
    }
    else if (computerscore == 3) 
    {
        Console.WriteLine("You lost to a computer...");
    }
    else
    {

        Console.WriteLine("-----------------------------");
        Console.WriteLine($"|Player: {playerscore} | Computer: {computerscore} |");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");


        string pick = Console.ReadLine();
        int playerpick = Int32.Parse(pick);

        Random i = new Random();
        int computerpick = i.Next(1, 3);
        RockHand(playerpick);
        Console.WriteLine("VS");
        RockHand(computerpick);
        System.Threading.Thread.Sleep(750);

        if (playerpick == computerpick)
        {
            Play();
        }
        else if (playerpick == 1)
        {
            if (computerpick == 2)
            {
                computerscore++;
                Play();
            }
            else
            {
                playerscore++;
                Play();
            }
        }
        else if (playerpick == 2)
        {
            if (computerpick == 3)
            {
                computerscore++;
                Play();
            }
            else
            {
                playerscore++;
                Play();
            }
        }
        else if (playerpick == 3)
        {
            if (computerpick == 1)
            {
                computerscore++;
                Play();
            }
            else
            {
                playerscore++;
                Play();
            }
        }
    }

}