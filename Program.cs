using System;

int grade = 0;
int count = 0;
int sum = 0;
int highest = -1;
int lowest = 101;

Console.WriteLine("Enter grades (Enter -1 to finish):");

while (true)
{
    grade = int.Parse(Console.ReadLine());

    if (grade == -1)
    {
        break;
    }

    count++;
    sum += grade;

    if (grade > highest)
    {
        highest = grade;
    }

    if (grade < lowest)
    {
        lowest = grade;
    }
}

if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine("Count: " + count);
    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Highest grade: " + highest);
    Console.WriteLine("Lowest grade: " + lowest);
}
else
{
    Console.WriteLine("No grades were entered.");
}
