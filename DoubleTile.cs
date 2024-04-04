class DoubleTile
{
    // ╣ ║ ╗ ╝ ╚ ╔ ╩ ╦ ╠ ═ ╬
    public Dictionary<char, char[]> PossibleAbove = new()
    {
        {'║', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╣', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╠', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╬', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╔', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╦', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╗', ['║', '╣', '╠', '╬', '╚', '╝', '╩']},
        {'╩', ['═', '╔', '╗', '╦', ' ']},
        {'╚', ['═', '╔', '╗', '╦', ' ']},
        {'═', ['═', '╔', '╗', '╦', ' ']},
        {'╝', ['═', '╔', '╗', '╦', ' ']},
        {' ', ['║', '╣', '╠', '╬', '╚', '╝', '╩', '═', '╔', '╗', '╦']},
    };
    public Dictionary<char, char[]> PossibleBelow = new()
    {
        {'║', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╣', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╠', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╬', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╩', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╚', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╝', ['║', '╣', '╠', '╬', '╔', '╗', '╦']},
        {'╔', ['╚', '╝', '╩', '═', ' ']},
        {'╦', ['╚', '╝', '╩', '═', ' ']},
        {'═', ['╚', '╝', '╩', '═', ' ']},
        {'╗', ['╚', '╝', '╩', '═', ' ']},
        {' ', ['║', '╣', '╠', '╬', '╚', '╝', '╩', '═', '╔', '╗', '╦']},
    };
    public Dictionary<char, char[]> PossibleLeft = new()
    {
        {'╦', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╬', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╩', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'═', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╔', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╚', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╠', ['╣', '╬', '╝', '╩', '═', '╗', '╦']},
        {'╣', ['║', '╠', '╚', '╔', ' ']},
        {'╗', ['║', '╠', '╚', '╔', ' ']},
        {'╝', ['║', '╠', '╚', '╔', ' ']},
        {'║', ['║', '╠', '╚', '╔', ' ']},
        {' ', ['║', '╣', '╠', '╬', '╚', '╝', '╩', '═', '╔', '╗', '╦']},
    };
    public Dictionary<char, char[]> PossibleRight = new()
    {
        {'═', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╦', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╬', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╣', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╗', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╝', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╩', ['╠', '╬', '╚', '╩', '═', '╔', '╦']},
        {'╔', ['║', '╣', '╝', '╗', ' ']},
        {'╚', ['║', '╣', '╝', '╗', ' ']},
        {'╠', ['║', '╣', '╝', '╗', ' ']},
        {'║', ['║', '╣', '╝', '╗', ' ']},
        {' ', ['║', '╣', '╠', '╬', '╚', '╝', '╩', '═', '╔', '╗', '╦']},
    };
}