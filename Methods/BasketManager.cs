using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        // Eğer () görüyorsan ve sonrasında {} geliyorsa bu bir METHOD'DUR.
        public void Add(Product product)  // Parantez İçi Parametre İlk yazılan Product Parametre Tipidir, product ise ürünün kendisidir yani adıdır.  
        {
            Console.WriteLine(" Congrats!! Added in the Basket : " + product.Name);
        }

        // AŞAĞISI HATALI KULLANIM 
        public void Add2(string name,string aciklama,double price) 
        {

            Console.WriteLine(" Congrats!! Added in the Basket : " + name);
        
        }
    }
}
