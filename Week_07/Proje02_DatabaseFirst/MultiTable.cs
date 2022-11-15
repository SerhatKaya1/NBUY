using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_DatabaseFirst.efcore;

namespace Proje02_DatabaseFirst
{
    public class MultiTable
    {
        class CustomerModel
        {
            public string? CustomerId { get; set; }
            public string? CompanyName { get; set; }
            public string? ContactName { get; set; }
            public string? City { get; set; }
            public int OrderCount { get; set; }
            public List<Order> Orders { get; set; }
        }

        class OrderModel
        {
            public int OrderId {get; set;}
            public  DateTime ShipDate {get; set; }
            public decimal Freign {get; set;}
        }

        //Müşteri Sayısı
        public void MusteriSayisi()
        {
            var context = new NorthwindContext();
            var result = context.Customers.Count();
           System.Console.WriteLine($"{result}");
        }

        //Satış Yapılan Müşteri Listesi
        public void SatisYapilanMusteriler()
        {
            //gelen listede customere ait company name contact name ve city listele
            var context = new NorthwindContext();
            var Customers = context
            .Customers
            .Where(c => c.Orders.Count() > 0)
            .Select(c=> new CustomerModel
            {
                CustomerId = c.CustomerId,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
            } )
            .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName}  -> {c.ContactName} -> {c.City} -> {c.CustomerId}");
            }
            System.Console.WriteLine($"Satış Yapılan Müşteri Sayısı : {customers.Count()}");
        }

        //Satış Yapılmayan Müşterileri listeleyiniz
    public void SatisYapilmayanMusteriler()
     {         
            var context = new NorthwindContext();
            var Customers = context
            .Customers
            .Where(c => c.Orders.Count() > 0)
            .Select(c=> new CustomerModel
            {
                CustomerId = c.CustomerId,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
            } )
            .ToList();
            foreach (var c in customers)
            {
                System.Console.WriteLine($"{c.CompanyName}  -> {c.ContactName} -> {c.City} -> {c.CustomerId}");
            }
            System.Console.WriteLine($"Satış Yapılmayan Müşteri Satısı : {customers.Count()}");
        }
















        





















        

    }
   
    
    
    
}
