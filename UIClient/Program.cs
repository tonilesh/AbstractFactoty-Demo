using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Core;


namespace UIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientUIBuilder builder = new ClientUIBuilder();
            UIFactory factory = UIFactories.CreateFactory();
            UIComponent root = builder.BuildUI(factory);

            root.Show();

            Console.WriteLine("Hit Enter to Exit");
            Console.ReadLine();


        }
    }
}
