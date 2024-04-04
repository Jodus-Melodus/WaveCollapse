class Program
{
    public static void Main(string[] args)
    {
        (int rows, int cols) = (int.Parse(args[0]), int.Parse(args[1]));
        WaveCollapse wave = new(rows, cols);
        char[,] map = wave.Generate();
        string res = "";

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                res += map[r, c];
            }

            res += '\n';
        }

        File.WriteAllLines("test.txt", res.Split('\n'));
    }
}