using System;
using System.Collections.Generic;
using System.Linq;



namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
        public double BaeSalary { get; set; }

        public Departaments Departaments { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthdate, double baeSalary, Departaments departaments)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthdate = birthdate;
            BaeSalary = baeSalary;
            Departaments = departaments;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
