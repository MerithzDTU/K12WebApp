
namespace K12WebApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Admin" },
            new Role { Id = 2, Name = "Køkken Ansvarlig" },
            new Role { Id = 3, Name = "Køkken Beboer" },
            new Role { Id = 4, Name = "Tjanse Tjekker" },
            new Role { Id = 5, Name = "Køkken Kasserer" }
                );

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "Christian", LastName = "Merithz Uhrenfeldt Nielsen", NickName = "Krølle", RoleId = 1 },
            new User { Id = 2, FirstName = "Joey", LastName = "Knutsson", NickName = "Joey", RoleId = 2 },
            new User { Id = 3, FirstName = "Emma", LastName = "Rosa", NickName = "Ems", RoleId = 3 },
            new User { Id = 4, FirstName = "Kasper", LastName = "Djælund Nyberg", NickName = "Guffe", RoleId = 3 },
            new User { Id = 5, FirstName = "Daniel", LastName = "Katz", NickName = "Danniboi", RoleId = 3 },
            new User { Id = 6, FirstName = "Andreas", LastName = "Ven", NickName = "Venno", RoleId = 3 },
            new User { Id = 7, FirstName = "Lynge", LastName = "Moustgaard", NickName = "LyngLyng", RoleId = 3 },
            new User { Id = 8, FirstName = "Lucas", LastName = "Zacho", NickName = "Peter", RoleId = 3 },
            new User { Id = 9, FirstName = "Nicolai", LastName = "Toft", NickName = "Nico", RoleId = 3 },
            new User { Id = 10, FirstName = "Anastasia", LastName = "Jakobsen", NickName = "Anastasia", RoleId = 3 },
            new User { Id = 11, FirstName = "Eva", LastName = "Sand Larsen", NickName = "Eva", RoleId = 5 }
            );

            modelBuilder.Entity<Grocery>().HasData(
                new Grocery { Id = 1, DateCreated = DateTime.Now, GroceryName = "Løg", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 2, DateCreated = DateTime.Now, GroceryName = "Hvidløg", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 3, DateCreated = DateTime.Now, GroceryName = "Affaldsposer", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 4, DateCreated = DateTime.Now, GroceryName = "Karry", isBought = false, CreatedByUserId = 1 }
                );

            modelBuilder.Entity<ChoreMonth>().HasData(
                new ChoreMonth { Id = 1, Name = "Januar" },
                new ChoreMonth { Id = 2, Name = "Februar" },
                new ChoreMonth { Id = 3, Name = "Marts" },
                new ChoreMonth { Id = 4, Name = "April" },
                new ChoreMonth { Id = 5, Name = "Maj" },
                new ChoreMonth { Id = 6, Name = "Juni" },
                new ChoreMonth { Id = 7, Name = "Juli" },
                new ChoreMonth { Id = 8, Name = "August" },
                new ChoreMonth { Id = 9, Name = "September" },
                new ChoreMonth { Id = 10, Name = "October" },
                new ChoreMonth { Id = 11, Name = "November" },
                new ChoreMonth { Id = 12, Name = "December" }
                );

            //modelBuilder.Entity<Chore>().HasData(
            //    new Chore { Id = 1, Name = "Tjanse-tjekker", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 2, Name = "Affalds-sortering", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 3, Name = "Krydderihylde, emhætter og skuffer", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 4, Name = "Ovn/komfur ved dør", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 5, Name = "Altan og pant", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 6, Name = "Alm. og grønskraldespand", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 7, Name = "Ovn/komfur ved stuen", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 8, Name = "Rydde op, tørre af og støvsuge", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } },
            //    new Chore { Id = 9, Name = "Buffer", Description = "", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 } }
            //    );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Grocery> Groceries { get; set; }


    }
}