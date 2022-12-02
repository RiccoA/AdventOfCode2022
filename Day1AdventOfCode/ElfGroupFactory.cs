namespace Day1AdventOfCode
{
    public class ElfGroupFactory
    {
        private IElfSource _elfSource;

        public ElfGroupFactory(IElfSource elfSource)
        {
            _elfSource = elfSource;
        }

        public ElfGroup CreateGroup()
        {
            throw new NotImplementedException();
        }

    }
}
