namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Life { get; set; }


        public Settings()
        {
            GameOver = false;
            direction = Direction.Down;
            Speed = 10;
            Score = 0;
            Points = 100;
            Life = 3;

        }
    }

}
