using System;

namespace _29_09_2021 {
    class Program {
        static void Main(string[] args) {

            String a = "Matija";
            String b = "Trstenjak";

            var spojeniString = string.Join(" ", a,b);          //Spaja 2 stringa
            System.Console.WriteLine(spojeniString);

            char[] charArr = a.ToCharArray();
            for (int i = 0; i < a.Length; i++)              //string to charr
                System.Console.Write(charArr[i]);


            b = b.Remove(0,1);
            b = b.Remove(b.Length - 1,1);           //makne prvi i zadnji char iz stringa
            System.Console.WriteLine("\n" + b);

            String str1 = "Matko";
            String str2 = "Matko";
            bool jesu = string.Equals(str1, str2);          //provjerava jesu li 2 stringa ista
            System.Console.WriteLine(jesu);

            String c = "Danas je lijep dan";
            string[] words = c.Split(' ');
            string lastWord = words[words.Length - 1];      //zadnja rijec ispise
            System.Console.WriteLine(lastWord);


            String rijec = "Danas je petak";
            String rec = "je";
            int indeks = rijec.IndexOf(rec);
            System.Console.WriteLine(indeks);

            //VRATI LOKACIJU POOJAVLJIVANJA PRVOOG PODSTRINGA U 2. STRINGU
            //DANAS JE PETAK -> PETAK -> vrati lokaciju pojavljivanja
        }
    }
}
