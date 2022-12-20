using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{

    public static class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("       __________________");
            Console.WriteLine("       |   Modo Editor   |");
            Console.WriteLine("       |_________________|");
            Console.WriteLine();
            Console.Write("     ");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            WriteOptions();
            int option = int.Parse(Console.ReadLine());
            HandleMenuOptions(option);
        }


    public static void WriteOptions()
    {
        Console.WriteLine();
        Console.WriteLine(" Deseja salvar o arquivo?");
        Console.WriteLine(" -----------------------");
        Console.WriteLine(" 1- Sim / 2- Não");
        Console.WriteLine(" 0- Voltar");
        Console.WriteLine();
        Console.Write("Opção: "); 

        }

    public static void HandleMenuOptions(int option)
    {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: { Menu.Show(); break; }
            }

        }

    }
}
