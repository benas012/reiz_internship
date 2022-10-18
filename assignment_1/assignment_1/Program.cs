// See https://aka.ms/new-console-template for more information

using assignment_1;

int exit = 1;
int hours = 0;
int min = 0;

while(exit != 0)
{
    hours = Input.InputNumber("Enter number of hours (0 - 11): ", Logic.CreateValidationForNumBetweenTwoNums(0, 11));

    if(hours == -1)
    {
        Console.WriteLine("Hours are out of bounds");
        continue;
    }

    min = Input.InputNumber("Enter number of minutes (0 - 59): ", Logic.CreateValidationForNumBetweenTwoNums(0, 11));

    if (min == -1)
    {
        Console.WriteLine("Minutes are out of bounds");
        continue;
    }

    double angle = Logic.CalculateLesserAngle(hours, min);

    Console.WriteLine($"Lesser angle between arrows is {angle}");

    exit = Input.InputNumber("Enter 0 to exit: ");
}