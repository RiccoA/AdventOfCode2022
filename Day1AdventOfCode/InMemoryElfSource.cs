namespace Day1AdventOfCode
{
    internal class InMemoryElfSource : IElfSource
    {
        private IList<Elf> _elves = new List<Elf>();

        IEnumerable<Elf> IElfSource.GetElves()
        {
            return _elves.ToList();
        }

        public void AddElfWithCalories(int calorieCount)
        {
            var elf = new Elf();
            elf.AddFoodToSupply(new Food(calorieCount));
            _elves.Add(elf);
        }
        public void AddElfWithCalories(int[] calorieCounts)
        {
            var elf = new Elf();
            foreach (int calorieCount in calorieCounts)
            {
                elf.AddFoodToSupply(new Food(calorieCount));
            }
            _elves.Add(elf);
        }


    }
}
