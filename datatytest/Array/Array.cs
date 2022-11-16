using System;

namespace DataStructures.Array
{
    public class Array
    {
        private Object[] InnerArray { get; set; }
        // ref. tipli ifadenin kullanılması için *object* bunun mutlaka başlatılması new lenmesi gerek, yoksa kullanılmaz.
        //sadece ınnerarray uzunluğunu döndürsün.
        public int Length => InnerArray.Length;

        public Array(int defaultSize=16)
        {
            InnerArray = new Object[defaultSize]; // diziler fixed size diziye bir boyut ver. default=16 yazılabilir ya da constructor a değer ver denir. istendiği zaman değişir.


        }

    }
}
