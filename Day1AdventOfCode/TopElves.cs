namespace Day1AdventOfCode
{
    internal class TopElves
    {
        public TopElves(int poolSize, IList<Elf> elves)
        {
            _poolSize = poolSize;
            _elves = elves.ToList();
            _topElfTotals = new int[3];
            FillTopElfTotals();
        }

        private int[] _topElfTotals;

        private IList<Elf> _elves { get; init; } = new List<Elf>();
        private int _poolSize { get; init; }

        public int GetTopTotalCalories()
        {
            return _topElfTotals.Sum();
        }

        private void FillTopElfTotals()
        {
            foreach (Elf elf in _elves)
            {
                int elfTotalCalorie = elf.GetTotalCalorieCount();
                if (elfTotalCalorie > _topElfTotals[0])
                {
                    int swapValue = _topElfTotals[0];
                    _topElfTotals[0] = elfTotalCalorie;
                    elfTotalCalorie = swapValue;
                }
                if (elfTotalCalorie > _topElfTotals[1])
                {
                    int swapValue = _topElfTotals[1];
                    _topElfTotals[1] = elfTotalCalorie;
                    elfTotalCalorie = swapValue;
                }
                if (elfTotalCalorie > _topElfTotals[2])
                {
                    int swapValue = _topElfTotals[2];
                    _topElfTotals[2] = elfTotalCalorie;
                    elfTotalCalorie = swapValue;
                }
            }
        }

    }
}
