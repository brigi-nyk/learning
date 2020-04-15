using GradesBookProj;
using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;
            
            var result = log("Hello");
            Assert.Equal(3, count);
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }
        string IncrementCount(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            string name = "Brigi";
            string upperName = MakeUppercase(name);

            Assert.Equal("Brigi", name);
            Assert.Equal("BRIGI", upperName);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            //arrange
            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");
            //var book2 = GetBook("Book2");

            // //assert
            Assert.Equal("Book1", book1.Name);
            //Assert.Equal("Book2", book2.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book1");
            SetName(book1, "New Name");
            //var book2 = GetBook("Book2");

            // //assert
            Assert.Equal("New Name", book1.Name);
            //Assert.Equal("Book2", book2.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
 
            // //assert
            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferSameObject()
        {
            //arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            // //assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            //Assert.Equal("Book2", book2.Name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
