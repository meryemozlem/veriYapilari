using System;
using Xunit;

namespace ArrayTests
{
    // scope bu uyg. di�eri solution bu xunit
    public class ArrayTests
    {
        //theory (parametre al�r.)
        [Theory]
        //16 l�k bir dizi olu�tur. 5TEST yazd�m.
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        //istenilen boyutta dizi olu�turuyor mu kontrol� par. ile
        public void Check_Array_Constructor(int defaultSize)
        {
            //dependencies ba��ml�l�klardan Array se�ilir ve refere eilir.
            //array sayfas�n�n ba��na using olan yere dataStructures ifadesi kondurdum.
            //arrange act
             var arr = new Array(defaultSize);

            //assert
            Assert.Equal(defaultSize, arr.Length);
        }
    }
}
