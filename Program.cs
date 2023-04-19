using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expressions_19._04._2023
{
    delegate string myDel(int _number);//берет метод и возвращает строку
     class Program
    {
        static string NumName(int _number)
        {
            Console.WriteLine("NumName");
            string result = string.Empty;
            switch (_number)
            {
                case 0: result = "ноль";
                    break;
                    
                default:
                    break;
            }
            return result;
        }
        static string test(int _num)
        {
            Console.WriteLine("test");
            return "test";
        }
        static void Main(string[] args)
        {
            myDel print = NumName;
            print = test;
            print = NumName;
            print(0);
           // Console.WriteLine(print(0)); 




           /* string input = "Наташа наташа";
            if (args.Length > 0) {
                input = args[0];    
            }
            Regex regex = new Regex(@"(Наташа)", RegexOptions.RightToLeft);
            MatchCollection matchfind = regex.Matches(input);
            int counter = 0;
            foreach (var item in matchfind) {
                Console.WriteLine($"Совпадение номер {counter} {item}");
                counter++;*/
            }
        }
    }

