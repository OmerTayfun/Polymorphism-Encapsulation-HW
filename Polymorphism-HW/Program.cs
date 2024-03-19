using Polymorphism_HW;
using Polymorphism_HW.Controllers;
using Polymorphism_HW.Entities;
using Polymorphism_HW.Polymorphism;
using System.Runtime.CompilerServices;
using System.Xml.Linq;


ItalianRestaurant italianRestaurant =new ItalianRestaurant();
italianRestaurant.Id = 1;
italianRestaurant.RestaurantName = "Le Passetto";
italianRestaurant.RestaurantAdress = "İtalya";
italianRestaurant.RestaurantKitchenType = "İtalyan Lezzetleri";
italianRestaurant.ItalianWineType = "Beyaz Şarap,Kırmızı Şarap";
italianRestaurant.ServiceStyle = "Masaya servis";

ChineseRestaurant chineseRestaurant =new ChineseRestaurant();
chineseRestaurant.Id = 1;
chineseRestaurant.RestaurantName = "Kin Gin Chun";
chineseRestaurant.RestaurantAdress = "İstanbul";
chineseRestaurant.RestaurantKitchenType = "Çin Lezzetleri";
chineseRestaurant.ServiceEquipment = "Çubuk";
chineseRestaurant.ServiceStyle = "Self Servis";

NormalCustomer normalCustomer = new NormalCustomer();
normalCustomer.CustomerFirstName = "Ömer";
normalCustomer.CustomerLastName = "Tayfun";
normalCustomer.FirstVisitComplimentary = true;
normalCustomer.LoyaltyPoints = 50;

VipCustomer vipCustomer1 = new VipCustomer();
vipCustomer1.CustomerFirstName = "Ömer";
vipCustomer1.CustomerLastName = "Tayfun";
vipCustomer1.CustomerEmail = "omertayfun@gmail.com";
vipCustomer1.CustomerPhone = "1113342234";
vipCustomer1.CustomerRegion = "Türkiye";
vipCustomer1.FavoriteRestaurant = "İtalyan Restoranı";
vipCustomer1.FavoriteFood = "Spagetti";
vipCustomer1.VipService = "Masaya eğlence ve yemek hizmeti";
vipCustomer1.VipDiscount = 10;

CustomerManager.VipInfo();

Console.WriteLine(vipCustomer1.Id + " " + vipCustomer1.CustomerFirstName + " " + vipCustomer1.CustomerLastName
    + " " + vipCustomer1.CustomerEmail + " " + vipCustomer1.CustomerPhone + " " + vipCustomer1.CustomerRegion+" "+vipCustomer1.FavoriteRestaurant+
    " " + vipCustomer1.FavoriteFood + " " + vipCustomer1.VipService + " İndirim Yüzdesi %" + vipCustomer1.VipDiscount);

Console.WriteLine(italianRestaurant.RestaurantName+" "+italianRestaurant.RestaurantAdress+" "+italianRestaurant.RestaurantAdress
    +" "+italianRestaurant.RestaurantKitchenType);

RestaurantManager.Save();








