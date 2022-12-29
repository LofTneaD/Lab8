using System.Collections;

namespace Anagrams
{
    class AlphabetIndexComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            char c1 = (char)x;
            char c2 = (char)y;
            return c1.CompareTo(c2);
        }

    }

}