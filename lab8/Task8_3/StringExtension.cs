namespace Anagrams
{
    public static class StringExtension
    {
        public static bool IsAnagramTo(this string word1, string word2)
        {
            bool result = true;
            char[] chars1 = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();
            AlphabetIndexComparer comparer = new();
            chars1.Sort(comparer);
            chars2.Sort(comparer);
            if (chars1.Length != chars2.Length)
                return false;
            else
            {
                for (int i = 0; i < chars1.Length; i++)
                {
                    if (chars1[i] != chars2[i])
                        result = false;
                }

            }

            return result;
        }

    }

}