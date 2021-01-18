using System;

namespace refAndOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            /** -------ref keyword kullanımı-------------
            int sayi1 = 20;
            int sayi2 = 100;
            var sonuc = Add(ref sayi1, sayi2);
            Console.WriteLine(sonuc);//130 yazılacaktır.
            Console.WriteLine(sayi1);//sayi1 = 20 olacaktır çünkü değer tiplerle çalışıldığı için değişkenin değeri önemlidir. Parametre olarak 20 sayılacaktır.
            ------------ref keyword kullanımı----------- **/
            int sayi1;//out keyword kullanımında sayi1 değerini set etmek zorunda değiliz.
            int sayi2 = 100;
            var sonuc = Add(out sayi1, sayi2);
            Console.WriteLine(sonuc);
            //Console.WriteLine(Add(2,4));
        }

        /**static int Add(int sayi1,int sayi2=30)//default değer : sayi2 ye değer verilmediği zaman default olarak 30 sayılmasıdır.Ve default değerler her zaman en son parametre olarak yazılmalıdır.Birden fazla default değer verilebilir.
        {
            return sayi1 + sayi2;
        }**/

        /**static int Add(ref int sayi1, int sayi2)//ref kullanıldığında bellekte sayi1 in referans değerini kullan demiş olmaktayız. ref keyword : Değer tiplerin referans tip gibi kullanılmasını sağlar. ref tanımında sayi1 e mutlaka ilk başta bir değer ataması yapmalıyız.
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }**/
        static int Add(out int sayi1, int sayi2)//out keyword kullanımı ref ile aynıdır.
        {
            sayi1 = 30;//out kullanımında başta set edilmese de methodun içinde mutlaka bir kere de olsa set edilmelidir.
            return sayi1 + sayi2;
        }

    }
}
