using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is the teacher's name for this grade book?");
      var teacherName = Console.ReadLine();
      Console.WriteLine("What is the student's name for whom grades will be recorded:");
      var studentName = Console.ReadLine();
      Console.WriteLine("For which academic subject are the grades to be entered?");
      var subjectMatter = Console.ReadLine();

      var book = new Book(teacherName, studentName, subjectMatter);


      while (true)
      {
        Console.WriteLine("Enter student grade - or 'q' to exit.");
        var grade = Console.ReadLine();

        if (grade == "q")
        {
          break;
        }

        book.AddGrade(double.Parse(grade));
      }

      book.ListGrades();
      book.PrintStats(book);

      Book.Description();
    }
  }
}
