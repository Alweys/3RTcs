using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13102021 {
    public class Cetv {

        public static string Reverse(string text) {
            if (text == null) return null;

            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        public static IEnumerable<T> GetRow<T>(T[,] array, int index) {
            for (int i = 0; i < array.GetLength(1); i++) {
                yield return array[index, i];
            }
        }
        public static IEnumerable<T> GetColumn<T>(T[,] array, int index) {
            for (int i = 0; i < array.GetLength(1); i++) {
                yield return array[i, index];
            }
        }

        public static bool ContainsWord(char[,] arr, string test)
            {

                for (int i = 0; i < arr.GetLength(0); i++) {
                    string column = new string(Cetv.GetColumn(arr, i).ToArray());
                    string row = new string(Cetv.GetRow(arr, i).ToArray());

                    if(row.Contains(test) || column.Contains(test) || row.Contains(Reverse(test)) || column.Contains(Reverse(test))) {
                    return true;
                }
                }

                
                return false;
            }
        public static void PrintArr(char[,] arr) {
            for (int i = 0; i < 50; i++) {
                for (int j = 0; j < 50; j++) {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine(i);
            }
        }


    }
}
