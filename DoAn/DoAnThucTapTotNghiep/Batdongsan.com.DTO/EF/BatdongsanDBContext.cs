using Batdongsan.com.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batdongsan.com.DTO.EF
{
    public class BatdongsanDBContext : DbContext
    {
        public BatdongsanDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
