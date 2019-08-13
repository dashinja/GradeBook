using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public List<double> Grades;
    public string TeacherName;

    public string StudentName;
    public string Subject;

    public string lineBreaker = "\n===========================\n";
    static private string lineBreaker2 = "\n===========================";


    public Book(string teacherName, string studentName, string subject)
    {
      Grades = new List<double>();
      TeacherName = teacherName;
      StudentName = studentName;
      Subject = subject;
    }
    public void AddGrade(double grade)
    {
      if (grade > 100 || grade < 0)
      {
        Console.WriteLine($"You added grade '{grade}'. Grades outside the range 0-100 are not saved.{lineBreaker}");
      }
      else
      {
        Grades.Add(grade);
        Console.WriteLine($"Grade of {grade} added.");
      }
    }

    public void ClearGrades()
    {
      Grades.Clear();
      Grades.Add(0);
      Console.WriteLine($"Grades cleared for {StudentName}.{lineBreaker}");
    }

    public void ListGrades()
    {
      string verb = Grades.Count == 1 ? "is" : "are";
      string agreement = Grades.Count == 1 ? "grade" : "grades";

      if (Grades.Count < 1)
      {
        Console.WriteLine($"There aren't any grades in {this.TeacherName}'s gradebook:{lineBreaker}");
      }
      else
      {
        Console.WriteLine($"There {verb} {Grades.Count} {agreement} in {this.TeacherName}'s book.");
        foreach (var item in Grades)
        {
          Console.WriteLine($"Grade: {item}");
        }
        Console.WriteLine(lineBreaker);
      }

    }

    
    public string PrintStats(Book book)
    {
      return PrintStat.PrintStatistics(book);
    }

    public Statistics GetStatistics()
    {
      if (Grades.Equals(null))
      {
        this.ListGrades();
        Console.WriteLine("Yeah, things were null!");
        return null;
      }
      else
      {
        var total = new Statistics();
        total.High = double.MinValue;
        total.Low = double.MaxValue;
        total.Sum = 0;

        foreach (var grade in Grades)
        {
          total.High = Math.Max(grade, total.High);
          total.Low = Math.Min(grade, total.Low);
          total.Sum += grade;
        }

        total.Average = total.Sum / Grades.Count;

        return total;
      }

    }
    static public void Description()
    {
      Console.WriteLine($"Description: \nThe class Book is used to create instances of a grade book.\n\nA new instance is instantiated with the following syntax:\nvar <variableName> = new Book(<teacherName>, <studentName>, <subjectArea>);\n\nThe methods included are: '.AddGrade()', '.ClearGrades()', '.GetStatistics()', '.ListGrades()', '.PrintStats()' and the method used to invoke this description - '.Description()'.{lineBreaker2}");
    }
  }
}