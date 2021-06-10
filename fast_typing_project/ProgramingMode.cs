using System;

namespace fast_typing_project
{
    class ProgrammingMode : BasicModeFunctions, IModes
    {
        public string Introduction { get; set; }

        public ProgrammingMode()
        {
            Introduction = "programming style typing test";
        }

        public void Awake(int duration)
        {
            Console.WriteLine("Not Implemented yet.");
            End();
        }
    }
}
