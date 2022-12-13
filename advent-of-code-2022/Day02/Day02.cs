namespace advent_of_code_2022.Day02
{
    internal class Day02 : AdventSolution
    {
        private IDictionary<char, Tool> opponentTool = new Dictionary<char, Tool>();
        private IList<Tool> rockPaperScissors = new List<Tool> { Tool.Rock, Tool.Paper, Tool.Scissors };

        public Day02()
        {
            for (int ii = 0; ii < rockPaperScissors.Count; ii++)
            {
                opponentTool[(char)('A' + ii)] = rockPaperScissors[ii];
            }
        }

        protected override long part1ExampleExpected => 15;

        protected override long part1InputExpected => 14531;

        protected override long part2ExampleExpected => 12;

        protected override long part2InputExpected => 11258;

        protected override long part1Work(string[] input) =>
            playGame(input, new RespondingToolStrategy());

        protected override long part2Work(string[] input) =>
            playGame(input, new WinLoseOrDrawStrategy(rockPaperScissors));

        protected long playGame(string[] input, ISecondColumnStrategy secondColumnStrategy)
        {
            long score = 0;

            foreach (var line in input)
            {
                var splitLine = line.Split(' ');

                var opponentLetter = splitLine[0].First();
                var myLetter = splitLine[1].First();

                var opponentDecision = opponentTool[opponentLetter];

                var myDecision = secondColumnStrategy.Parse(opponentDecision, myLetter);

                score += getScore(myDecision, opponentDecision);
            }

            return score;
        }

        private long getScore(Tool mine, Tool opponent) =>
            rockPaperScissors.IndexOf(mine) + 1
            + (iWin(mine, opponent) ? 6 : 0)
            + (wasDraw(mine, opponent) ? 3 : 0);

        private bool wasDraw(Tool mine, Tool opponent) => mine == opponent;

        private bool iWin(Tool mine, Tool opponent) =>
            (rockPaperScissors.IndexOf(opponent) + 1) % rockPaperScissors.Count ==
            rockPaperScissors.IndexOf(mine);
    }
}
