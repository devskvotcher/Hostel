using Hostel.DataModel;
using System;
using System.Data.Entity;
using System.Linq;


namespace Hostels.DataModel
{
    public class HostelContext : DbContext
    {
        // Контекст настроен для использования строки подключения "Hostel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Hostel.DataModel.Hostel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Hostel" 
        // в файле конфигурации приложения.
        public HostelContext()
            : base("name=Hostel")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         //  modelBuilder.Entity<Booking>()
         //      .HasKey(p => p.Id);
         //
         //  modelBuilder.Entity<Client>()
         //      .HasMany(p => p.Bookings)
         //      .WithRequired(p => p.Client);
         //
         //
         //  modelBuilder.Entity<Room>()
         //      .HasMany(p => p.Bookings)
         //      .WithRequired(p => p.Room);
         //
         //
         //
         //  modelBuilder.Entity<Room>()
         //       .HasMany(t => t.Bookings)
         //       .WithRequired(t => t.Room);
            
            
                 
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}