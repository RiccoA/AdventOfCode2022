namespace Day1AdventOfCode
{
    public class Food
    {
        public Food(int calories)
        {
            Calories = new Calories(calories);
        }

        public Calories Calories { get; private init; }
    }
}
