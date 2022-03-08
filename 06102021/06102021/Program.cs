using System;

namespace _06102021 {
    class Program {
        static void Main(string[] args) {
            int n = 0;
            int m = 0;
            int xd2 = 0;
            Random rnd = new Random();
            char[,] cArr = new char[20, 20];

            String s1 = "toni";

            String s2 = "omgg";
            for(int i = 0; i < 20; i++) {
                for(int j = 0; j < 20; j++) {
                    cArr[i, j] = '*';
                }
            }

            for(int i = 0;i<s1.Length;i++) {
                if (i == 0) {
                    n = rnd.Next(5,10);
                    m = rnd.Next(5,10);
                }
                char[] cAr = s1.ToCharArray();
                char[] cAr2 = s2.ToCharArray();
                cArr[n, m+i] = cAr[i];
                if (cArr[n, m + i] == cAr2[0]) {
                    xd2 = m + i+1;
                }
            }
            for (int i = 0; i < s1.Length; i++) {
                int brojac = 0;
                char[] cAr = s2.ToCharArray();
                for(int j = 0; j < s1.Length;j++) {
                    for(int k = 0; k < s2.Length; k++) {
                        if(cArr[n,m+j] == cAr[k]) {
                            for (int y = 0; y < s2.Length; y++) {
                                cArr[n  + y, xd2-1+y] = cAr[y];

                            }
                        }
                    }
                }
            }


            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 20; j++) {
                    if(cArr[i,j] != '*') {

                    }
                }
            }

            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 20; j++) {
                    Console.Write(cArr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
