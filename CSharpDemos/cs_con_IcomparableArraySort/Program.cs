using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IcomparableArraySort
{
    internal class Employees : System.IComparable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public int CompareTo(object obj)
        {
            Employees other = obj as Employees;
            return this.EmpId.CompareTo(other.EmpId);
        }
    }
}
