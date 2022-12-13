﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code_2022.Day03
{
    internal class Day03 : AdventSolution
    {
        protected override long part1ExampleExpected => 157;

        protected override long part1InputExpected => 7980;

        protected override long part2ExampleExpected => throw new NotImplementedException();

        protected override long part2InputExpected => throw new NotImplementedException();

        protected override long part1Work(string[] input)
        {
            long prioritySum = 0;
            char[] letters = getLetters();

            foreach (var line in input)
            {
                var letter = new Rucksack(line).GetItem();
                prioritySum += getPriority(letter, letters);
            }

            return prioritySum;
        }

        private long getPriority(
            char letter,
            IList<char> letters)
        {
            return letters.IndexOf(letter) + 1;
        }

        private char[] getLetters()
        {
            return
                Enumerable.Range('a', 26).Union(Enumerable.Range('A', 26))
                .Select(x => (char)x)
                .ToArray();
        }

        protected override long part2Work(string[] input)
        {
            throw new NotImplementedException();
        }
    }
}
