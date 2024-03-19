


using Polymorphism_HW.Encapsulation;
using System.ComponentModel.DataAnnotations;

////Encapsulation (kapsülleme)
//nesne yönelimli programlama (OOP) kavramlarından biridir ve bir sınıfın
//içinde veri alanları (fields) ve bu verilere erişim sağlayan metotların
//(methods) bir arada bulunması prensibini ifade eder. Bu prensibe göre,
//sınıfın içindeki veriye doğrudan erişim yerine, bu veriye erişim
//sağlayan metotlar aracılığıyla erişilmesi tercih edilir. Böylece verinin
//güvenliği ve esnekliği sağlanır ve sınıfın iç yapısı dışarıya gizlenir.

Car car = new Car();
car.SpeedConfig(100);

Console.WriteLine("Araç hızınız: "+car.GetSpeed());

car.increaseSpeed(20);

Console.WriteLine("Araç hızınız: " + car.GetSpeed()+" Yavaşlayın");

car.decreaseSpeed(30);
Console.WriteLine("Araç hızınız: " + car.GetSpeed());


Console.WriteLine("Aracın güncel hızı: " + car.GetSpeed());

