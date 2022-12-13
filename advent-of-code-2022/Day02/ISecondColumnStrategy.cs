namespace advent_of_code_2022.Day02
{
    internal interface ISecondColumnStrategy
    {
        Tool Parse(Tool opponent, char mine);
    }
}
