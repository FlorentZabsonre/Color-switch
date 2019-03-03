using Color_Switch.Core;
using System;

namespace Color_Switch
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            MenuScreen m = new MenuScreen();
            /*
            if (m.choice == false)
            {
                using (var menu = new MenuScreen())
                    menu.Run();
                // Console.WriteLine(m.choice);
            }
            */
            // else
            /*
            if (m.choice == true )
            {
            */
                using (var game = new ColorSwitch())
                    game.Run();
            
                 
                
            
           
        }
    }
#endif
}
