using System;
using System.Collections.Generic;
using System.Threading;



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


            Console.WriteLine("for how long in seconds?");
            int duration = 0;
            try
            {
                duration = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("please enter a valid time");
                DispayOptions();
            }

            Console.Clear();
            CountdownFromThree();
            modes[choosenNumber - 1].Awake(duration);
            
        }

        private void CountdownFromThree()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Write("\r{0}", i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        }

    }
}
