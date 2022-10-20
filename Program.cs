int possiblePoint = 0;
int totalPoint = 0;

Console.Write("Did you participate in the first written exam? Type 'yes' or 'no': ");
string PartFirstExam = Console.ReadLine()!;

if (PartFirstExam == "yes")
{
    possiblePoint += 20;
    Console.Write("Please type in how many points you got: ");
    int FirstPoint = int.Parse(Console.ReadLine()!);
    totalPoint += FirstPoint;
}
else if (PartFirstExam == "no")
{ }

Console.Write("Did you participate in the second written exam? Type 'yes' or 'no': ");
string PartSecondExam = Console.ReadLine()!;

if (PartSecondExam == "yes")
{
    possiblePoint += 20;
    Console.Write("PLease type in how many points you got: ");
    int SecondPoint = int.Parse(Console.ReadLine()!);
    totalPoint += SecondPoint;
}
else if (PartSecondExam == "no")
{ }

possiblePoint += 20;
Console.Write("Please enter the amount of points you got through homework: ");
int homeworkPoint = int.Parse(Console.ReadLine()!);
totalPoint += homeworkPoint;

Console.Write("Did you participate in an oral exam? Type 'yes' or 'no': ");
string PartOralExam = Console.ReadLine()!;

if (PartOralExam == "yes")
{
    possiblePoint += 20;
    Console.Write("Please enter the amount of points you got through the oral exam: ");
    int oralPoint = int.Parse(Console.ReadLine()!);
    totalPoint += oralPoint;
}
else if (PartOralExam == "no")
{ }

int percentage = 100 * totalPoint / possiblePoint; //rechnet immer von links nach rechts; wenn man 40/30 rechnet kommt eine Kommazahl heraus und es ist kein doubel; also einfach erst multiplizieren
int grade = 0;

if (percentage >= 89) { grade = 1; }
else if (percentage is >= 76 and < 89) { grade = 2; } //mit shift, alt, strg in mehreren zeilen gleichzeitg schreiben
else if (percentage is >= 63 and < 76) { grade = 3; }
else if (percentage is >= 50 and < 63) { grade = 4; }
else if (percentage is < 50) { grade = 5; }

Console.WriteLine("Your grade is " + grade + ".");

int percentHome = 100 * (totalPoint - homeworkPoint + 20) / possiblePoint;
int gradeHome = 0;

if (homeworkPoint < 20)
{
    if (percentHome >= 89) { gradeHome = 1; }
    else if (percentHome is >= 76 and < 89) { gradeHome = 2; } //mit shift, alt, strg in mehreren zeilen gleichzeitg schreiben
    else if (percentHome is >= 63 and < 76) { gradeHome = 3; }
    else if (percentHome is >= 50 and < 63) { gradeHome = 4; }
    else if (percentHome is < 50) { gradeHome = 5; }

    Console.WriteLine("If you would have done all your homework you would have gotten a " + gradeHome + ".");

}