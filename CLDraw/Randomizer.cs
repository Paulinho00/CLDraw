using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDraw
{
    /// <summary>
    /// Contain method to shuffle list
    /// </summary>
    public static class Randomizer
    {
        private static Random rng = new Random();

        /// <summary>
        /// Shuffles list using  Fisher-Yates shuffle
        /// </summary>
        /// <typeparam name="T">List elements type</typeparam>
        /// <param name="list">List to be shuffled</param>
        public static void Shuffle<T>(this IList<T> list)
        {

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n+1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        /// <summary>
        /// Generates list containing randomly ordered ints from 0 to 7
        /// </summary>
        /// <returns></returns>
        public static List<int> GenerateDrawPool()
        {
            //Generate list with ints from 0 to 7
            List<int> drawPool = new List<int>();
            drawPool = Enumerable.Range(0, 8).ToList();

            //Shuffles list
            Shuffle(drawPool);

            return drawPool;
        }
    }
}
