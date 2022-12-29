using System.Collections;

namespace Anagrams
{
    public static class ArrayExtensions
    {
        public static void Sort(this Array array, IComparer comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1)!;
                    object element2 = array.GetValue(j)!;
                    if (comparer.Compare(element1, element2) > 0)
                    {
                        object temporary = array.GetValue(j)!;
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }

                }

            }

        }

    }

}