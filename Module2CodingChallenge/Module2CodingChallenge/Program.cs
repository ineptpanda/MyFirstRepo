
using Module2CodingChallenge;

//create a new Polygon object and a new square object
Polygon polygon = new Polygon(3); //a triangle
Square square = new Square(4.5f);

//Create a new Player object with one Life and add points to the player's score
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

//Display the player's score
Console.WriteLine("Welcome to the game! Your score is " + player.GetScore() + 
    " You have " +player.GetLivesLeft() + " lives left!");
Console.WriteLine();
//Player finds gold and displays total
Console.WriteLine("You start your adventure walking into the forest, you found 5 pieces of Gold, lucky!");
player.AddGold(5);
Console.WriteLine("You now have " + player.GetGold() + " gold.");
Console.WriteLine();

//player falls and loses 1 gold
Console.WriteLine("As you celebrate your find and think about what you plan on purchasing with your new found wealth" +
    " you trip on a unassuming rock and lose 1 gold coin, unlucky...");
player.SubtractGold(1);
Console.WriteLine("You now have " + player.GetGold() + " gold.");
Console.WriteLine();

//Kill off the player
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attackes you. Sorry, you were killed. You have "
    + player.GetLivesLeft() + " lives left!");