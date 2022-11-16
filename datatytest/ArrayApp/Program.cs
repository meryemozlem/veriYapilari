using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //örtülü değişken tanımı. system array de tanımla. 4 elemanlı 0,1,2,3 indexleri var. arr=collection
            var arr = Array.CreateInstance(typeof(int), 4);
            //ilk elemanıa değer atayalım 23 değeri 0. indexte tutulur. indisleme olayı vardır.
            arr.SetValue(23, 0);
            arr.SetValue(44, 1);
            arr.SetValue(61, 2);
            arr.SetValue(55, 3);

            //projeyi startup yaptık ve 0. indexe 23, 1.indexe 44, 2.indexe 61 ve 3.indexe 55 değerlerini girdim.

            Console.WriteLine(arr.GetValue(0));

            try
            {
                Console.WriteLine(arr.GetValue(5));
            }
            catch (Exception ex)
            {
                //hata fırlattı.
                Console.WriteLine(ex.Message);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            // 5.index yok bu sebeple hata verir. Tanımlamadığın alana erişemezsin. Kullanıcı hatası.


            Console.ReadKey();

        }
    }
}
