using System;

namespace fast_typing_project
{
    class HardMode : BasicModeFunctions, IModes
    {
        public string Introduction { get; set; }

        public HardMode()
        {
            Introduction = "typing test with long and hard words";
        }

        public void Awake(int duration)
        {
            Console.WriteLine("Not Implemented yet.");
            End();
        }
    }
}
