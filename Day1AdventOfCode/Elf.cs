namespace Day1AdventOfCode
{
    internal class Elf
    {
        private FoodSupplies _foodSupplies = new FoodSupplies();

        public void AddToFoodSupply(Food food) => _foodSupplies.AddFood(food);
    }
}
