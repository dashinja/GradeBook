using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void Test1()
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
  }
}
