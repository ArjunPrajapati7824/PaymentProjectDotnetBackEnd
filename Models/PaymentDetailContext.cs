using Microsoft.EntityFrameworkCore;

namespace PaymentDetailsCrudWeb.Models
{
    public class PaymentDetailContext:DbContext

    {
        public PaymentDetailContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }


    }
} 
