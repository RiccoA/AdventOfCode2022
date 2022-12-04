namespace Day1AdventOfCode
{
    public class Elf
    {
        private FoodSupplies _foodSupplies = new FoodSupplies();

        public void AddFoodToSupply(Food food) => _foodSupplies.AddFood(food);

        public int GetTotalCalorieCount()
        {
            return _foodSupplies.TotalCalories();
        }
    }
}
