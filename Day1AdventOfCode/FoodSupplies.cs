﻿namespace Day1AdventOfCode
{
    internal class FoodSupplies
    {
        private IList<Food> _foods = new List<Food>();

        public void AddFood(Food food)
        {
            _foods.Add(food);
        }
    }
}
