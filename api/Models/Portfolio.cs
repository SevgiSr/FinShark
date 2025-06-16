using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        // foreign key for AppUser
        public string AppUserId { get; set; }

        // foreign key for Stock
        public int StockId { get; set; }

        // -- navigation properties - 
        // this is just for the developer, you could technically just have ID' and do rrest with OnModelCreating
        // but we decided to have convention do some of it
        public AppUser AppUser { get; set; }
        public Stock Stock { get; set; }

    }
}