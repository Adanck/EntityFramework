//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAOClient
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {

        public Invoice()
        {

        }
        public Invoice(int number, int amount, decimal price, decimal sub_total, string code, int id)
        {
            this.Number = number;
            this.Amount = amount;
            this.Price = price;
            this.Sub_Total = sub_total;
            this.Code_Product = code;
            this.Id_Client = id;

        }
        public int Number { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Sub_Total { get; set; }
        public string Code_Product { get; set; }
        public int Id_Client { get; set; }
        public System.DateTime Date_Time { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
    }
}
