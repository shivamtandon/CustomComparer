using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.CustomTypes
{
    public class StringTypes:AbstractComparer
    {
        public StringTypes(BaseComparer baseComparer) : base(baseComparer)
        {
        }

        public override bool AreSimilar<T>(T first, T second)
        {
            return first.Equals(second);
        }

        public override bool IsType(Type first, Type second)
        {
            return first == typeof(string) && second == typeof(string);
        }
    }
}
