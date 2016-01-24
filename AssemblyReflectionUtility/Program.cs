using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyReflectionUtility;

namespace AssemblyReflectionUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQReflection linqReflection = new LINQReflection();
            linqReflection.GetAssembliesByReflection();
        }

    }
}
