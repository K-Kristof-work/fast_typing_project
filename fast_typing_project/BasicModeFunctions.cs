using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace fast_typing_project
{
    class BasicModeFunctions
    {
        internal DateTime startTime;
        internal int time;

        internal List<string> Load(string path)
        {
            StreamReader getWordsFromFile = new StreamReader(path);
            List<string> FileData = new List<string>();
            int i = 0;
            while (!getWordsFromFile.EndOfStream)
            {
                FileData.Add(getWordsFromFile.ReadLine());
                i++;
            }
            getWordsFromFile.Close();
            return FileData;
        }

        
        internal void End()
        {
            Thread.Sleep(1500);
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    Environment.Exit(1);
            }
        }
    }
}
