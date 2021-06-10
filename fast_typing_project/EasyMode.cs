using System;

namespace fast_typing_project
{
    class EasyMode : BasicModeFunctions, IModes
    {
        public string Introduction { get; set; }

        public EasyMode()
        {
            Introduction = "typing test with short and easy words";
        }

        public void Awake(int duration)
        {
            Console.WriteLine("Not Implemented yet.");
            End();
        }
    }
}
