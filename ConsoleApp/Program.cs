
using Application;
using Domain;

Student st1 = new  Student ()
{
    FirstName = "Abdullo",
    LastName = "Pochoev",
    Age = 20,
    Grades = [1,2,3,4,5]
};

Student st2 = new  Student ()
{
    FirstName = "Abdullo",
    LastName = "Pochoev",
    Age = 20,
    Grades = [1,2,3,4,5]
};

Student st3 = new  Student ()
{
    FirstName = "Abdullo",
    LastName = "Pochoev",
    Age = 20,
    Grades = [1,2,3,4,5]
};

Student st4 = new  Student ()
{
    FirstName = "Abdullo",
    LastName = "Pochoev",
    Age = 20,
    Grades = [1,2,3,4,5]
};

StudentService studentService = new StudentService();

studentService.Create(st1);
studentService.Create(st2);
studentService.Create(st3);
studentService.Create(st4);

studentService.GetInfo();
