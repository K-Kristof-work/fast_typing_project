using System;
using System.Collections.Generic;

namespace fast_typing_project
{
    class Information
    {
        private readonly List<IModes> modes = new List<IModes>();

        public void Addmodes(IModes _modes)
        {
            modes.Add(_modes);
        }

        public void DispayOptions()
        {
            Console.WriteLine( "choose what mode you want to: \n\n" );
            int i = 1;
            foreach (var _item in modes)
            {
                Console.WriteLine("{0}. {1}\n", i, _item.Introduction);
                i++;
            }

            int choosenNumber = 1;
            try
            {
                choosenNumber = Convert.ToInt32(Console.ReadLine());
                if (modes[choosenNumber - 1] != null) { }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    Console.WriteLine("please enter a valid option");
                    DispayOptions();
                }

            }
            modes[choosenNumber - 1].Start();
            
        }
    }
}
