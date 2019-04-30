using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.CustomTypes
{
    public class ArrayTypes:AbstractComparer
    {
        public ArrayTypes(BaseComparer baseComparer) : base(baseComparer)
        {
        }

        public override bool AreSimilar<T>(T first, T second)
        {
            dynamic firstArray = first;
            dynamic secondArray = second;

            if (firstArray.Length != secondArray.Length)
                return false;

            Array.Sort(firstArray);
            Array.Sort(secondArray);
            for (int i = 0; i < firstArray.Length; i++)
                if (firstArray[i] != secondArray[i])
                    return false;

            return true;
        }

        public override bool IsType(Type first, Type second)
        {
            return first.IsArray && second.IsArray;
        }
    }
}
