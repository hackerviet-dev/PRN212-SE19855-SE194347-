using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() {
            Products = new Dictionary<int, Product>();
        }
        /* Moi du lieu can lam du CRUD
         * 
         */
        public void AddProduct(Product p) {
             if (Products.ContainsKey(p.Id))
            {
                return;
            }
              Products.Add(p.Id, p);
             }
        // xem toan bo pro duct cua danh muc
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }
        //loc ra cac san pham co gia tu x toi y
        public Dictionary<int, Product> FilterProductsByPrice(double min, double max)
        {
            Dictionary<int, Product>results = new Dictionary<int, Product>();
            results = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
            return results;
        }
        //sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }
        //
        public Dictionary<int, Product> ComplexSort()
        {
            return Products.OrderByDescending(item => item.Value.Quantity).OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        public bool UpdateProduct(Product p)
        {
            if (p == null) return false;
            if(Products.ContainsKey(p.Id)==false) 
                return false;
            Products[p.Id] = p; // de du lieu len o nho hien tai
            return true;
        }
        public bool DeleteProduct(int id)
        {
            if(Products.ContainsKey(id)==false) return false;
            return Products.Remove(id);
        }
    }
}
