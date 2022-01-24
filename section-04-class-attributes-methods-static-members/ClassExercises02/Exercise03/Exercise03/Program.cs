using System.Globalization;
using Exercise03;

Student student = new Student();

Console.Write("Nome do aluno: ");
student.Name = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
student.GradeOne = double.Parse(Console.ReadLine());
student.GradeTwo = double.Parse(Console.ReadLine());
student.GradeThree = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(student);