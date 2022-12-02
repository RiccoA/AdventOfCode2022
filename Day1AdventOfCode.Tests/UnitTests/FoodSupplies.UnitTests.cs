using FluentAssertions;

namespace Day1AdventOfCode.Tests.UnitTests
{
    public class FoodSuppliesUnitTests
    {
        [Fact]
        public void TotalCalories_ReturnsCorrectTotal_WithListOfFood()
        {

            var food1 = new Food(100);
            var food2 = new Food(100);
            var food3 = new Food(100);

            var foodSupplies = new FoodSupplies();
            foodSupplies.AddFood(food1);
            foodSupplies.AddFood(food2);
            foodSupplies.AddFood(food3);


            foodSupplies.TotalCalories().Should().Be(300);
        }
    }
}
