using System;
using System.Collections.Generic;
using System.Linq;

namespace _13102021 {
    class Program {

        static void Main(string[] args) {
            String test = "cba";
            char[,] cArr = new char[50, 50];
            Random random = new Random();

            for(int i = 0; i < 50; i++) {
                for(int j = 0; j < 50; j++) {
                    cArr[i, j] = '*';//(char)('a' + random.Next(0, 26));

                    
                }
            }
            for(int i = 0;i<5;i++) {
                cArr[25+i, 25] = (char)('a' + i);
            }

            Cetv.PrintArr(cArr);

            Console.WriteLine(Cetv.ContainsWord(cArr,test));
        }
    }
}
