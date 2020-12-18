using System;
using Xunit;

namespace Application1.Tests
{
    public class ValidateTest
    {
        
        [Fact]
        public void TestPath()
        {
            //arrange
            Validator v= new Validator();
            string dir_path=@"C:\Users\mrudulap\Downloads\2020_02\2020_02";
            //act and assert
            Assert.Equal(true, v.validate(dir_path));


        }
    }
}
