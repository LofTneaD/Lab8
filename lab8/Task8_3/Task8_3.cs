using System;

namespace Anagrams
{
    class Task8_3
    {
        public static void Run()
        {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
            string[] changedArray = DeleteAnagramsFromArray(array);
            foreach (string s in changedArray)
                Console.WriteLine(s);

        }

        private static string[] DeleteAnagramsFromArray(string[] array)
        {
            List<string> list = new()
            {
                array[0]
            };

            for (int i = 1; i < array.Length; i++)
            {
                if (!array[i].IsAnagramTo(array[i - 1])) list.Add(array[i]);
            }

            list.Sort();
            return list.ToArray();
        }

    }

}