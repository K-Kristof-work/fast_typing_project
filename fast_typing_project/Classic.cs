using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace fast_typing_project
{
    class Classic : IModes
    {
        public string Introduction { get; set; }
        private List<string> words = new List<string>();

        public Classic()
        {
            Introduction = "The classic 60 sec typing test.";
        }

        public void Start()
        {
            Console.Clear();
            Load();

            for (int i = 3; i < 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(500);
            }
            

        }

        private void Load()
        {
            StreamReader getWordsFromFile = new StreamReader("classic.txt");
            int i = 0;
            while (!getWordsFromFile.EndOfStream)
            {
                words.Add(getWordsFromFile.ReadLine());    
                i++;
            }
            getWordsFromFile.Close();
        }
    }
}
