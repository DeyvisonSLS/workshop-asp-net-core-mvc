using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> SalesRecordList { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
            //SalesRecordList = null;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            SalesRecordList.Add(salesRecord);
        }
        public void RemoveSales(SalesRecord salesRecord)
        {
            SalesRecordList.Remove(salesRecord);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecordList.Where(p => p.Date <= initial && p.Date >= final).Sum(p => p.Amount);
        } 
    }
}
