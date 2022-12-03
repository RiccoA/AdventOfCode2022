using FluentAssertions;

namespace Day1AdventOfCode.Tests.UnitTests
{
    public class CaloriesUnitTests
    {

        [Fact]
        public void Calories_AreEqual_WhenCalorieCountIsTheSame()
        {
            var calorie1 = new Calories(100);
            var calorie2 = new Calories(100);


            calorie1.Should().BeEquivalentTo(calorie2);
            (calorie1 == calorie2).Should().BeTrue();
        }


        [Fact]
        public void CaloriesSumOperator_IsSumOfCalorieCount_WhenTwoCaloriesAreAdded()
        {
            var calorie1 = new Calories(100);
            var calorie2 = new Calories(75);

            var sum = calorie1 + calorie2;

            sum.Should().BeEquivalentTo(175);
        }
    }
}
