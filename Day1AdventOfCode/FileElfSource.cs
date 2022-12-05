namespace Day1AdventOfCode
{
    public class FileElfSource : IElfSource
    {
        private string _path { get; init; }

        public FileElfSource(string path)
        {
            _path = path;
        }

        public IEnumerable<Elf> GetElves()
        {
            var elves = new List<Elf>();
            Elf elf = new();

            foreach (string line in ReadLinesFrom(_path))
            {
                if (IsNewElfMarker(line))
                {
                    elves.Add(elf);
                    elf = new Elf();
                }

                if (IsValidCalorie(line, out int calorieCount))
                {
                    elf.AddFoodToSupply(new Food(calorieCount));
                }
            }

            return elves;
        }

        private IEnumerable<string> ReadLinesFrom(string path)
        {
            return File.ReadLines(path);
        }

        private bool IsValidCalorie(string line, out int result)
        {
            return int.TryParse(line, out result);
        }

        private bool IsNewElfMarker(string line)
        {
            return line.Equals(string.Empty);
        }
    }
}
