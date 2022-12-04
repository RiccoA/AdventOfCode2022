namespace Day1AdventOfCode
{
    public class ElfGroup
    {
        private IList<Elf> _elves { get; set; } = new List<Elf>();

        public void AddElves(IEnumerable<Elf> elves)
        {
            _elves = elves.ToList();
        }

        public int GetHighestTotalOfCalories()
        {
            var highestTotal = 0;

            foreach(var elf in _elves)
            {
                highestTotal = returnHighestValue(highestTotal, elf.GetTotalCalorieCount());
            }

            return highestTotal;
        }

        private int returnHighestValue(int value1, int value2)
        {
            if (value2 > value1)
            {
                return value2;
            }

            return value1;
        }
    }
}
