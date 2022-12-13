namespace advent_of_code_2022.Day03
{
    internal class Rucksack
    {
        private readonly string raw;

        public Rucksack(string contents)
        {
            this.raw = contents;
        }

        public char GetItem()
        {
            var firstHalf = raw.Substring(0, raw.Length / 2);

            var secondHalf = raw.Substring(raw.Length / 2);

            var difference = firstHalf.Join(
                secondHalf,
                x => x,
                y => y,
                (x, y) => x);

            return difference.Distinct().Single();
        }
    }
}
