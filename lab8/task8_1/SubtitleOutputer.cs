namespace LabWork8
{
    public class SubtitleOutputer
    {
        private static int currentTime;
        private Subtitle[] subtitles;
        public SubtitleOutputer(Subtitle[] subtitles)
        {
            this.subtitles = subtitles;
        }

        public void BeignWork()
        {
            TimerCallback timerCallback = new TimerCallback(Check);
            Timer timer = new Timer(timerCallback, subtitles, 0, 1000);
        }

        private static void Check(object obj)
        {
            Subtitle[] input = (Subtitle[])obj;
            foreach (Subtitle sub in input)
            {
                if (sub.StartTime == currentTime) ShowSubtitleOnConsole(sub);
                else if (sub.EndTime == currentTime) DeleteSubtitleFromConsole(sub);
            }

            currentTime++;
        }

        private static void ShowSubtitleOnConsole(Subtitle sub)
        {
            SetPosition(sub);
            Console.ForegroundColor = sub.Color;
            Console.Write(sub.Text);
        }

        private static void DeleteSubtitleFromConsole(Subtitle sub)
        {
            SetPosition(sub);
            for (int i = 0; i < sub.Text.Length; i++)
                Console.Write(" ");
        }

        private static void SetPosition(Subtitle sub)
        {
            switch (sub.Position)
            {
                case "Top":
                    Console.SetCursorPosition((Console.WindowWidth - sub.Text.Length) / 2, 1);
                    break;
                case "Right":
                    Console.SetCursorPosition(Console.WindowWidth - sub.Text.Length, (Console.WindowHeight - 1) / 2);
                    break;
                case "Bottom":
                    Console.SetCursorPosition((Console.WindowWidth - sub.Text.Length) / 2, Console.WindowHeight);
                    break;
                case "Left":
                    Console.SetCursorPosition(0, (Console.WindowHeight - 1) / 2);
                    break;
                default:
                    break;
            }

        }

    }

}