using FluentAssertions;

namespace Day1AdventOfCode.Tests.IntegrationTests
{
    public class ElfGroupIntegrationTests
    {

        [Fact]
        public void TotalCalories_ReturnsHighestCalorieFood_WhenThereIsOneElf()
        {
            var elfSource = new InMemoryElfSource();
            elfSource.AddElfWithCalories(100);
            var elfGroupFactory = new ElfGroupFactory(elfSource);

            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetHighestTotalOfCalories().Should().Be(100);
        }


        [Fact]
        public void TotalCalories_ReturnsHighestCalorieFood_WhenThereAreTwoElves()
        {
            var elfSource = new InMemoryElfSource();
            elfSource.AddElfWithCalories(100);
            elfSource.AddElfWithCalories(230);
            var elfGroupFactory = new ElfGroupFactory(elfSource);

            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetHighestTotalOfCalories().Should().Be(230);
        }

        [Fact]
        public void TotalCalories_ReturnsHighestCalorieFood_WhenThereAreTwoElvesWithMultpleFood()
        {
            var elfSource = new InMemoryElfSource();
            elfSource.AddElfWithCalories(100);
            int[] calorieCounts = {130, 100};
            elfSource.AddElfWithCalories(calorieCounts);
            var elfGroupFactory = new ElfGroupFactory(elfSource);

            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetHighestTotalOfCalories().Should().Be(230);
        }

        [Fact]
        public void TotalCalories_ReturnsZero_WhenThereAreNoElves()
        {
            var elfSource = new InMemoryElfSource();
            var elfGroupFactory = new ElfGroupFactory(elfSource);

            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetHighestTotalOfCalories().Should().Be(0);
        }
    }
}
