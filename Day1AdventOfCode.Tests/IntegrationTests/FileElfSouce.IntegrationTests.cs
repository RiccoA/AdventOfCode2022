using FluentAssertions;

namespace Day1AdventOfCode.Tests.IntegrationTests
{
    public class FileElfSourceIntegrationTests
    {

        [Fact]
        public void FileElfSource_LoadsFile_WhenFileIsValid()
        {
            var path = "IntegrationTests/Resources/test_data.txt";

            var file = new FileElfSource(path);

            var elves = file.GetElves();

            elves.Should().NotBeEmpty();
        }

        [Fact]
        public void FileElfSource_HasCorrectTotal_WhenLoadingFile()
        {
            var path = "IntegrationTests/Resources/test_data.txt";

            var elfSource = new FileElfSource(path);

            var elfGroupFactory = new ElfGroupFactory(elfSource);
            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetHighestTotalOfCalories().Should().Be(24000);
        }

        [Fact]
        public void FileElfSource_HasCorrectTop3Total_WhenLoadingFile()
        {
            var path = "IntegrationTests/Resources/test_data.txt";

            var elfSource = new FileElfSource(path);

            var elfGroupFactory = new ElfGroupFactory(elfSource);
            var elfGroup = elfGroupFactory.CreateGroup();

            elfGroup.GetTop3HighesTotalOfCalories().Should().Be(45000);
        }

    }
}
