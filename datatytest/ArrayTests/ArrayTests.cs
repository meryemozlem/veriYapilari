using System;
using Xunit;

namespace ArrayTests
{
    // scope bu uyg. diðeri solution bu xunit
    public class ArrayTests
    {
        //theory (parametre alýr.)
        [Theory]
        //16 lýk bir dizi oluþtur. 5TEST yazdým.
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        //istenilen boyutta dizi oluþturuyor mu kontrolü par. ile
        public void Check_Array_Constructor(int defaultSize)
        {
            //dependencies baðýmlýlýklardan Array seçilir ve refere eilir.
            //array sayfasýnýn baþýna using olan yere dataStructures ifadesi kondurdum.
            //arrange act
             var arr = new Array(defaultSize);

            //assert
            Assert.Equal(defaultSize, arr.Length);
        }
    }
}
