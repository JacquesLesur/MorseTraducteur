using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTraducteur
{
    public static class Program
    {
        //static Dictionary<char, string> translator;
        static string[][] translator;

        static void Main(string[] args)
        {
            InitialiseDictionary();
            Console.WriteLine("Tapez 1 pour traduire une phrase et 2 pour traduire du morse");
            string chiffre = Console.ReadLine();
            Console.WriteLine("Saisissez une phrase à traduire !");
            string saisie = Console.ReadLine();
            saisie = saisie.ToLower();
            if (chiffre == "1")
            {
                Console.WriteLine("ça veux dire :" + traduirePhrase(saisie));
            }
            else
            {
                Console.WriteLine("ça veux dire :" + traduireMorse(saisie));
            }
            Console.ReadLine();
        }
        public static void InitialiseDictionary()
        {
            char point = '.';
            char tiret = '-';

            translator = new string[][]
            {
               new string [] {"a", string.Concat(point, tiret)},
               new string [] {"b", string.Concat(tiret, point, point, point)},
               new string [] {"c", string.Concat(tiret, point, tiret, point)},
               new string [] {"d", string.Concat(tiret, point, point)},
               new string [] {"e", point.ToString()},
               new string [] {"f", string.Concat(point, point, tiret, point)},
               new string [] {"g", string.Concat(tiret, tiret, point)},
               new string [] {"h", string.Concat(point, point, point, point)},
               new string [] {"i", string.Concat(point, point)},
               new string [] {"j", string.Concat(point, tiret, tiret, tiret)},
               new string [] {"k", string.Concat(tiret, point, tiret)},
               new string [] {"l", string.Concat(point, tiret, point, point)},
               new string [] {"m", string.Concat(tiret, tiret)},
               new string [] {"n", string.Concat(tiret, point)},
               new string [] {"o", string.Concat(tiret, tiret, tiret)},
               new string [] {"p", string.Concat(point, tiret, tiret, point)},
               new string [] {"q", string.Concat(tiret, tiret, point, tiret)},
               new string [] {"r", string.Concat(point, tiret, point)},
               new string [] {"s", string.Concat(point, point, point)},
               new string [] {"t", string.Concat(tiret)},
               new string [] {"u", string.Concat(point, point, tiret)},
               new string [] {"v", string.Concat(point, point, point, tiret)},
               new string [] {"w", string.Concat(point, tiret, tiret)},
               new string [] {"x", string.Concat(tiret, point, point, tiret)},
               new string [] {"y", string.Concat(tiret, point, tiret, tiret)},
               new string [] {"z", string.Concat(tiret, tiret, point, point)},
               new string [] {"0", string.Concat(tiret, tiret, tiret, tiret, tiret)},
               new string [] {"1", string.Concat(point, tiret, tiret, tiret, tiret)},
               new string [] {"2", string.Concat(point, point, tiret, tiret, tiret)},
               new string [] {"3", string.Concat(point, point, point, tiret, tiret)},
               new string [] {"4", string.Concat(point, point, point, point, tiret)},
               new string [] {"5", string.Concat(point, point, point, point, point)},
               new string [] {"6", string.Concat(tiret, point, point, point, point)},
               new string [] {"7", string.Concat(tiret, tiret, point, point, point)},
               new string [] {"8", string.Concat(tiret, tiret, tiret, point, point)},
               new string [] {"9", string.Concat(tiret, tiret, tiret, tiret, point)}
            };
        }
        public static string traduirePhrase(string saisie)
        {
            InitialiseDictionary();
            StringBuilder sb = new StringBuilder();
            foreach (char lettre in saisie)
            {
                if (lettre == ' ')
                {
                    sb.Append("/ ");
                }
                {
                    foreach (string[] equivalences in translator)
                    {
                        if (equivalences[0] == lettre.ToString())
                        {
                            sb.Append(equivalences[1] + " ");

                        }
                      

                    }
                }
            }
            return sb.ToString(); 
        }

        public static string traduireMorse(string saisie)
        {
            InitialiseDictionary();
            string[] lettres = saisie.Split(' ');
            string phrase = "";
            foreach (string lettre in lettres) 
            {
                if (lettre == "")
                {
                    phrase += " ";
                }
                else
                {
                    foreach (string[] equivalences in translator)
                        if (equivalences[1] == lettre)
                        {
                            phrase += equivalences[0];

                        }
                }
                /* foreach (var test in translator)
                 {
                     translator.ContainsValue
                     string tesdfs;
                 }*/
            }
           
            return phrase;
        }
    }
}
