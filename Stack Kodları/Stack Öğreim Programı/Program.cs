using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Öğrenim_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" C#  System.Collections.Stack ÖĞRENME PROGRAMINA HOŞGELDİNİZ!! ");
            Console.WriteLine();

            Stack yoldeposu = new Stack();

            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------------------- ANA MENÜ -------------------------");
                Console.WriteLine(" 1. \"Stack\" komutu hakkında genel bilgi");
                Console.WriteLine(" 2. Yeni bir \"Stack\" oluşturmak");
                Console.WriteLine(" 3. Oluşturulmuş bir  \"Stack\" içerisine veri doldurmak");
                Console.WriteLine(" 4. Stack içerisinde bulunan elemanları yazdırmak veya okumak");
                Console.WriteLine(" 5. Stack içerisinde kaç adet eleman olduğunuz öğrenmek");
                Console.WriteLine(" 6. Stack içerisinden eleman çıkarmak ve değişkene atamak");
                Console.WriteLine(" 7. Stack içerisnde en üstte bulunan elemanı okumak");
                Console.WriteLine(" 8. Stack içerisinde bir elemanı aramak ");
                Console.WriteLine(" 9. Bir stack'in içini tamamen temizlemek");
                Console.WriteLine(" 0. Bir stack'i başka bir stack içine aktarma ve/veya kopyalamak");
                Console.WriteLine(" Q. Bir stack'i array içine kopyalamak");
                Console.WriteLine(" W. Stack kullanımı Örneği");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Programdan çıkmak için ESC tuşuna basın ");

                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!ESEN KALIN!!!");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }

                DateTime now = DateTime.Now;

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();

                if (key.Key == ConsoleKey.D1)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Yığınlar genelde aynı tipten verilerin tutulduğu\n" +
                        " ve Son Giren İlk Çıkar (LIFO) çalışma mantğını kullanan\n" +
                        " veri yapıları olarak tanımlanır. Bir yığına en son giren\n" +
                        " eleman ilk olarak çıkar. Yığınları anlatırken en çok üst üste\n" +
                        " konmuş tabaklar veya herhangi bir nesne grubunda çok\n" +
                        " kullanılana benzetirler. Mesela bir masanın üstünde sıra\n" +
                        " ile üst üste konmuş birden fazla tabaktan birisine ihtiyacımız\n" +
                        " olursa önce en üsttekini alırız. Bu aldığımız tabakların en son konulanıdır. ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Aşağıda verilen kod ile yeni bir \"Stack\" oluşturabiliriz. \n" +
                        " oluşturduğumuz \"Stack\"'in ismi \"stackNo1\" olsun. ");
                    Console.WriteLine();
                    Console.WriteLine("Stack stackNo1 = new Stack();");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ==> Bu şekilde bir \"Stack\" oluşturduğumuzda, bu \"Stack\"'in kapasitesi \n" +
                        " 1MB'tır. Ancak istesek oluşturacağımız \"Stack\"'e eleman limiti tanımlayabiliriz. \n" +
                        " Bunun yapmak için yeni oluşturduğumuz \"Stack\" içerisindeki paranteze eleman limitini \n" +
                        " sayı olarak yazmalıyız. Örnek olarak eleman limitini 10 ile sınırlayalım.");
                    Console.WriteLine();
                    Console.WriteLine("Stack stackNo1 = new Stack(10); ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ==> Oluşturdupumuz \"Stack\"'ler bir veri tipi belirtmediğimiz \n" +
                        " sürece \"Object\" tipindedir.Oluşturacağımız \"Stack\"'in veri tipini \n" +
                        " belirlemek için aşağıdaki \"Stack\" class'ının overload'undan faydalanıyoruz ve \n" +
                        " aşağıdaki gibi yazıyoruz ");
                    Console.WriteLine();
                    Console.WriteLine(" Stack<T> stackNo1 = new Stack<T>()  //Stack class'ının overload'u");
                    Console.WriteLine(" Stack<T> stackNo1 = new Stack<T>()  // int tipinde bir stack oluşturmak");

                    Console.ReadLine();
                    Console.Clear();

                }
                else if (key.Key == ConsoleKey.D3)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Oluşturmuş bulunduğumuz bir stack içerisine eleman eklemek için kullandığımız \n" +
                        " metot \"Push();\" metodudur. Bu metot içerisine yazılan veriyi \n" +
                        " oluşturduğumuz \"Stack\"'in en üstüne ekler. Kullanımı aşağıdaki gibidir.");
                    Console.WriteLine();
                    Console.WriteLine("stackNo1.Push(\"hello!\"); ");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Stack oluşturmayı ve oluşturduğumuz stack içerisine eleman atmayı gördük. \n" +
                        " Stack içerisine attığımız elemanları sırası ile görmek isteyebiliriz. Bu islemi \n" +
                        " \"foreach\" dongüsü ile yapabilmekteyiz. Aşağıdaki gibi yazabilyoruz");
                    Console.WriteLine();
                    Console.WriteLine("  foreach (var stackUye in stackNo1) \n" +
                        "     Console.WriteLine(stackUye);");

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ==> \"foreach\" dögüsü kullanmamızın sebebi stack içerisindeki bütün verileri \n" +
                        " teker teker çıkarıp okumasıdır. Bu döngüyü kullanmak yerine aşina olduğumuz \n" +
                        " Console.WriteLine(); metodunu kullanırsak aşağıdaki gibi bir sonuç alırız. ");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(stackNo1);   //Bu şekilde yazılırsa");
                    Console.WriteLine(" \" System.Collections.Stack \"   //Mesajını verir");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D5)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Stack içerisinde yer alan elemanların sayısını öğrenmek için \n" +
                        " Stack class'ının \" Count \" property'sinden faydalanıyoruz. \n" +
                        " Aşağıdaki gibi kullanılmaktadır ");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(stackNo1.Count);");
                    Console.WriteLine();
                    Console.WriteLine(" Başına mesaj yazarak kullanırsak:");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(\" Stack'in içerindeki eleman sayısı : \" + stackNo1.Count);  //komutu");
                    Console.WriteLine();
                    Console.WriteLine(" Stack'in içerindeki eleman sayısı : 7   //mesajını cevap olarak verir");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D6)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" Stack, FILO yapısında bir collection olduğu için stack içersinden eleman \n" +
                        " çıkartırken her zaman en üstte ne varsa onu çıkartabiliriz. Yani içine sırası ile  \n" +
                        " 1,2,3 ve 4 attığımız bir stack'ten eleman alırken tam tersi sırada ve sıralı olarak\n" +
                        " 4,3,2 ve 1 alabiliriz. Bu işlemi yaparken \" Pop() \" metodunu kullanırız.\n" +
                        " Bu metot aşağıdaki gibi kullanılmaktadır. ");
                    Console.WriteLine();
                    Console.WriteLine(" stackNo1.Pop();");
                    Console.WriteLine();

                    Console.WriteLine(" Bu komutu kullandığımızda yukarıda varsaydığımız gibi stack içerisinde\n" +
                        " 1,2,3 ve 4 sırasında stack'e atılmış elemanlardan \" 4 \" elemanı dışarı çıkar.\n" +
                        " Eğer bu Pop metodunu kullanırken başka bir değişkene tanımlanmaz ise bu sayı \n" +
                        " stack içerisinden silinmiş olur. Başka bir değişkene tanımlarsak Pop ile çıkan \n" +
                        " değer değişkene atanmış olur. İçerisine  sırasıyla 1,2,3 ve 4 atılmış \n" +
                        " stackNo1 adındaki stack ile aşağıda örnekleyelim. ");
                    Console.WriteLine();
                    Console.WriteLine(" object degisken = stackNo1.Pop();");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(\"Stack içerinden pop komutu ile eleman aldık = \" + degisken)");
                    Console.WriteLine();
                    Console.WriteLine(" Stack içerinden pop komutu ile eleman aldık = 4   //Mesajını alırız");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D7)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Stack'lerin sadece en üstte kalan üyeleri ile işlem yapabildiğimiz\n" +
                        " için en üstteki komutu sorgulamak önemlidir. Bunun için kullanılan \n" +
                        " metot \" Peek() \" metodudur. \" Peek() \" metodunu \" Pop() \" metodundan \n" +
                        " ayıran özelliği \" Peek() \" sadece en üstekini okur ama \"Pop()\" dışarı atar.\n" +
                        " Peek metodu aşağıdaki gibi kullanılır.");
                    Console.WriteLine();
                    Console.WriteLine(" stackNo1.Peek();");
                    Console.WriteLine();
                    Console.WriteLine(" İçerisine sırasıyla 1,2,3 ve 4 tanımlanmış stackNo1 adında bir stack'imiz olsun.");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(\" Stack'e son eklenen veya en yukarıdaki sayı : \" + stackNo1.Peek(); );    // yazarsak");
                    Console.WriteLine();
                    Console.WriteLine(" Stack'e son eklenen veya en yukarıdaki sayı : 4   // mesajını verir.");
                    Console.WriteLine();
                    Console.WriteLine(" İstersek peek ile çıkan sayıyı bir değişkene atayabiliriz. \n" +
                        " Ancak uygun tipe dönüştürmemiz gerekmektedir. Object tipindeki \n" +
                        " elemanları int tipine dönüstererek atamak istersek aşağıdaki gibi yapabiliriz.");
                    Console.WriteLine();

                    Console.WriteLine("int a = Convert.ToInt32(myStack.Peek());\n" +
                        " Console.WriteLine(\" a değeri = \" + a);    //komutlarını yazarsak \n" +
                        " a değeri = 5    // Sonucunu alırız.");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D8)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Doldurduğumuz stack içerisinde aradığımız bir elemanın olup olmadığını\n" +
                        " sorgulayabilmekteyiz. Bu metot \" Contains() \" metodudur. Boolean çevirir.\n" +
                        " Bu yüzden kullandığımızda sonuç olarak true veya false verir. Aşağıdaki gibi kullanılır. ");
                    Console.WriteLine();
                    Console.WriteLine("stackNo1.Contains(3);    // stack içerisinde 3 elemanını aradık");
                    Console.WriteLine();
                    Console.WriteLine("Console.WriteLine(myStack.Contains(2));   // Ekrana sadece true/false yazar");
                    Console.WriteLine();
                    Console.WriteLine("Ekrana aranan elemanın bulunup bulunmadığını yazdırmak istersek \" if \" kullanabiliriz.");
                    Console.WriteLine();
                    Console.WriteLine(" if (myStack.Contains(2))\n" +
                        "   Console.WriteLine(\"stack aradığınız değeri içeriyor\"); \n" +
                        " else \n" +
                        "   Console.WriteLine(\"stack aradığınız değeri içermiyor\");");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D9)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Dolu olan bir stack'i boşaltamamız gerekiyorsa \" Clear() \" \n" +
                        " metodunu kullabiliriz. Stack içerisindeki bütün elemanlar siliniş olur.\n" +
                        " Aşağıdaki gibi kullanılır.");
                    Console.WriteLine();
                    Console.WriteLine(" stackNo1.Clear(); ");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.D0)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> Bir stack'i başka bir stack'e aktarırken LIFO kavramı büyük önem taşır.\n" +
                        " Çünkü bu işlemi yaparken \" stackNo2 = stackNo1 \" şeklinde yapacağımız işlemde birebir \n" +
                        " kopyalanır. Ancak stackNo2'yi instance ederken stackNo1'i çağırırsak stack ters döner.\n" +
                        " 1,2,3 ve 4 tanımlı bir stackNo1 olduğunu varsayarak aşağıda iki işlemi örnekleyelim. ");
                    Console.WriteLine();
                    Console.WriteLine(" \" ---- stackNo2 = stackNo1 işlemi ---- \" ");
                    Console.WriteLine();
                    Console.WriteLine(" Stack stack2 = new Stack(); \n" +
                        " stackNo2 = stackNo1; \n" +
                        " foreach (var itm2 in stackNo2)\n" +
                        "    Console.WriteLine(itm2);");
                    Console.WriteLine();
                    Console.WriteLine(" Yazdığımız durumda ekrana şu yazılır :\n" +
                        " 4\n" +
                        " 3\n" +
                        " 2\n" +
                        " 1\n");
                    Console.WriteLine();
                    Console.WriteLine(" \" ---- stackNo2 için instance tanımlarken ---- \" ");
                    Console.WriteLine();
                    Console.WriteLine("Stack stackNo2 = new Stack(stackNo1); \n" +
                        "foreach (var itm in stackNo2)\n" +
                        "   Console.WriteLine(itm);");
                    Console.WriteLine();
                    Console.WriteLine(" Yazdığımız durumda ekrana şu yazılır :\n" +
                        " 1\n" +
                        " 2\n" +
                        " 3\n" +
                        " 4\n");

                    Console.WriteLine();
                    Console.WriteLine(" Stackler için bir ters çevirme metodu bulunmamakta ancak 2.yöntem kullanılarak\n" +
                        " bir stack'i ters çevirmek oldukça kolay.");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine(" ==> İçi dolu bir stacki kolayca bir array'e çevirebilmekteyiz. Bunu yaparken\n" +
                        " kullandığımız metot \" ToArray() \"'dir. İçerisine 1,2,3 ve 4 tanımlı \n" +
                        " bir stackNo1 alalım. Kullanımı aşağıdaki gibidir.");
                    Console.WriteLine();
                    Console.WriteLine(" Object[] array = stackNo1.ToArray();   // Komutu ile array'e çevrilmiş olur");
                    Console.WriteLine();
                    Console.WriteLine(" Bu arrayin içerisindeki değerleri okutalım. ");
                    Console.WriteLine();
                    Console.WriteLine(" foreach (var str in array) \n" +
                        "   Console.WriteLine(str);");
                    Console.WriteLine();
                    Console.WriteLine(" Bu komutlardan sonra ekranda şu görünür. ");
                    Console.WriteLine();
                    Console.WriteLine(" 4 \n" +
                        " 3\n" +
                        " 2\n" +
                        " 1");
                    Console.WriteLine();
                    Console.WriteLine(" Arrayin oluştuğunu göstermek için arrayin 2. elemanını yani \"3\" \n" +
                        " sayısını ekrana yazdıralım.");
                    Console.WriteLine();
                    Console.WriteLine(" Console.WriteLine(\" Arrayin 2.elemanı : \" + array[1]);   // yazıldığında");
                    Console.WriteLine("  Arrayin 2.elemanı : 3      //mesajını verir");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.W)
                {
                    object anahtar = key.KeyChar;
                    yoldeposu.Push("Menü " + anahtar);
                    yoldeposu.Push(now.Hour + ":" + now.Minute + ":" + now.Second);

                    Console.WriteLine("Gezilen toplam menü sayısı = " + ((yoldeposu.Count) / 2));
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("==> Gezilen Menülerin Sırası ve giriş zamanları");
                    Stack menulergosterim = new Stack(yoldeposu);

                    foreach (var menuler in menulergosterim)
                        Console.WriteLine(menuler);

                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
