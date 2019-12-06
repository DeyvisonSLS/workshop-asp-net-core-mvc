using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> SellersList { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name, ICollection<Seller> selersList)
        {
            Id = id;
            Name = name;
            //SellersList = null;
        }

        public void AddSeller(Seller seller)
        {
            SellersList.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return SellersList.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}