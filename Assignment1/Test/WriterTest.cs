using System;
using Xunit;

namespace Application1.Tests
{
    public class WriterTest
    {
        
        [Fact]
        public void TestExtention()
        {
            //arrange
            Writer w= new Writer();
            string createText = "No,Date,Timestamp,Level,Message" + Environment.NewLine;
            //act and assert
            Assert.Equal(".csv", w.PathGetter(createText));

        }
    }
}
