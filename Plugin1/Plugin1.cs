using System;
using PluginInterface;

namespace Plugin1
{
    public class Plugin1 : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Plugin1");
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
