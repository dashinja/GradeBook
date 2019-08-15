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
    public string AddGrade(double grade)
    {
      if (grade > 100 || grade < 0)
      {
        Console.WriteLine($"You added grade '{grade}'. Grades outside the range 0-100 are not saved.{lineBreaker}");
        return $"Grades outside the range 0-100 are not saved.";
      }
      else
      {
        Grades.Add(grade);
        Console.WriteLine($"Grade of {grade} added.");
        return $"Grade added.";
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

public void AddLetterGrade(char letter)
{
  switch (letter)
  {
      case 'A':
      AddGrade(90);
      break;

      case 'B':
      AddGrade(80);
      break;

      case 'C':
      AddGrade(70);
      break;

      case 'D':
      AddGrade(60);
      break;

      case 'F':
      AddGrade(0);
      break;

      default:
        AddGrade(0);
        break;
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

        
        for (var index = 0; index < Grades.Count; index++)
        {
          if (Grades[index] == 98.6)
          {
            // break;
            // continue;
            // goto done;
          }
          total.High = Math.Max(Grades[index], total.High);
          total.Low = Math.Min(Grades[index], total.Low);
          total.Sum += Grades[index];
        };
        // var index = 0;
        // while(index < Grades.Count)
        // {
        //   total.High = Math.Max(Grades[index], total.High);
        //   total.Low = Math.Min(Grades[index], total.Low);
        //   total.Sum += Grades[index];
        //   index+=1;
        // };
        // foreach (var grade in Grades)
        // {
        //   total.High = Math.Max(grade, total.High);
        //   total.Low = Math.Min(grade, total.Low);
        //   total.Sum += grade;
        // }

        total.Average = total.Sum / Grades.Count;

        switch (total.Average)
        {
            case var d when d >= 90.0:
            total.Letter = 'A';
            break;

            case var d when d >= 80.0:
            total.Letter = 'B';
            break;

            case var d when d >= 70.0:
            total.Letter = 'C';
            break;

            case var d when d >= 60.0:
            total.Letter = 'D';
            break;

            default:
            total.Letter = 'F';
            break;
        }
        
        return total;
      }

    }
    static public void Description()
    {
      Console.WriteLine($"Description: \nThe class Book is used to create instances of a grade book.\n\nA new instance is instantiated with the following syntax:\nvar <variableName> = new Book(<teacherName>, <studentName>, <subjectArea>);\n\nThe methods included are: '.AddGrade()', '.ClearGrades()', '.GetStatistics()', '.ListGrades()', '.PrintStats()' and the method used to invoke this description - '.Description()'.{lineBreaker2}");
    }
  }
}