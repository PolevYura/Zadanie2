using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void gg(string str)
        {
            int a = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'f') a++;

                if (a == 2 && str[i] == 'f')
                {
                    int index = str.IndexOf(str[i + 1]);
                    Console.WriteLine(index - 1);
                    break;
                }
            }
            if (a == 1) Console.WriteLine(1);
            if (a == 0) Console.WriteLine(2);
        }

        static void perevod(string str)
        {
            Dictionary<string, string> dictionaryChar = new Dictionary<string, string>()
            {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","y"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","ts"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","i"},
                {"ь","'"},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"}
            };

            string res = "";

            foreach (var ch in str)
            {
                string ss = "";

                if (dictionaryChar.TryGetValue(ch.ToString(), out ss))
                {
                    res += ss;
                }
                else res += ch;
            }
            Console.WriteLine(res);
        }

        static void H(string str)
        {
            string str2 = "";

            for (int i = 0; i < str.Length; i++)
            {
                int index = str.IndexOf(str[i]);

                if (str[i] == 'h' && i != 0 && i != str.Length - 1) str2 += 'H';
                else str2 += str[i];
            }

            Console.WriteLine(str2);
        }

        static void Main(string[] args)
        {
            //1
            gg("jkmnadfsdkaj");

            //2
            perevod("перевод текста");

            //3
            H("fhehhjk");
        }
    }
}

