using Day1AdventOfCode;

Console.WriteLine("Hello, welcome to Elf Calorie Counter!");

var path = "data.txt";

var elfSource = new FileElfSource(path);

var elfGroupFactory = new ElfGroupFactory(elfSource);
var elfGroup = elfGroupFactory.CreateGroup();

var highestTotalCalories = elfGroup.GetHighestTotalOfCalories();
Console.WriteLine("The highest total of calories amoungst the grouop is {0}", highestTotalCalories);

Console.WriteLine("Pres any key to exit...");

