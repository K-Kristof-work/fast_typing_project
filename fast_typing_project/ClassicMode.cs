using System.Collections.Generic;
using System;
using System.Threading;

namespace fast_typing_project
{

    class ClassicMode : BasicModeFunctions, IModes
    {
        public string Introduction { get; set; }
        public float DurationInSeconds { get; set; }
        private List<string> words = new List<string>();


        public ClassicMode()
        {
            Introduction = "The classic typing test.";
        }

        public void Awake(int duration)
        {
            words = Load("Classic.txt");
            time = duration;
            startTime = DateTime.UtcNow;
            Start();
        }

        private void Start()
        {
            string inputText = null;
            string outputText = null;
            string currentText = null;

            currentText = MakeLineOfWords();
            outputText += currentText;
            Console.WriteLine(currentText);

            while (DateTime.UtcNow - startTime < TimeSpan.FromSeconds(time))
            {
                ConsoleKeyInfo inputChar = Console.ReadKey();

                if(inputChar.Key == ConsoleKey.Enter)
                {
                    currentText = MakeLineOfWords();
                    outputText += currentText;
                    Console.WriteLine("\n" + currentText);
                }
                else if(inputChar.Key == ConsoleKey.Backspace)
                {
                    if (inputText != null)
                        inputText = inputText.Remove(inputText.Length - 1);
                }
                else
                {
                    inputText += inputChar.KeyChar;
                }
            }

            CalculateTheResult calculate = new CalculateTheResult(inputText, outputText, time);
            calculate.CalculateThenWriteTheResult();

            End();
        }
       
        private string MakeLineOfWords()
        {
            string text = null;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                text += (words[rand.Next(0, words.Count)] + " ");
            }
            return text;
        }
    }
}
