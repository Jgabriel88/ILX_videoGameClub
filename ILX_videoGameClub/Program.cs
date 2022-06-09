using ILX_videoGameClub;



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




DateTime dateBorrowed = new DateTime();

Member member001 = new Member();
member001.memberName = "Gabriel Silva";
member001.memberEmail = "gabriel.silva@intelex.com";

Game game0001 = new Game();
game0001.platform = "PS5";
game0001.gameName = "Horizon Forbidden West";
game0001.isBorrowed = true;


ILX_videoGameClub.Game.RentGame(game0001);
