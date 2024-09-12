Console.Clear();

string studentName = "Sophia Johnson";

string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

Console.WriteLine($"Student:\t\t{studentName}\n");
Console.WriteLine("Nombre del curso \t Horas \t Notas");
Console.WriteLine($"{course1Name} \t\t{course1Grade} \t{course1Credit}");
Console.WriteLine($"{course2Name} \t\t{course2Grade} \t{course2Credit}");
Console.WriteLine($"{course3Name} \t\t{course3Grade} \t{course3Credit}");
Console.WriteLine($"{course4Name} \t{course4Grade} \t{course4Credit}");
Console.WriteLine($"{course5Name} \t\t{course5Grade} \t{course5Credit}");


int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

Console.WriteLine();
//Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

//Console.WriteLine($"Final GPA: {gradePointAverage}");

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;
//Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");

Console.WriteLine($"Final GPA:\t\t{gradePointAverage.ToString("##.#").Replace(',', '.')}");
Console.WriteLine($"Final GPA:\t\t{gradePointAverage:F1}");

decimal x = 7 / 5;
gradePointAverage = 3.99872831m;
Console.WriteLine((int)gradePointAverage);