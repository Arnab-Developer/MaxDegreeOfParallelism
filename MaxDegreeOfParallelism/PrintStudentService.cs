using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MaxDegreeOfParallelism
{
    internal class PrintStudentService : IPrintStudentService
    {
        void IPrintStudentService.PrintSingleThread(IEnumerable<Student> students)
        {
            Console.WriteLine("---- PrintSingleThread");
            Stopwatch st = Stopwatch.StartNew();
            foreach (var student in students)
            {
                Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}, Id: {student.Id}, Name: {student.FirstName} {student.LastName}");
                Thread.Sleep(2000);
            }
            st.Stop();
            Console.WriteLine($"Time took: {st.ElapsedMilliseconds / 1000} sec");
            Console.WriteLine();
        }

        void IPrintStudentService.PrintMultiThread(IEnumerable<Student> students)
        {
            Console.WriteLine("---- PrintMultiThread");
            Stopwatch st = Stopwatch.StartNew();
            Parallel.ForEach(students, student =>
            {
                Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}, Id: {student.Id}, Name: {student.FirstName} {student.LastName}");
                Thread.Sleep(2000);
            });
            st.Stop();
            Console.WriteLine($"Time took: {st.ElapsedMilliseconds / 1000} sec");
            Console.WriteLine();
        }

        void IPrintStudentService.PrintMultiThreadWithMaxDegreeOfParallelism(IEnumerable<Student> students, int maxDegreeOfParallelism)
        {
            Console.WriteLine("---- PrintMultiThreadWithMaxDegreeOfParallelism");
            Stopwatch st = Stopwatch.StartNew();
            Parallel.ForEach(
                students,
                new ParallelOptions() { MaxDegreeOfParallelism = maxDegreeOfParallelism },
                student =>
                {
                    Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}, Id: {student.Id}, Name: {student.FirstName} {student.LastName}");
                    Thread.Sleep(2000);
                });
            st.Stop();
            Console.WriteLine($"Time took: {st.ElapsedMilliseconds / 1000} sec");
            Console.WriteLine();
        }
    }
}