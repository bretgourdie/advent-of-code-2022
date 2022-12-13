namespace advent_of_code_2022.Day02
{
    internal class RespondingToolStrategy : ISecondColumnStrategy
    {
        IDictionary<char, Tool> responseLookup;

        public RespondingToolStrategy()
        {
            responseLookup = new Dictionary<char, Tool>()
            {
                { 'X', Tool.Rock },
                { 'Y', Tool.Paper },
                { 'Z', Tool.Scissors }
            };
        }

        public Tool Parse(Tool opponent, char mine) => responseLookup[mine];
    }
}
