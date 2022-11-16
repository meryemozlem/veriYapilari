using System;
using ValueAndReferanceType;
//bu ifade import olarak düşünülebilir. kullanacağın kütüphaneyi ekle.
 
namespace ValueAndRefTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesne türet constructions
            //kafa karışıklığı üretmesin diywm sistemin altındaki yeri işaret ettim . ile
            var p1 = new ValueAndReferanceType.ValueType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            p2.X = 30;

            //string interpolasyon
            Console.WriteLine($" P1: {p1.X} {p1.Y} ");
            Console.WriteLine($" P2:  {p2.X} {p2.Y} ");

        }


}
}
