

// Random rnd = new Random();
// int computerGuess = rnd.Next(1, 10);
// Console.WriteLine("Welcome to Tic Tac Toe!");
// Console.WriteLine("Player 1, please enter your move (1-9):");
// int playerGuess = 0;
// while (true)
// {
//     string input = Console.ReadLine();
//     if (int.TryParse(input, out playerGuess) && playerGuess >= 1 && playerGuess <= 9)
//     {
//         if (playerGuess == computerGuess)
//         {
//             Console.WriteLine("You guessed the computer's move! You win!");
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"You guessed: {playerGuess}. The computer's move was: {computerGuess}. Try again!");
//             Console.WriteLine("Player 1, please enter your next move (1-9):");
//         }
//     }
//   else if (playerGuess < 1 || playerGuess > 9)
//   {
//     Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
//   }



// }








Random random = new Random();
int player2 = random.Next(1, 10);
int player1 =0;
int attempt = 0;

Console.WriteLine("WELCOME TO GAMING WORLD!\n");
Console.WriteLine("Computer has made its move");
Console.WriteLine("Enter your first move");


while (true)
{

  string response = Console.ReadLine();
  if (int.TryParse(response, out player1) && player1 >= 0 && player1 <= 9)
  {
    attempt++;
    if (player1 == player2)
    {
      Console.WriteLine($" You played {player1} and Computer played {player2}. You won");
      Console.WriteLine($"Great catch! You played {attempt} times!");
      Console.WriteLine("Do you want to play again? (yes/no)");
       response = Console.ReadLine().ToLower();
      if (response == "yes")
      {
        player2 = random.Next(1, 10);
        attempt = ++attempt; // Increment attempt for the new game
        Console.WriteLine("Computer has made its move again. Enter your next guess:");
        response = Console.ReadLine();

        player1 = int.Parse(response);
        // Reset player1 for the next round
        // player2 /= 2; // Simulating a new computer move for the next round
        if (player1 == player2)
        {
          Console.WriteLine($"You played {player1} and Computer played {player2}. You won again!");
          Console.WriteLine($"Great catch! You played {attempt} times!");
        }
        else
        {
          Console.WriteLine($"You played {player1} and Computer played {player2}. Try again!");
          Console.WriteLine("Enter your Guess number");
          player2 /= 2;
        }
      }
      else
      {
        Console.WriteLine("Thanks for playing! Goodbye!");
        break;
      }
    }
    else
    {
      Console.WriteLine($" You played {player1} and Computer played {player2}.Try again!");
      Console.WriteLine("Enter your Guess number");
    }
  }
  else
  {
    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
  }

}











// using System;

// namespace TicTacToe
// {
// class Program
// {
// static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
// static int player = 1;
// static int choice;
// static int flag = 0;

// static void Main(string[] args)
// {
// do
// {
// Console.Clear();
// Console.WriteLine("Player1:X and Player2:O");
// Console.WriteLine("\n");
// if (player % 2 == 0)
// {
// Console.WriteLine("Player 2 Chance");
// }
// else
// {
// Console.WriteLine("Player 1 Chance");
// }
// Console.WriteLine("\n");
// Board();
// choice = int.Parse(Console.ReadLine());

// if (arr[choice] != 'X' && arr[choice] != 'O')
// {
// if (player % 2 == 0)
// {
// arr[choice] = 'O';
// player++;
// }
// else
// {
// arr[choice] = 'X';
// player++;
// }
// }
// else
// {
// Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
// Console.WriteLine("\n");
// Console.WriteLine("Please wait 2 seconds, board is loading again.....");
// System.Threading.Thread.Sleep(2000);
// }

// flag = CheckWin();
// } while (flag != 1 && flag != -1);

// Console.Clear();
// Board();
// if (flag == 1)
// {
// Console.WriteLine("Player {0} has won", (player % 2) + 1);
// }
// else
// {
// Console.WriteLine("Draw");
// }
// Console.ReadLine();
// }

// private static void Board()
// {
// Console.WriteLine(" | | ");
// Console.WriteLine(" {0} | {1} | {2}", arr[1], arr[2], arr[3]);
// Console.WriteLine("_____|_____|_____ ");
// Console.WriteLine(" | | ");
// Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);
// Console.WriteLine("_____|_____|_____ ");
// Console.WriteLine(" | | ");
// Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);
// Console.WriteLine(" | | ");
// }

// private static int CheckWin()
// {
// #region Horizontal Winning Condition
// if (arr[1] == arr[2] && arr[2] == arr[3]) return 1;
// else if (arr[4] == arr[5] && arr[5] == arr[6]) return 1;
// else if (arr[6] == arr[7] && arr[7] == arr[8]) return 1;
// #endregion

// #region Vertical Winning Condition
// else if (arr[1] == arr[4] && arr[4] == arr[7]) return 1;
// else if (arr[2] == arr[5] && arr[5] == arr[8]) return 1;
// else if (arr[3] == arr[6] && arr[6] == arr[9]) return 1;
// #endregion

// #region Diagonal Winning Condition
// else if (arr[1] == arr[5] && arr[5] == arr[9]) return 1;
// else if (arr[3] == arr[5] && arr[5] == arr[7]) return 1;
// #endregion

// #region Checking For Draw
// else if (arr.All(x => x != '0' && x != '1' && x != '2' && x != '3' && x != '4' && x != '5' && x != '6' && x != '7' && x != '8' && x != '9')) return -1;
// #endregion

// else return 0;
// }
// }
// }