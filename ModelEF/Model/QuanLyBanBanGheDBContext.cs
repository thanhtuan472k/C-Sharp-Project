using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ModelEF.Model
{
    public class QuanLyBanBanGheDBContext: DbContext
    {
        public QuanLyBanBanGheDBContext() : base("name=ChuoiKN") { }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Category> HangMucs { get; set; }
        public virtual DbSet<Product> SanPhams { get; set; }

        public object Links { get; set; }
    }
}
