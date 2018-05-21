using PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLoadDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asmb =  Assembly.LoadFrom("Plugin1.dll");

            var begin = DateTime.Now;
            Console.WriteLine("Begin Time:" + begin);

            //靜態繫結
            var obj = (IPlugin)asmb.CreateInstance("Plugin1.Plugin1");
            //動態繫結
            //dynamic obj = asmb.CreateInstance("Plugin1.Plugin1");
            obj.Execute();

            var end = DateTime.Now;
            Console.WriteLine("End Time:" + end);
            Console.WriteLine("Total:" + (end - begin).ToString());
            Console.Read();
        }
    }
}
