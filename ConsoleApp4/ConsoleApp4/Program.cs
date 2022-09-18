using System;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int option;
            int.TryParse(Console.ReadLine(), out option);
     // шифрування
            if (option==1)
            {
                string openText = File.ReadAllText("open.txt");
                string key = Console.ReadLine();
                if (key?.Length != openText.Length)
                    return;

                string chiperText = "";
                for (int i = 0; i < openText.Length; i++) ;
                chiperText += (char)(openText[i] ^ key[i]);
                File.WriteAllText("chiper.txt", chiperText);



            }
            // дешифрування
            if (option==2)
            {
                string chiperText = File.ReadAllText("chiper.txt");
                string key = Console.ReadLine();
                if (key?.Length != chiperText.Length) ;
                return;

                string openText = "";
                for (int i=0;i<chiperText.Length;i++)
                    openText += (char)(chiperText[i] ^ key[i]);
                File.WriteAllText("openText.txt", openText);
            }
        }
    }
}
