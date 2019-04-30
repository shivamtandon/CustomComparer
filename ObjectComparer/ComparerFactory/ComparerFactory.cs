using ObjectComparer.CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.ComparerFactory
{
    public class ComparerFactory
    {
        private static BaseComparer _baseComp;
        public static BaseComparer GetBaseComparer()
        {
            if (_baseComp == null)
                _baseComp = BuildRootComparer();

            return _baseComp;
        }

        private static BaseComparer BuildRootComparer()
        {
            _baseComp = new BaseComparer();
            _baseComp.TypeComparers = new List<AbstractComparer>();
            _baseComp.TypeComparers.Add(new ValueTypes(_baseComp));
            _baseComp.TypeComparers.Add(new StringTypes(_baseComp));
            _baseComp.TypeComparers.Add(new ArrayTypes(_baseComp));
            _baseComp.TypeComparers.Add(new ComplexTypes(_baseComp));
            return _baseComp;

        }
    }
}
