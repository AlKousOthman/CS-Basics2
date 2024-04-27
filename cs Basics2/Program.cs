// See https://aka.ms/new-console-template for more information
//cs basics 2 challenge 1 part 1   

int currentHour = DateTime.Now.Hour;

if (currentHour >= 11 && currentHour < 15)
{
    Console.WriteLine("Time for lunch!");
}
else 
{
    Console.WriteLine("It isn't lunch time");
}
// Challenge 1 part 2

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


//bounus 1
int count = 5;

while (count >= 1)
{
    Console.WriteLine(count);
    count--; 
}






//CS basics 2 challenge 2 part 2

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

Console.WriteLine("Class schedule:");
foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}

// Challenge 2 part 2
int[] numbers = { 1, 2, 3, 4, 5 };

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i]; 
}

Console.WriteLine("The total sum of the array is: " + sum);


// Bonus 2
int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

Console.WriteLine("Matrix:");
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine(); 
}
