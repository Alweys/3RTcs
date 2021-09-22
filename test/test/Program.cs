using System;

namespace test
{

    class Program

    {
        public static String zamjena(String s)
        {
            Console.WriteLine(s.Length);
            char [] brojevi = s.ToCharArray();
            for(int i = 0;i<s.Length;i++)
            {
                if (brojevi[i] == '0')
                    brojevi[i] = '1';
                else if (brojevi[i] == '1')
                    brojevi[i] = '0';
            }

            String ss = string.Join("", brojevi);

            return ss;

        }

        public static String drugik(String s)
        {
            int a = Convert.ToInt32(s, 2);

            int b = 1;

            int c = a + b;
            String xd = Convert.ToString(c, 2);
            return xd;

        }
       
        static void Main(string[] args)
        {
            String broj = Console.ReadLine();

            int b = Convert.ToInt32(broj, 2);

            Console.WriteLine(b);

            String[] broj2 = broj.Split("");
            int[] brojevi = Array.ConvertAll(broj2, int.Parse);
           Console.WriteLine(zamjena(broj));
           Console.WriteLine(drugik(zamjena(broj)));





        }

    }
}
