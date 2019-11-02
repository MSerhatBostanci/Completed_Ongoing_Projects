using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Stack myStack = new Stack();

            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);


            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine();
            //Console.WriteLine("==> İçeridekileri Stack sırasında yazdırma ");


            //foreach (var itm in myStack)
            //{
            //        Console.WriteLine(itm);
            //}

            //Console.WriteLine(myStack);





            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine();
            //Console.WriteLine("==> Stack'e son eklenen veya en yukarıdaki sayı");

            //Console.WriteLine(myStack.Peek());

            //int a = Convert.ToInt32(myStack.Peek());
            //Console.WriteLine(" a değeri = " +a);


            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine();
            //Console.WriteLine("==> Stack içerisinde kaç tane eleman var onu gösteriyoruz");
            //Console.WriteLine("Stack içerisindeki eleman sayısı:" + myStack.Count);


            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine();
            //Console.WriteLine("==>Stack içerisini pop komutu ile boşaltıyoruz");

            //while (myStack.Count > 3)
            //    Console.WriteLine(myStack.Pop());


            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine();
            //Console.WriteLine("==>Stack içerisinden eleman alıyoruz ");

            //object a;

            //a = myStack.Pop();
            //Console.WriteLine();

            //Console.WriteLine("Stack içerinden pop komutu ile eleman aldık = " + a);
            //Console.WriteLine();

            //Console.WriteLine("Stack içerisinde kalan elemanlar:");
            //foreach (var itm in myStack)
            //    Console.WriteLine(itm);



            //----------------------------------------------------------------------------------------------------



            //Console.WriteLine();
            //Console.WriteLine("==>Stack içerisinde aradığımız bir şey varmı diye kontrol ediyoruz");
            //Console.WriteLine("Stack içerisinde \"2\" değeri aranıyor");

            //if (myStack.Contains(2))
            //    Console.WriteLine("stack aradığınız değeri içeriyor");
            //else
            //    Console.WriteLine("stack aradığınız değeri içermiyor");

            //Console.WriteLine("Stack içerisinde \"10\" değeri aranıyor");


            //if (myStack.Contains(10))
            //    Console.WriteLine("stack aradığınız değeri içeriyor");
            //else
            //    Console.WriteLine("stack aradığınız değeri içermiyor");




            Console.WriteLine();
            Console.WriteLine("==>Stack içerisinde aradığımız elemanın bulunup bulunmadığını sorgulamanın alternatifi");

            Console.WriteLine("Stack içerisinde \"2\" bulunuyormu? " + myStack.Contains(2));

            Console.WriteLine(myStack.Contains(2));
            //Console.WriteLine("Stack içerisinde \"10\" bulunuyormu? " + myStack.Contains(10));


            //----------------------------------------------------------------------------------------------------



            //Console.WriteLine();

            //Stack stack2 = new Stack();

            //Console.WriteLine("==>Stack'imizi başka bir stack'e aktarıyoruz");

            //stack2 = myStack;
            //foreach (var itm2 in stack2)
            //    Console.WriteLine(itm2);


            //Stack myStack2 = new Stack();

            //Console.WriteLine("mystack 2 üyeleri");

            //foreach (var itm2 in myStack2)
            //    Console.WriteLine(itm2);


            //----------------------------------------------------------------------------------------------------



            //Console.WriteLine();
            //Console.WriteLine("==>stack içeriği bir array'e aktarıldı ve gösterildi");

            //Object[] array1 = myStack.ToArray();


            //Console.WriteLine(" arrayin 2. elemanı" + array1[1]);

            //Console.WriteLine();


            //foreach (var str in array1)
            //    Console.WriteLine(str);

            //Console.WriteLine();

            //----------------------------------------------------------------------------------------------------


            //Console.WriteLine("==>Tüm stack içeriğini temizleme");

            //myStack.Clear();

            //foreach (var itm in myStack)
            //    Console.WriteLine(itm);

            //Console.WriteLine("Number of elements in Stack:" + myStack.Count);



            //----------------------------------------------------------------------------------------------------














            //----------------------------------------------------------------------------------------------------

            Console.ReadLine();
        }
    }
}











