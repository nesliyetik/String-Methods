using System;

namespace stringmethods

{
    class Program
    {

        static void Main (string[] args)
        {
            string degisken = "Dersimiz Csharp Hoşgeldiniz!";
            string degisken2 = "Csharp";

            //length
            Console.WriteLine(degisken.Length);

            //toUpper , toLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(string.Concat(degisken,"Merhaba!"));

            //compare, compareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(string.Compare(degisken, degisken2, true));
            Console.WriteLine(string.Compare(degisken, degisken2, false));

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //indexOf
            Console.WriteLine(degisken.IndexOf("Cs"));
            Console.WriteLine(degisken.IndexOf("Nesli"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLeft , PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken + degisken2.PadRight(50));
            Console.WriteLine(degisken + degisken2.PadRight(50,'-'));

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}