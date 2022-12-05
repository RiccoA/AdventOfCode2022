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
            var topElves = new TopElves(1, _elves);

            return topElves.GetTopTotalCalories();
        }

        public int GetTop3HighesTotalOfCalories()
        {
            var topElves = new TopElves(3, _elves);

            return topElves.GetTopTotalCalories();

        }
    }
}
