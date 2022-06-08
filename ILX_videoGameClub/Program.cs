Console.WriteLine("Welcome to Intelex Video Game Club");

/*
 * Variables
 * platform - string
 * gameName - string
 * memberName - string
 * memberEmail - string
 * isBorrowed - soolean
 * dateBorrowed - dateTime()
 * quantity - sbyte
 * 
 * Methods
 * borrowGame(gameName, memberName)
 * returnGame(gameName, memberName)
 * addGame(gameName, quantity)
 * removeGame(gameName, quantity)
 * 
 */


string memberName = "Gabriel Silva";
string memberEmail = "Gabriel.silva@intelex.com"

DateTime dateBorrowed = new DateTime();


namespace ILX_videoGameClub
{
    public class GameInventory
    {
        string platform = "PS5";
        string gameName = "Horizon Forbiden West";
        sbyte quantity = 1;
        bool isBorrowed = true;
    }
}