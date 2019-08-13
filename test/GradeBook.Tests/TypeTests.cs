using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void test2()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

[Fact]

public void StringsBehaveLikeValueTypes() {
  //in C# Strings are technically immutable
  string name = "Byron";
  var upper = MakeUpperCase(name);

  Assert.Equal("Byron", name);
  Assert.Equal("BYRON", upper);
}

private string MakeUpperCase(string parameter){
  return parameter.ToUpper(); 
}
        public int GetInt()
        {
            return 3;
        }
        [Fact]
        public void test1()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");
            Assert.Equal("Book1", book1.TeacherName);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name, "Twisdale", "Gym");
        }


        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.StudentName);
        }

        private void SetName(Book book1, string name)
        {
            book1.StudentName = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            //The first two .Equal asserts here are structured to accomplish what the .NotSame assert completes in one line.
            Assert.Equal("Book1", book1.TeacherName);
            Assert.Equal("Book2", book2.TeacherName);
            Assert.NotSame(book1, book2);
        }


        [Fact]
        public void TwoVarsCanReferenceSameObj()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;

            //these two Asserts do the same thing
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name, "twisdale", "math");
        }
    }
}
