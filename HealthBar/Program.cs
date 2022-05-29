class program
{
    static void Main(string[] args)
    {
        float percentHealthBar = 0f;
        float maxHealthBar = 30f;
        int barPositionX = 10;
        int barPositionY = 5;
        string exitCommand = "Exit";
        bool isExit = false;

        while (isExit == false)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Сколько процентов бара здоровья вы хотите закрасить?\n" +
                "Если хотите выйти, введите 'Exit' для выхода");

            string userInput = Console.ReadLine();

            if (userInput == exitCommand)
            {
                isExit = true;
            }
            else
            {
                percentHealthBar = Convert.ToSingle(userInput);
            }
            Console.Clear();

            DrawBar(percentHealthBar, maxHealthBar, ConsoleColor.Red, barPositionX, barPositionY);
        }
    }

    static void DrawBar(float percentageOfBar, float maxBar, ConsoleColor colorPercentBar, int positionX, int positionY)
    {
        int maxPercent = 100;
        float health = maxBar / maxPercent * percentageOfBar;
        ConsoleColor defaultColor = Console.BackgroundColor;
        string bar = "";

        for (int i = 0; i < health; i++)
        {
            bar += ' ';
        }
        Console.SetCursorPosition(positionX, positionY);
        Console.Write('[');
        Console.BackgroundColor = colorPercentBar;
        Console.Write(bar);
        Console.BackgroundColor = defaultColor;

        bar = "";

        for (var i = health; i < maxBar; i++)
        {
            bar += ' ';
        }
        Console.Write(bar + ']');
    }
}