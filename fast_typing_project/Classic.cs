using System.Collections.Generic;
using System;
using System.Threading;

namespace fast_typing_project
{

    class Classic : BasicModeFunctions, IModes
    {
        public string Introduction { get; set; }
        public float DurationInSeconds { get; set; }
        private List<string> words = new List<string>();

        public Classic()
        {
            Introduction = "The classic typing test.";
        }

        public void Awake(float duration)
        {
            Console.Clear();
            words = Load("Classic.txt");
            CountdownFromThree();
            breakDuration = TimeSpan.FromSeconds(duration);
            startTime = DateTime.UtcNow;
            Start();
        }

        private void Start()
        {
            string inputText = null;
            string fullText = null;
            string currentText = null;

            currentText = MakeLineOfWords();
            fullText += currentText;
            Console.WriteLine(currentText);

            while (DateTime.UtcNow - startTime < breakDuration)
            {
                ConsoleKeyInfo inputChar = Console.ReadKey();

                if(inputChar.Key == ConsoleKey.Enter)
                {
                    currentText = MakeLineOfWords();
                    fullText += currentText;
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

            Console.WriteLine("\n\n" + fullText + "\n\n" + inputText);

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
