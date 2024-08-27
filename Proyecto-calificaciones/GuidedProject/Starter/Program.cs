using System;

// initialize variables - graded assignments 
int examtAssignments = 5;

string[] nombres = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

//Calificaciones
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] score = new int[10];
string nota = "";

Console.WriteLine("Student\t\tPromedio\tGrade\n");

foreach (var name in nombres)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        score = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        score = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        score = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        score = loganScores;
    }
    else if (currentStudent == "Becky")
    {
        score = beckyScores;
    }
    else if (currentStudent == "Chris")
    {
        score = chrisScores;
    }
    else if (currentStudent == "Eric")
    {
        score = ericScores;
    }
    else if (currentStudent == "Gregor")
    {
        score = gregorScores;
    }
    else
    {
        continue;
    }

    int sumScores = 0;
    decimal promedio = 0;
    int tareasExtra = 0;

    foreach (var item in score)
    {
        tareasExtra += 1;

        if (tareasExtra <= examtAssignments)
        {
            sumScores += item;
        }
        else
        {
            sumScores += item / 10;
        }
    }

    promedio = (decimal)(sumScores) / examtAssignments;

    if (promedio >= 97)
    {
        nota = "A+";
    }
    else if (promedio >= 93)
    {
        nota = "A";
    }
    else if (promedio >= 90)
    {
        nota = "A-";
    }
    else if (promedio >= 87)
    {
        nota = "B+";
    }
    else if (promedio >= 83)
    {
        nota = "B";
    }
    else if (promedio >= 80)
    {
        nota = "B-";
    }
    else if (promedio >= 77)
    {
        nota = "C+";
    }
    else if (promedio >= 73)
    {
        nota = "C";
    }
    else if (promedio >= 70)
    {
        nota = "C-";
    }
    else if (promedio >= 67)
    {
        nota = "D+";
    }
    else if (promedio >= 63)
    {
        nota = "D";
    }
    else if (promedio >= 60)
    {
        nota = "D-";
    }
    else
    {
        nota = "F";
    }

    Console.WriteLine($"{currentStudent}\t\t{promedio}\t\t{nota}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
