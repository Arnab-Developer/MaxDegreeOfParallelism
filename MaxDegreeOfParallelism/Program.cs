using MaxDegreeOfParallelism;
using System;
using System.Collections.Generic;

List<Student> students = new()
{
    new Student() { Id = 1, FirstName = "f1", LastName = "l1" },
    new Student() { Id = 2, FirstName = "f2", LastName = "l2" },
    new Student() { Id = 3, FirstName = "f3", LastName = "l3" },
    new Student() { Id = 4, FirstName = "f4", LastName = "l4" },
    new Student() { Id = 5, FirstName = "f5", LastName = "l5" },
    new Student() { Id = 6, FirstName = "f6", LastName = "l6" },
    new Student() { Id = 7, FirstName = "f7", LastName = "l7" },
    new Student() { Id = 8, FirstName = "f8", LastName = "l8" },
    new Student() { Id = 9, FirstName = "f9", LastName = "l9" },
    new Student() { Id = 10, FirstName = "f10", LastName = "l10" }
};

IPrintStudentService printStudentService = new PrintStudentService();
printStudentService.PrintSingleThread(students);
printStudentService.PrintMultiThread(students);

Console.Write("Provide max degree of parallelism value: ");
int maxDegreeOfParallelism;
try
{
    maxDegreeOfParallelism = int.Parse(Console.ReadLine());
}
catch
{
    maxDegreeOfParallelism = 1;
}
printStudentService.PrintMultiThreadWithMaxDegreeOfParallelism(students, maxDegreeOfParallelism);
