using System;
using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book("Twisdale", "Byron", "Math");
      book.AddGrade(89.1);
      book.AddGrade(98.6);
      book.AddGrade(3.145962);
      book.AddGrade(40.1);
      book.AddGrade(114.1);

      book.listGrades();
      book.PrintStats(book);

      Book.description();

      book.clearGrades();

      book.listGrades();
    }
  }
}
