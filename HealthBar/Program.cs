class program
{
    static void Main(string[] args)
    {
        float percentHealth = 40f;
        float maxHealth = 10f;
        int barPositionX = 0;
        int barPositionY = 0;

        DrawBar(percentHealth, maxHealth, ConsoleColor.Red, barPositionX, barPositionY);
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