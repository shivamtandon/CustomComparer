using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.CustomTypes
{
    public class ComplexTypes:AbstractComparer
    {
        private BaseComparer bc;
        public ComplexTypes(BaseComparer baseComparer) : base(baseComparer)
        {
            bc = baseComparer;
        }

        public override bool AreSimilar<T>(T first, T second)
        {
            var propertyMetadatas = first.GetType().GetProperties();
            foreach (var propertymeta in propertyMetadatas)
            {
                var firstValue = propertymeta.GetValue(first);
                var secondValue = propertymeta.GetValue(second);
                var IsEqual = bc.Compare(firstValue, secondValue);
                if (IsEqual == false)
                    return false;
            }
            return true;
        }

        public override bool IsType(Type first, Type second)
        {
            return first.IsClass;
        }
    }
}
