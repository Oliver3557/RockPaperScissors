//Declarations

int win = 0;
int draw = 0;
int loss = 0;
int input;
bool keepGoing = true;

Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.WriteLine("To Play, enter the number corresponding to the item you want to pick!\n");

while (keepGoing)
{
    Console.WriteLine("1. Rock   2. Paper   3. Scissors");
    input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Rock();
            break;

        case 2:
            Paper();
            break;

        case 3:
            Scissors();
            break;

        default:
            Console.WriteLine("Invalid Selection");
            break;
    }
    

    void Rock()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 4);

        Console.WriteLine("\nYou Chose ROCK!");

        if(number == 1)
        {
            Console.WriteLine("\nI Choose Rock, DRAW!\n");
            draw += 1;
        }else if(number == 2)
        {
            Console.WriteLine("\nI Choose Paper, YOU LOSE!\n");
            loss += 1;
        }else if (number == 3)
        {
            Console.WriteLine("\nI Choose Scissors, YOU WIN!\n");
            win += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Paper()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 4);

        Console.WriteLine("\nYou Chose PAPER!");

        if (number == 1)
        {
            Console.WriteLine("\nI Choose Rock, YOU WIN!\n");
            win += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nI Choose Paper, DRAW!\n");
            draw += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nI Choose Scissors, YOU LOSE!\n");
            loss += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }

    void Scissors()
    {
        //Generate random response
        Random rnd = new Random();
        int number = rnd.Next(1, 4);

        Console.WriteLine("\nYou Chose SCISSORS!");

        if (number == 1)
        {
            Console.WriteLine("\nI Choose Rock, YOU LOSE!\n");
            loss += 1;
        }
        else if (number == 2)
        {
            Console.WriteLine("\nI Choose Paper, YOU WIN!\n");
            win += 1;
        }
        else if (number == 3)
        {
            Console.WriteLine("\nI Choose Scissors, DRAW!\n");
            draw += 1;
        }

        Console.WriteLine("W:{0}  D:{1}  L:{2}\n", win, draw, loss);
    }
}