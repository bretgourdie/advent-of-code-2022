using System.Linq;

namespace advent_of_code_2022.Day03
{
    internal class Group
    {
        public readonly char Badge;

        public Group(
            string one,
            string two, 
            string three)
        {
            var joined = one
                .Join(
                    two,
                    x => x,
                    y => y,
                    (x, y) => x)
                .Join(
                    three,
                    x => x,
                    y => y,
                    (x, y) => x);

            var distinct = joined.Distinct();

            var single = distinct.Single();

            Badge = single;
        }
    }
}
