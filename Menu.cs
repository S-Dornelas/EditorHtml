using System;

namespace EditorHTML
{

    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue; //cor de fundo 
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            DrawScreen();
            WriteOptions();

            Console.SetCursorPosition(9, 12);
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");


            for (int lines = 0; lines <= 12; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }


            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("        EDITOR HTML        ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Seleciona uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir Arquivo");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("Opção");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Novo(); break;
                case 2: Editor.Abrir(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
