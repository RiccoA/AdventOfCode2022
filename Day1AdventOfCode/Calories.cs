namespace Day1AdventOfCode
{
    public class Calories : ValueObject
    {
        public int CalorieCount { get; init; }

        public Calories(int calorieCount)
        {
            CalorieCount = calorieCount;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) || EqualsCalorieCount(obj);
        }

        private bool EqualsCalorieCount(object obj)
        {
            Type objType = obj.GetType();
            if (!objType.Equals(typeof(int)))
                return false;

            return (int)obj == CalorieCount;
        }

        public static Calories operator +(Calories a) => a;

        public static Calories operator +(Calories a, Calories b)
        {
            return new Calories(a.CalorieCount + b.CalorieCount);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CalorieCount;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int toInt()
        {
            return CalorieCount;
        }
    }
}
