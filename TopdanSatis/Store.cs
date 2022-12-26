using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TopdanSatis
{
    internal class Store 
    {
        Product[] arrProducts;


        public Store()
        {
            arrProducts = new Product[0];
        }
        public void AddProduct()
        {
            string namem = Console.ReadLine();
            double pricem = Convert.ToDouble(Console.ReadLine());
            Products type;
            //
            geridon:
            string typestr= Console.ReadLine().ToLower();
            
            switch (typestr)
            {
                case "meat":
                    type = Products.Meat;
                    break;
                case "drink":
                    type = Products.Drink;
                        break;
                case "baker":
                    type = Products.Baker;
                    break;
                default:
                    Console.WriteLine("Uygun simvol daxil edin");
                    goto geridon;
                    //
                    break;
            }

            Product product = new Product(namem, pricem, type);
            Array.Resize(ref arrProducts, arrProducts.Length + 1);
            arrProducts[arrProducts.Length - 1] = product;
            Console.WriteLine("Elave Olundu");
            

        }

        public void FilterProductByName()
        {

            for (int i = 0; i < arrProducts.Length; i++)

            {
                

            }
        }


       

        public void FilterProductByType(Products type, string[] arrProducts)
        {
            int count = 0;
            Products products;
            string typestr = Console.ReadLine().ToLower();
            switch (typestr)
            {
                case "meat":
                    type = Products.Meat;
                    break;
                case "drink":
                    type = Products.Drink;
                    break;
                case "baker":
                    type = Products.Baker;
                    break;



                default:
                    break;
            }
            foreach (var item in arrProducts)
            {
                if (item.Type == type )             //hell ede bilmedim
                {
                    count++;
                    Console.WriteLine(count + " " + item);
                }

            }

          

        }

        public void RemoveProductByNo(int no, string[]arrProducts)
        {
            for (int i = no-1; i < arrProducts.Length; i++)
            {

            }
        }
    }
}
