using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer.Tests.TestModels
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int[] Marks { get; set; }
        public Address Address { get; set; }
    }
}
