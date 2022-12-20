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
      WriteOptions();
      var option = int.Parse(Console.ReadLine());

      HandleMenuOptions(option);
    }

    public static void DrawScreen() {

        Console.Write(" ==");
        for (int horizontalline = 0; horizontalline <= 34; horizontalline++) 
            Console.Write("=");
        Console.WriteLine("= "); 

        for (int verticalLine = 0; verticalLine <= 10; verticalLine++)
        {
            Console.Write(" |");
            for (int space = 0; space <= 35; space++)
                Console.Write(" ");
            Console.WriteLine("| ");

        }

        Console.Write(" |");
        for (int column = 0; column <= 35; column++)
            Console.Write("=");
        Console.WriteLine("| ");

    }

    public static void WriteOptions() { 

        Console.SetCursorPosition(15, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(8, 3);
        Console.WriteLine("========================");
        Console.SetCursorPosition(7, 4);
        Console.WriteLine("Selecione uma opção abaixo:");
        Console.SetCursorPosition(8, 6);
        Console.WriteLine("1- Novo arquivo");
        Console.SetCursorPosition(8, 7);
        Console.WriteLine("2- Abrir");
        Console.SetCursorPosition(8, 8);
        Console.WriteLine("0- Sair");
        Console.SetCursorPosition(8, 10);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOptions(int option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0: { Console.Clear(); Environment.Exit(0); break; }
            default: Menu.Show();break;
        }

    }

}
