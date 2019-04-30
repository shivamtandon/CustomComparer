using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class BaseComparer
    {
        internal List<AbstractComparer> TypeComparers { get; set; }

        public bool Compare<T>(T first, T second)
        {
            if (first == null && second == null)
                return true;

            Type firstType = first.GetType();
            Type secondType = second.GetType();
            AbstractComparer abstractComparer = TypeComparers.
                Where(x => x.IsType(firstType, secondType)).FirstOrDefault();
            return abstractComparer.AreSimilar(first, second);
        }
    }
}
