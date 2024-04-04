class WaveCollapse(int Rows, int Columns)
{
    public readonly int Columns = Columns;
    public readonly int Rows = Rows;

    public char[,] Generate()
    {
        char[,] Map = new char[Rows, Columns];

        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                Map[row, col] = ' ';
            }
        }

        Random random = new();
        SingleTile single = new();
        DoubleTile @double = new();

        for (int row = 1; row < Rows - 1; row++)
        {
            for (int col = 1; col < Columns - 1; col++)
            {
                if (Map[row, col] == ' ')
                {
                    char[] above = single.PossibleAbove[Map[row - 1, col]];
                    char[] below = single.PossibleBelow[Map[row + 1, col]];
                    char[] left = single.PossibleLeft[Map[row, col - 1]];
                    char[] right = single.PossibleRight[Map[row, col + 1]];

                    char[] validCharacters = above.Intersect(below).Intersect(left).Intersect(right).ToArray();
                    int randomIndex = random.Next(0, validCharacters.Length);

                    Map[row, col] = validCharacters[randomIndex];
                }
            }
        }

        return Map;
    }
}