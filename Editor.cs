using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Abrir()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-------EDITOR DE TEXTO---------");
            Console.WriteLine("");
            Console.WriteLine("Qual arquivo deseja abrir?");
            Console.WriteLine("-------------------------------");

            string path = Console.ReadLine();
            string texto = "";

            using (var file = new StreamReader(path))
            {
                string escrita = file.ReadToEnd();
                Console.WriteLine(escrita);

                do
                    texto += Console.ReadLine();

                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Salvar(texto);
            Menu.Show();
        }
        public static void Novo()
        {
            Console.Clear();
            Console.WriteLine("-------EDITOR DE TEXTO---------");
            Console.WriteLine("");
            Console.WriteLine("    DIGITE O TEXTO DESEJADO    ");
            Console.WriteLine("        (ESC para sair)        ");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);
            Menu.Show();
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho você deseja salvar?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu.Show();
        }
    }

}
