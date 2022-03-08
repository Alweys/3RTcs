using System;

namespace _13_10_2021 {
    class Program {
        static void Main(string[] args) {

            char[,] Polje = new char[50,50];
            int a;

            Random rand = new Random();
            for(int i = 0; i < 50; i++) 
            {
                for (int j = 0; j < 50; j++) {
                    a = rand.Next(2);

                    if (a == 0) {
                        Polje[i, j] = (char)rand.Next('a', 'z');
                    } else
                        Polje[i, j] = (char)rand.Next('A', 'Z');
                    Console.Write(Polje[i, j] + " ");
                }
                Console.WriteLine();
            }

            string rijec;
            char[] rijecArr = new char[5];
            int duzinaRijeci;
            bool nalazi = false;
            int brojac = 0;

            Console.WriteLine("Unesi neku rijec: ");
            rijec = Console.ReadLine();
            rijecArr = rijec.ToCharArray();
            duzinaRijeci = rijec.Length;
            int brojacLijevo = duzinaRijeci - 1;

            for (int i = 0; i < 50; i++) 
            {
                for(int j = 0; j < 50; j++) 
                {
                    if(rijecArr[0] == Polje[i,j]) 
                    {
                        if (j < 50 - duzinaRijeci) {
                            for (int z = 0; z < duzinaRijeci; z++) {
                                if (Polje[i, (j + z)] == rijecArr[z]) {     //PREMA DESNO
                                    Console.WriteLine("Nalazi se!");
                                    return;
                                }
                            }
                        }
                        if(j > duzinaRijeci) {
                            if (j < 50 - duzinaRijeci) {
                                for (int z = duzinaRijeci - 1; z <= 0; z--) {
                                    if (Polje[i, (j + z)] == rijecArr[brojacLijevo]) {     //PREMA LIJEVO
                                        Console.WriteLine("Nalazi se!");
                                        return;
                                    }
                                    brojacLijevo--;
                                }
                            }
                        }
                        if (i > duzinaRijeci) {                                         //GORE
                            for (int z = 0; z <= duzinaRijeci; z++) {
                                if (Polje[(i - z), j] == rijecArr[z]) {
                                    Console.WriteLine("Nalazi se!");
                                    return;
                                }
                            }
                        }

                        if (i < 50 - duzinaRijeci) {                             //DOLJE
                            for (int z = 0; z <= duzinaRijeci; z++) {
                                if (Polje[(i + z), j] == rijecArr[z]) {
                                    Console.WriteLine("Nalazi se!");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
