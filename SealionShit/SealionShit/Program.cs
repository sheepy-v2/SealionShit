
using SealionShit.View;

namespace SealionShit
{
    /// <summary>
    /// The Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args"></param>
        static public void Main(String[] args)
        {
            Game game = new Game();

            game.start();
        }
    }
}