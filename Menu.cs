/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; */
namespace EditorHTML;
  public static class Menu {

    public static void Show() {

      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      DrawScreen();
    }

    public static void DrawScreen() {

        Console.Write(" |=");
        for (int horizontalline = 0; horizontalline <= 54; horizontalline++) 
            Console.Write("=");
        Console.WriteLine("| "); 

        for (int verticalLine = 0; verticalLine <= 25; verticalLine++)
        {
            Console.Write(" |");
            for (int space = 0; space <= 55; space++)
                Console.Write(" ");
            Console.WriteLine("| ");

        }

        Console.Write(" |");
        for (int column = 0; column <= 55; column++)
            Console.Write("=");
        Console.WriteLine("| ");

    }

    public static void WriteOptions() { 
    }


}
