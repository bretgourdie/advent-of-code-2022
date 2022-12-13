namespace advent_of_code_2022.Day01
{
    class Elf
    {
        IList<int> foods;
        public Elf()
        {
            foods = new List<int>();
        }

        public void Add(int item)
        {
            foods.Add(item);
        }

        public int Total() => foods.Sum();
    }
}
