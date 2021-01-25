using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer newGamer = new NewGamer();
            Gamer oldGamer = new OldGamer();

            newGamer.TcNo = "12345687910";
            newGamer.FirstName = "Begüm";
            newGamer.LastName = "Ünal";
            newGamer.Year = 2001;

            oldGamer.TcNo = "22222222222";
            oldGamer.FirstName = "Mehmet";
            oldGamer.LastName = "Ünal";
            oldGamer.Year = 2001;

            GamerMethods gamerMethods = new GamerMethods();
            gamerMethods.Add(newGamer);
            gamerMethods.Updete(newGamer);
            gamerMethods.delete(newGamer);

            Game1 game1 = new Game1();
            Game2 game2 = new Game2();

            game1.Price = 250;

            Games games = new Games();
            games.Sale(game1.Price);


        }
    }
}
