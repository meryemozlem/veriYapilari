using System;
using ValueAndReferanceType;
using Xunit;

namespace xunitTestProject
{
    public class ValueAndReferanceTypesTests
    {
        //tek 1 class 1 reftype test metotu
        [Fact]
        public void RefTypesTest()
        {
            //Arrange
            var p1 = new RefType()
            {
                X=10,
                Y=20
            };

            var p2 = p1;
            /*var p2 = new RefType()
            {
                X = 50,
                Y = 40
            };
            */


            //Act
            p1.X = 30;

            //Assert
            Assert.Equal(p1.X,p2.X);

        }

        [Fact]
        public void ValTypesTest()
        {
            //Arrange
            var p1 = new ValueAndReferanceType.ValueType()
            {
                X = 10,
                Y = 20
            };

            var p2 = p1;

            //Act
            p1.X = 30;

            //Assert
            //test sonucu olumlu
            Assert.NotEqual(p1.X, p2.X);

        }


    }

        
}
