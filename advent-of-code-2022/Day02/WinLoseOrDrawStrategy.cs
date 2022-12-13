namespace advent_of_code_2022.Day02
{
    internal class WinLoseOrDrawStrategy : ISecondColumnStrategy
    {
        private readonly IList<Tool> rockPaperScissors;
        private readonly IDictionary<char, Func<Tool, Tool>> letterToDecision =
            new Dictionary<char, Func<Tool, Tool>>();

        public WinLoseOrDrawStrategy(IList<Tool> rockPaperScissors)
        {
            this.rockPaperScissors = rockPaperScissors;

            letterToDecision.Add('X', lose);
            letterToDecision.Add('Y', draw);
            letterToDecision.Add('Z', win);
        }

        public Tool Parse(Tool opponent, char mine)
        {
            return letterToDecision[mine](opponent);
        }

        private Tool lose(Tool opponent) => backwards(opponent);

        private Tool win(Tool opponent) => forwards(opponent);

        private Tool draw(Tool opponent) => opponent;

        private Tool forwards(Tool tool) => navigate(tool, +1);

        private Tool backwards(Tool tool) => navigate(tool, -1);

        private Tool navigate(Tool tool, int direction) =>
            rockPaperScissors
            [
                (rockPaperScissors.IndexOf(tool) + direction + rockPaperScissors.Count)
                % rockPaperScissors.Count
            ];
    }
}
