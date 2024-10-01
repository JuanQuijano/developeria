using System;
using System.Globalization;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerXPosition = 0;
int playerYposition = 0;

// Console position of the food
int foodXPosition = 0;
int foodYPosition = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int foodIndex = 0;
int velocidad = 0;

InitializeGame();
while (!shouldExit)
{
    if (!TerminalResized())
    { Move(); }
    else
    { ClearAndFinish(); }
}

// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    foodIndex = random.Next(0, foods.Length);

    // Update food position to a random location
    foodXPosition = random.Next(0, width - player.Length);
    foodYPosition = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodXPosition, foodYPosition);
    Console.Write(foods[foodIndex]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    Console.SetCursorPosition(playerXPosition, playerYposition);
    Console.Write(player);

    if (playerXPosition == foodXPosition & playerYposition == foodYPosition)
    {
        player = states[foodIndex];
        if (foodIndex == 1) { velocidad = 3; }
        else { velocidad = 0; }
        ShowFood();
        if (foodIndex == 2) { FreezePlayer();}
    }
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move()
{
    int lastX = playerXPosition + velocidad;
    int lastY = playerYposition + velocidad;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerYposition--;
            break;
        case ConsoleKey.DownArrow:
            playerYposition++;
            break;
        case ConsoleKey.LeftArrow:
            playerXPosition--;
            break;
        case ConsoleKey.RightArrow:
            playerXPosition++;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerXPosition = (playerXPosition < 0) ? 0 : (playerXPosition >= width ? width : playerXPosition);
    playerYposition = (playerYposition < 0) ? 0 : (playerYposition >= height ? height : playerYposition);

    // Draw the player at the new location
    //Console.SetCursorPosition(playerXPosition, playerYposition);
    //Console.Write(player);

    ChangePlayer();
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

void ClearAndFinish()
{
    Console.Clear();
    Console.WriteLine("Console was resized. Program exiting.");
    shouldExit = true;
}