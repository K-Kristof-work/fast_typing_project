using System;
using System.Collections.Generic;

namespace fast_typing_project
{
    class CalculateTheResult
    {
        private List<string> inputList = new List<string>();
        private List<string> outputList = new List<string>();
        private int time;

        public CalculateTheResult(string inputText, string outputText, int _time)
        {
            if(inputText != null && outputText != null)
            {
                string[] stringArray = inputText.Split(' ');
                for (int i = 0; i < stringArray.Length; i++)
                {
                    inputList.Add(stringArray[i]);
                }

                stringArray = outputText.Split(' ');
                for (int i = 0; i < stringArray.Length; i++)
                {
                    outputList.Add(stringArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Didn't write anything.");
            }
            

            time = _time;
        }

        public void  CalculateThenWriteTheResult()
        {
            int rightWord = 0;
            int wrongWord = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == outputList[i])
                    rightWord++;
                else
                    wrongWord++;
            }

            int wpn = rightWord * 60 / time;
            int rawWpn = (wrongWord + rightWord) * 60 / time;

            Console.WriteLine("\n\n WPN (word per minute): " + wpn);
            Console.WriteLine(" Raw WPN (word per minute): " + rawWpn);
            Console.WriteLine(" Time in seconds: " + time);
        }
    }
}
