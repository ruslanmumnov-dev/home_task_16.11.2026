using Domain;

namespace Application;

public class StudentService
{
    List<Student> students = [];
    public void Create(Student st)
    {
        students.Add(st);
    }
    public void GetInfo()
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.Write($"{i+1}. ");
            Console.WriteLine($"FullName: {students[i].FirstName} {students[i].LastName}");
            System.Console.WriteLine($"Age: {students[i].Age}");
        }
    }
}
