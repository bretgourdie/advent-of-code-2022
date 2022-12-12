namespace AdventOfCode2022.Day01
{
    internal class Day01 : AdventSolution
    {
        protected override long part1Work(string[] input)
        {
            return
                getElves(input)
                .Max(elf => elf.Total());
        }

        protected override long part2Work(string[] input)
        {
            return getElves(input)
                .OrderByDescending(elf => elf.Total())
                .Take(3)
                .Sum(elf => elf.Total());
        }

        private IList<Elf> getElves(string[] input)
        {
            var elves = new List<Elf>();
            var elf = new Elf();
            foreach (var line in input)
            {
                if (line == string.Empty)
                {
                    elves.Add(elf);

                    elf = new Elf();
                }

                else
                {
                    elf.Add(int.Parse(line));
                }
            }

            elves.Add(elf);

            return elves;
        }

        protected override long part1ExampleExpected => 24000;
        protected override long part1InputExpected => 74394;

        protected override long part2ExampleExpected => 45000;
        protected override long part2InputExpected => 212836;
    }
}
