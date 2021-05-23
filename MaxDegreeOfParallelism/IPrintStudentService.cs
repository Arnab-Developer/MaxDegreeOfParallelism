using System.Collections.Generic;

namespace MaxDegreeOfParallelism
{
    internal interface IPrintStudentService
    {
        void PrintSingleThread(IEnumerable<Student> students);

        void PrintMultiThread(IEnumerable<Student> students);

        void PrintMultiThreadWithMaxDegreeOfParallelism(IEnumerable<Student> students, int maxDegreeOfParallelism);
    }
}
