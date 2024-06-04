using System;


namespace Solo_Practice_CSharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.Process();
            }
        }
    }
}