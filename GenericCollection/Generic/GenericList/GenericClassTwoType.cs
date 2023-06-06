using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericList
{
    public class GenericClassTwoType<T1, T2>
    {
        // two paramiter with Generic Class
        public  GenericClassTwoType(T1 Parameter1, T2 Parameter2)
        {
            Param1 = Parameter1;
            Param2 = Parameter2;
        }
        public T1 Param1 { get; }
        public T2 Param2 { get; }
    }
}
