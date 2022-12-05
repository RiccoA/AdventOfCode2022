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

        public int GetTop3HighesTotalOfCalories()
        {

            IList<Elf> top3Elves  = new List<Elf>();

            foreach(var elf in _elves)
            {
                if (top3Elves.Count < 3)
                {
                    top3Elves.Add(elf);
                    top3Elves.OrderBy(elf => elf.GetTotalCalorieCount());
                    continue;
                }


                bool elfAdded = false;
                for (int topElfIndex = 0; topElfIndex < 3; topElfIndex++)
                {
                    var topElf = top3Elves.ElementAt(topElfIndex);
                    if (!elfAdded && elf.GetTotalCalorieCount() > topElf.GetTotalCalorieCount())
                    {
                        top3Elves.RemoveAt(topElfIndex);
                        top3Elves.Insert(topElfIndex, elf);
                        elfAdded = true;
                    }

                }
            }

            return top3Elves.Sum(elf => elf.GetTotalCalorieCount());
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
