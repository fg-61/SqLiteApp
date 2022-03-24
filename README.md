## SqLiteApp
SqLite user tablosu oluşturuldu

### SqLite kullanmak için aşağıdaki NuGet'lar eklendi;
1. Microsoft.EntityFrameworkCore.Sqlite
2. Microsoft.EntityFrameworkCore.Tools

### Database Görmek İçin
https://sqlitebrowser.org/dl/ linkinden SqLite Browser indir

### Data Bağlantısı

    public class MyContext : DbContext  // DbContext kalıtım
    {
        public DbSet<UserModel> Users { get; set; } // Oluşturacağın Tablo
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\SqLiteDb\User.db");  // Kayıt Noktası
    }
