using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
      // arrange section: objects and values
      var book = new Book("", "", "");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.3);

      // the act section
      var result = book.GetStatistics();

      // assert section
      Assert.Equal(85.6, result.Average, 1);
      Assert.Equal(90.5, result.High, 1);
      Assert.Equal(77.3, result.Low, 1);
    }

    [Fact]
    public void parameterMatch()
    {
      //arrange
      var book = new Book("favorite", "Me", "maths");

      //act
      var actualTeacher = book.TeacherName;
      var expectedTeacher = "favorite";
      var actualStudent = book.StudentName;
      var expectedStudent = "Me";

      //assert
      Assert.Equal(expectedTeacher, actualTeacher);
      Assert.Equal(expectedStudent, actualStudent);
    }

    [Fact]
    public void printResults()
    {
      //arrange
      var book = new Book("Judy", "Megan", "Language Arts");

      //act
      var result = book.PrintStats(book);

      //assert
      Assert.Equal("Printed All",result);
    }
  }
}
