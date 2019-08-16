using System;

namespace GradeBook
{
  public static class PrintStat
  {
    public static string PrintStatistics(Book book)
    {
      var stats = book.GetStatistics();

      Console.WriteLine($"Teacher: {book.TeacherName}");
      Console.WriteLine($"Student: {book.StudentName}");
      Console.WriteLine($"Subject: {book.Subject}");
      Console.WriteLine($"The average grade is: {stats.Average:N2}");
      Console.WriteLine($"The Highest grade is: {stats.High:N2}");
      Console.WriteLine($"The Lowest grade is: {stats.Low:N2}");
      Console.WriteLine($"Assignments: {book.Grades.Count}");
      Console.WriteLine($"Total: {stats.Sum:N2}.{book.lineBreaker}");
      Console.WriteLine($"The letter grade is {stats.Letter}");
      return "Printed All";
    }

  }
}