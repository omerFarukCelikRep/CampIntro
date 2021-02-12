﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class CartManager
    {
        //Naming Convention
        //Syntax

        //Void Methods => Değer Döndürmeyen Metotlar
        public void Add(Product product)
        {
            Console.WriteLine("Added");
        }

        //Metot kullanılırken parametre verilmediğinde default olarak değer girilmedi yazdıracak
        public void PrintToScreen(string str = "Değer Girilmedi")
        {
            Console.WriteLine(str);
        }

        //Method Overload
        public void Add(string productName, double price, string description)
        {

            Console.WriteLine("Added" + productName);
        }

        //Ürünlerimize indirim uygulayıp bu indirimi uygladıktan sonra fiyatlarını güncelliyoruz metot kullanarak
        public void MakeDiscount(ref Product product)
        {
            double discount = 0.25;
            //Eğer ürünün fiyatı 50'nin üzerindeyse %25 indirim uygulanacak
            if (product.Price > 50)
            {
                product.Price = product.Price * (1 - discount);
            }
            else
            {
                //DefaultDiscount metotunu kullanarak default discount tanımlamış olduk ve bu değişkeni else koşulumuzda kullandık
                DefaultDiscount(out double discountDefault);
                product.Price = product.Price * (1 - discountDefault);
            }
        }

        //Out parametresi kullanarak metot içerisinde tanımladığımız değeri discount parametresi metotun kullanıldığı yerde discount tanımlı olmasa bile tanımlamış olduk
        public double DefaultDiscount(out double discount)
        {
            discount = 0.10;
            return discount;
        }
    }
}
