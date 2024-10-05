using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };
int[] marioScores = new int[] { 80, 90, 80, 90, 85 };
int[] anthonyScores = new int[] { 62, 62, 62, 62, 62, 100};

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor", "Mario", "Anthony" };

Console.Clear();
Console.WriteLine("Grade Marker - V2\n");
// Underline words
// Start underline \u001b[4m
// End underline \u001b[24m
Console.WriteLine("\u001b[4mStudent\u001b[24m\t\t\u001b[4mExam Score\u001b[24m\t\u001b[4mOverall\u001b[24m\t\u001b[4mGrade\u001b[24m\t\u001b[4mExtra Credit\u001b[24m\n");

foreach (string name in studentNames)
{
  string currentStudent = name;
  int sumAssignmentScores = 0; // normal assignemnts
  int sumExtraCredit = 0; // extra credit
  decimal extraPoints = 0;
  decimal currentStudentGrade = 0;
  int extraCreditGrade = 0;
  decimal totalGrade = 0;
  int gradedAssignments = 0;
  string spacing = "\t\t";

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  else if (currentStudent == "Emma")
    studentScores = emmaScores;
  else if (currentStudent == "Logan")
    studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
      studentScores = chrisScores;
  else if (currentStudent == "Eric")
      studentScores = ericScores;
  else if (currentStudent == "Gregor")
      studentScores = gregorScores;
  else if (currentStudent == "Mario")
      studentScores = marioScores;
  else if (currentStudent == "Anthony")
      studentScores = anthonyScores;
  else
      continue;
  
  foreach (int score in studentScores)
  {
    gradedAssignments++;

    if (gradedAssignments <= currentAssignments)
    {
      sumAssignmentScores += score;
    }
    else
    {
      sumExtraCredit += score;
    }
  }

  extraPoints = (decimal) sumExtraCredit / 50;
  if (studentScores.Length - currentAssignments > 0)
  {
    extraCreditGrade = sumExtraCredit / (studentScores.Length - currentAssignments);
  }

  totalGrade = ((decimal)(sumAssignmentScores) / currentAssignments) + extraPoints;
  currentStudentGrade = (decimal) sumAssignmentScores / currentAssignments;

  if (totalGrade >= 97)
    currentStudentLetterGrade = "A+";
  else if (totalGrade >= 93)
    currentStudentLetterGrade = "A";
  else if (totalGrade >= 90)
    currentStudentLetterGrade = "A-";
  else if (totalGrade >= 87)
    currentStudentLetterGrade = "B+";
  else if (totalGrade >= 83)
    currentStudentLetterGrade = "B";
  else if (totalGrade >= 80)
    currentStudentLetterGrade = "B-";
  else if (totalGrade >= 77)
    currentStudentLetterGrade = "C+";
  else if (totalGrade >= 73)
    currentStudentLetterGrade = "C";
  else if (totalGrade >= 70)
    currentStudentLetterGrade = "C-";
  else if (totalGrade >= 67)
    currentStudentLetterGrade = "D+";
  else if (totalGrade >= 63)
    currentStudentLetterGrade = "D";
  else if (totalGrade >= 60)
    currentStudentLetterGrade = "D-";
  else
    currentStudentLetterGrade = "F";

  if (currentStudent.Length > 6)
    spacing = "\t";

  Console.WriteLine($"{currentStudent}:{spacing}{currentStudentGrade}\t\t{totalGrade}\t{currentStudentLetterGrade}\t{extraCreditGrade, -3} ({extraPoints} pts)");
}

Console.WriteLine("\n\nPress the Enter key to continue\n");
Console.ReadLine();
