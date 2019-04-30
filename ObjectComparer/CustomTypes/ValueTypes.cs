using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.CustomTypes
{
    public class ValueTypes:AbstractComparer
    {
        public ValueTypes(BaseComparer baseComparer) : base(baseComparer)
        {
        }

        public override bool AreSimilar<T>(T first, T second)
        {
            return first.Equals(second);
        }


        public override bool IsType(Type first, Type second)
        {
            return (first.GetTypeInfo().IsValueType && second.GetTypeInfo().IsValueType);

        }
    }
}
