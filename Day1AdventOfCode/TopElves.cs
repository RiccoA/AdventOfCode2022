namespace Day1AdventOfCode
{
    internal class TopElves
    {
        public TopElves(int poolSize, IList<Elf> elves)
        {
            _topElfTotals = new int[poolSize];
            FillTopElfTotals(elves.ToList());
        }

        private int[] _topElfTotals;


        public int GetTopTotalCalories()
        {
            return _topElfTotals.Sum();
        }

        private void FillTopElfTotals(IEnumerable<Elf> elves)
        {
            foreach (Elf elf in elves)
            {
                UpdateTopElfTotalsWithNewElf(elf);
            }
        }

        private void UpdateTopElfTotalsWithNewElf(Elf elf)
        {
            int newValueToCheck = elf.GetTotalCalorieCount();
            for (int topElfIndex = 0; topElfIndex < _topElfTotals.Length; topElfIndex++)
            {
                if (newValueToCheck > _topElfTotals[topElfIndex])
                {
                    int swapValue = _topElfTotals[topElfIndex];
                    _topElfTotals[topElfIndex] = newValueToCheck;
                    newValueToCheck = swapValue;
                }
            }
        }
    }
}
