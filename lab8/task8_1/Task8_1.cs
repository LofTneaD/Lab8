using System;
using System.Threading;

namespace LabWork8
{
    class Task8_1
    {
        public static void Run()
        {
            string[] userInput = File.ReadAllLines("input.txt");
            Subtitle[] subtitles = new Subtitle[userInput.Length];
            for (int i = 0; i < userInput.Length; i++)
            {
                subtitles[i] = SubtitleCreator.CreateSubtitle(userInput[i]);
            }

            SubtitleOutputer display = new SubtitleOutputer(subtitles);
            display.BeignWork();

            Console.ReadLine();
        }

    }

}