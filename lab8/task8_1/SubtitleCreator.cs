namespace LabWork8
{
    public static class SubtitleCreator
    {
        public static Subtitle CreateSubtitle(string input)
        {
            int st = GetStartTime(input);
            int et = GetEndTime(input);
            string position = GetPosition(input);
            ConsoleColor color = GetColor(input);
            string text = GetText(input);
            return new Subtitle(st, et, position, color, text);
        }

        private static int GetStartTime(string input)
        {
            int startTime = int.Parse(input.Split(" - ")[0].Split(':')[1]);
            return startTime;
        }

        private static int GetEndTime(string input)
        {
            int endTime = int.Parse(input.Split(" - ")[1].Split(' ')[0].Split(':')[1]);
            return endTime;
        }

        private static string GetPosition(string input)
        {
            string position = "";
            if (input.Contains('['))
                position = input.Split('[')[1].Split(',')[0];
            else
                position = "Bottom";
            return position;
        }

        private static ConsoleColor GetColor(string input)
        {
            ConsoleColor color;
            string subColor = "";
            if (input.Contains(']'))
                subColor = input.Split(']')[0].Split(", ")[1];
            switch (subColor)
            {
                case "Red":
                    color = ConsoleColor.Red;
                    break;
                case "Blue":
                    color = ConsoleColor.Blue;
                    break;
                case "Green":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            return color;
        }

        private static string GetText(string input)
        {
            string text;
            if (input.Contains('['))
                text = input.Split("] ")[1];
            else
                text = input.Substring(14);
            return text;
        }

    }

}