using System.Threading;

namespace fast_typing_project
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Information Info = new Information();
            Info.Addmodes(new Classic());
            Info.DispayOptions();

        }
    }
}
