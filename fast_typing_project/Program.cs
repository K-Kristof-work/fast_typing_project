using System.Threading;

namespace fast_typing_project
{

    class MainClass
    {
        static private readonly Information Info = new Information();

        public static void Main()
        {
            Info.Addmodes(new ClassicMode());
            Info.Addmodes(new ProgrammingMode());
            Info.Addmodes(new EasyMode());
            Info.Addmodes(new HardMode());
            Info.DispayOptions();
        }
    }
}
