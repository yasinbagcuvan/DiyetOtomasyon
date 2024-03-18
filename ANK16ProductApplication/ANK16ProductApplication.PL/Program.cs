// See https://aka.ms/new-console-template for more information
using ANK16productApplication.BL.Manager.Concrete;
using ANK16productApplication.BL.Models;
using ANK16ProductApplication.DAL.Entities;

Console.WriteLine("Hello, World!");


//yeni bir ürün ekleyelim...

//ProductManager productManager = new ProductManager();
//var tumUrunler = productManager.GetAll();
//foreach (var item in tumUrunler)
//{
//    Console.WriteLine(item.Name + " " + item.Price);
//}
ProductManager productManager = new ProductManager();

//ProductModel productModel =  new ProductModel();
//productModel.Name = "Patates";
//productModel.Price = 24;

//productManager.Add(productModel);


//var urun = productManager.GetById(3);

//urun.Name = "Çedar Peyniri";
//urun.Price = 55;

//productManager.Update(urun);

//productManager.Delete(urun);


//productManager.Remove(urun);

//var urunler = productManager.Search(p => p.Price > 20);

//var urunler = productManager.GetAllWithIncludes("Brand");

var urunler2 = productManager.GetAllWithIncludes();
int r = 3;