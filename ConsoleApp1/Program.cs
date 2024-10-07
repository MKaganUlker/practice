// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hell!");

int age = 25;
double salary = 50000;
double infilation_each_year = .5;
string name = "Johnny";
int year = 2024;
bool isEmployee = true;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Salary: " + salary);
Console.WriteLine("Is Employee: " + isEmployee);
double actual_salary;
actual_salary = infilation_each_year*salary;
while (age<=60){
Console.WriteLine("Salary: " + salary + " on Year: " + year);

Console.WriteLine("after infilation its worth is: "+actual_salary);
salary += 5000;
year++;
age++;
actual_salary *= infilation_each_year;
}
Console.WriteLine(name+ " Retired at the Year: "+year+" and with the salary of "+salary);
Console.WriteLine("after infilation its worth is: "+actual_salary);
Console.WriteLine(name+" is now "+50000/actual_salary+" times poorer when he started working");