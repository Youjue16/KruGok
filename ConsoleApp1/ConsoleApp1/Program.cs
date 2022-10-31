using System;

namespace ConsoleApp1
{
    public class Dyb
    {
        public class Syndyk
        {
            public class Zaich
            {
                public class Ytka
                {
                    public class Egg
                    {
                        public class Needle
                        {
                        }
                    }
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            if (false)
            {
                int qwe = 90;
                double das = 90.9;
                string fasgdf = "dasdas";
            }

            if (false)
            {
                Console.WriteLine("Введите данные");
                System.String Str = "Привет мир";
                Str = Console.ReadLine();
                Console.WriteLine("Веденные данные приняты");
                Console.WriteLine(Str);
                Console.ReadLine();
            }
            else if (false)
            {
                int qwe = 90;
                System.Byte rewqweq = 0;
                double das = 90.9;
                string fasgdf = "dasdas";
                System.Boolean _flag = true;
                if (_flag) { System.Console.WriteLine("True"); } else { System.Console.WriteLine("False"); }
            }
            else if (false)
            {
                var _qwe = new ConsoleApp1.Dyb.Syndyk.Zaich.Ytka.Egg.Needle();
                System.Console.WriteLine("_qwe.ToString()=" + _qwe.ToString());
                System.Console.WriteLine("_qwe.GetType().Name=" + _qwe.GetType().Name);
                System.Console.WriteLine("_qwe.GetType().FullName=" + _qwe.GetType().FullName);
            }
            else if (false)
            {
                System.Boolean _flag = true;
                System.Console.WriteLine(_flag.ToString());
                ////////////////////////////////////////////////////////////////////////////
                System.Console.WriteLine("true&true=" + (true & true).ToString());
                System.Console.WriteLine("true&false=" + (true & false).ToString());
                System.Console.WriteLine("false&false=" + (false & false).ToString());
                ////////////////////////////////////////////////////////////////////////////
                System.Console.WriteLine("true | true=" + (true | true).ToString());
                System.Console.WriteLine("true | false=" + (true | false).ToString());
                System.Console.WriteLine("false | false=" + (false | false).ToString());
                //
            }
            else if (!false) 
            {
                for (int i = 0; i < 10; i++) System.Console.WriteLine(i);
                System.Console.WriteLine("##############################");
                for (int i = 9; i >=0; i--) System.Console.WriteLine(i);
            }
            else if (!false)
            {
                for (int i = 0; i < 10; i++) System.Console.WriteLine(i);
                System.Console.WriteLine("##############################");
                for (int i = 9; i >= 0; i--) System.Console.WriteLine(i);
            }
        }
    }
}