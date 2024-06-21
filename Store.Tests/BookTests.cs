using System;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_Null_ReturnFalse()
        {
            bool result = Book.IsIsbn(null);
            Assert.False(result);
        }
        [Fact]
        public void IsIsbn_Spaces_ReturnFalse()
        {
            bool result = Book.IsIsbn("       ");
            Assert.False(result);
        }
        [Fact]
        public void IsIsbn_InvalidIsbn_ReturnFalse()
        {
            bool result = Book.IsIsbn("ISBN 123");
            Assert.False(result);
        }
        [Fact]
        public void IsIsbn_ValidIsbn10_ReturnTrue()
        {
            //                         valid Isbn
            bool result = Book.IsIsbn("IsBn 123-456-789 0");
            Assert.True(result);
        }
        [Fact]
        public void IsIsbn_ValidIsbn13_ReturnTrue()
        {
            //                         valid Isbn
            bool result = Book.IsIsbn("IsBn 123-456-789 0123");
            Assert.True(result);
        }
        [Fact]
        public void IsIsbn_TrashStart_ReturnFalse()
        {
            //                         valid Isbn
            bool result = Book.IsIsbn("xxx IsBn 123-456-789 0123");
            Assert.False(result);
        }
        [Fact]
        public void IsIsbn_TrashEnding_ReturnFalse()
        {
            //                         valid Isbn
            bool result = Book.IsIsbn("IsBn 123-456-789 0123 yyy");
            Assert.False(result);
        }
    }
}