using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readAFile
{
    class Program
    {
        public static string read_from_file(string adressOfFile) //ne pas oublier les doubles \\ pour l'adresse du fichier exemple : "C:\\Users\\blayid\\Documents\\Mines\\Info\\textfileIceSL.txt"
        {
            string text = System.IO.File.ReadAllText(adressOfFile);
            return text;
        }
        static void Main(string[] args)
        {
        }
    }
}
