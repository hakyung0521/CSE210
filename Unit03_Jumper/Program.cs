using Unit03_Jumper.game;


namespace unit03_jumper
{
    class Program
    {
        /// Starts the program using the given arguments.
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}