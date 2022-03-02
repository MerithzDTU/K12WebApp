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
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }


    }
}
