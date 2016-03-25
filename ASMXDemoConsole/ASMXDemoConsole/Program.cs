using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMXDemoConsole.ASMXDemoWebServiceReference;

namespace ASMXDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ASMXDemoWebService asmxDemoService = new ASMXDemoWebService();
            Console.WriteLine(asmxDemoService.HelloWorld()); 
        }
    }
}
