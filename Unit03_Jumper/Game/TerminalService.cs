using System;


namespace Unit03_Jumper.game
{
    /// A service that handles terminal operations.
    /// The responsibility of a TerminalService is to provide input and output operations for the terminal.
    public class TerminalService
    {
        /// Constructs a new instance of TerminalService.
        public TerminalService()
        {
        }

        /// Gets numerical input from the terminal. Directs the user with the given prompt.
        /// <param name="prompt">The given prompt.
        /// <returns>Inputted number.
        public string ReadGuess(string prompt)
        {
            string rawValue = ReadText(prompt);
            return rawValue;
        }

        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// <param name="prompt">The given prompt.
        /// <returns>Inputted text.
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// Displays the given text on the terminal. 
        /// <param name="text">The given text.
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}