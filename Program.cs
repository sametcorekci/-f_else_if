using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
          int time=DateTime.Now.Hour;
        //    Console.WriteLine(time);

        //    if(time>=6 && time<11)
        //         Console.WriteLine("Günaydın");

        //    else if(time<=18)
        //         Console.WriteLine("İyi günler");
        //     else
        //         // Console.WriteLine("İyi geceler");

                string sonuc = time<=18 ? " İyi günler" :"İyi geceler"; // Yukardaki iflerin tek satırda yazılmasını sağlayan Ternary kod bloğu
                sonuc = time>=6 && time<11 ? "Günaydın" : time<=18 ? " İyi günler" : "İyi geceler";
                Console.WriteLine(sonuc);
        }
    }
}
