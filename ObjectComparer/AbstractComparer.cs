using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public abstract class AbstractComparer
    {
        public BaseComparer BaseComparer { get; set; }

    protected AbstractComparer(BaseComparer baseComparer)
    {
        BaseComparer = baseComparer;
    }
    abstract public bool IsType(Type first, Type second);
    public abstract bool AreSimilar<T>(T first, T second);
}
}
