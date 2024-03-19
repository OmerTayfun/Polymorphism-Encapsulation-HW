using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_HW.Encapsulation
{
    //Encapsulation (kapsülleme)
    //nesne yönelimli programlama (OOP) kavramlarından biridir ve bir sınıfın
    //içinde veri alanları (fields) ve bu verilere erişim sağlayan metotların
    //(methods) bir arada bulunması prensibini ifade eder. Bu prensibe göre,
    //sınıfın içindeki veriye doğrudan erişim yerine, bu veriye erişim
    //sağlayan metotlar aracılığıyla erişilmesi tercih edilir. Böylece verinin
    //güvenliği ve esnekliği sağlanır ve sınıfın iç yapısı dışarıya gizlenir.
    public class Car
    {
        private int speed;

        public int GetSpeed()
        {
            return speed;
        }

        public void SpeedConfig(int newSpeed)
        {
            if (newSpeed >= 0 && newSpeed <= 200)
            {
                speed = newSpeed;
            }
            else
            {
                Console.WriteLine("Hız sınırları dışında bir değer girdiniz");

            }

        

        }
        public void increaseSpeed(int increase)
        {
            SpeedConfig(speed + increase);
        }
        public void decreaseSpeed(int decrease)
        {
            SpeedConfig(speed - decrease);
        }


    }
}
