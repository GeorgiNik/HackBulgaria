namespace Points
{
    using System;

    public static class ConsoleLogic
    {
        public static void Write(string toBeWritten)
        {
            Console.WriteLine(toBeWritten);
        }

        public static void WriteAnswer(int x, int y)
        {
            Console.WriteLine("({0}, {1})", x, y);
        }

        public static string ReadInput()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
