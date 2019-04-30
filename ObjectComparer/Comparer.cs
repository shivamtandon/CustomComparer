using System.Collections.Generic;

namespace ObjectComparer
{
    public static class Comparer
    {
        public static bool AreSimilar<T>(T first, T second)
        {

            BaseComparer baseComparer = ComparerFactory.ComparerFactory.GetBaseComparer();
            return baseComparer.Compare(first, second);
        }


    }
}
