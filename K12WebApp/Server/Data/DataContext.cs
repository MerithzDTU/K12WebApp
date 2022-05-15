using System.Collections.Generic;
namespace K12WebApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Grocery> Groceries { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<ChoreMonth> ChoreMonths { get; set; }
        public DbSet<UserChore> UserChores { get; set; }

        public List<int> allChoreIds = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasAlternateKey(t => t.RoomNo);
            //modelBuilder.Entity<ChoreMonth>().HasMany(c => c.AssignedUsers).WithMany(u => u.ChoreMonths);
            modelBuilder.Entity<UserChore>().HasKey(cmu => new { cmu.AssignedRoomNo, cmu.ChoreMonthId });

            modelBuilder.Entity<UserChore>()
                .HasOne<User>(cmu => cmu.AssignedUser)
                .WithMany(cm => cm.UserChores)
                .HasForeignKey(cmu => cmu.AssignedRoomNo)
                .HasPrincipalKey(u => u.RoomNo);

            modelBuilder.Entity<UserChore>()
                .HasOne<ChoreMonth>(cmu => cmu.ChoreMonth)
                .WithMany(cm => cm.UserChores)
                .HasForeignKey(cm => cm.ChoreMonthId);


            List<Chore> allChores = new List<Chore>() {
                new Chore { Id = 1, Name = "Tjanse-tjekker", Description = "" },
                new Chore { Id = 2, Name = "Affalds-sortering", Description = "" },
                new Chore { Id = 3, Name = "Krydderihylde, emhætter og skuffer", Description = "" },
                new Chore { Id = 4, Name = "Ovn/komfur ved dør", Description = "" },
                new Chore { Id = 5, Name = "Altan og pant", Description = "" },
                new Chore { Id = 6, Name = "Alm. og grønskraldespand", Description = "" },
                new Chore { Id = 7, Name = "Ovn/komfur ved stuen", Description = "" },
                new Chore { Id = 8, Name = "Rydde op, tørre af og støvsuge", Description = "" },
                new Chore { Id = 9, Name = "Buffer", Description = "" }
                };
            List<ChoreMonth> allChoreMonths = new List<ChoreMonth>();

            modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Admin" },
            new Role { Id = 2, Name = "Køkken Ansvarlig" },
            new Role { Id = 3, Name = "Køkken Beboer" },
            new Role { Id = 4, Name = "Tjanse Tjekker" },
            new Role { Id = 5, Name = "Køkken Kasserer" }
                );

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, RoomNo = 1350, FirstName = "Christian", LastName = "Merithz Uhrenfeldt Nielsen", NickName = "Krølle", RoleId = 1 },
            new User { Id = 2, RoomNo = 1340, FirstName = "Joey", LastName = "Knutsson", NickName = "Joey", RoleId = 2 },
            new User { Id = 3, RoomNo = 1347, FirstName = "Emma", LastName = "Rosa", NickName = "Ems", RoleId = 3 },
            new User { Id = 4, RoomNo = 1345, FirstName = "Kasper", LastName = "Djælund Nyberg", NickName = "Guffe", RoleId = 3 },
            new User { Id = 5, RoomNo = 1344, FirstName = "Daniel", LastName = "Katz", NickName = "Danniboi", RoleId = 3 },
            new User { Id = 6, RoomNo = 1349, FirstName = "Andreas", LastName = "Ven", NickName = "Venno", RoleId = 3 },
            new User { Id = 7, RoomNo = 1351, FirstName = "Lynge", LastName = "Moustgaard", NickName = "LyngLyng", RoleId = 3 },
            new User { Id = 8, RoomNo = 1343, FirstName = "Lucas", LastName = "Zacho", NickName = "Peter", RoleId = 3 },
            new User { Id = 9, RoomNo = 1348, FirstName = "Nicolai", LastName = "Toft", NickName = "Nico", RoleId = 3 },
            new User { Id = 10, RoomNo = 1346, FirstName = "Anastasia", LastName = "Jakobsen", NickName = "Anastasia", RoleId = 3 },
            new User { Id = 11, RoomNo = 1341, FirstName = "Eva", LastName = "Sand Larsen", NickName = "Eva", RoleId = 5 },
            new User { Id = 12, RoomNo = 1353, FirstName = "Ahmad", LastName ="Mazrah", NickName = "Ahmad", RoleId = 3}
            );

            modelBuilder.Entity<Grocery>().HasData(
                new Grocery { Id = 1, DateCreated = DateTime.Now, GroceryName = "Løg", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 2, DateCreated = DateTime.Now, GroceryName = "Hvidløg", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 3, DateCreated = DateTime.Now, GroceryName = "Affaldsposer", isBought = false, CreatedByUserId = 1 },
                new Grocery { Id = 4, DateCreated = DateTime.Now, GroceryName = "Karry", isBought = false, CreatedByUserId = 1 }
                );

            int i = 0;

            foreach (Chore chore in allChores)
            {
                int choreId = chore.Id;

                allChoreMonths.AddRange(new List<ChoreMonth> {
                    new ChoreMonth { Id = i + 1, ChoreId = choreId, Name = "januar" },
                    new ChoreMonth { Id = i + 2, ChoreId = choreId, Name = "februar" },
                    new ChoreMonth { Id = i + 3, ChoreId = choreId, Name = "marts" },
                    new ChoreMonth { Id = i + 4, ChoreId = choreId, Name = "april" },
                    new ChoreMonth { Id = i + 5, ChoreId = choreId, Name = "maj" },
                    new ChoreMonth { Id = i + 6, ChoreId = choreId, Name = "juni" },
                    new ChoreMonth { Id = i + 7, ChoreId = choreId, Name = "juli" },
                    new ChoreMonth { Id = i + 8, ChoreId = choreId, Name = "august" },
                    new ChoreMonth { Id = i + 9, ChoreId = choreId, Name = "september" },
                    new ChoreMonth { Id = i + 10, ChoreId = choreId, Name = "october" },
                    new ChoreMonth { Id = i + 11, ChoreId = choreId, Name = "november" },
                    new ChoreMonth { Id = i + 12, ChoreId = choreId, Name = "december" },
                });
                i += 12;
            }

            modelBuilder.Entity<ChoreMonth>().HasData(
                    allChoreMonths
                );


            modelBuilder.Entity<Chore>().HasData(
                    allChores
                );

            modelBuilder.Entity<UserChore>().HasData(
                new UserChore { AssignedRoomNo = 1349, ChoreMonthId = 2 },
                new UserChore { AssignedRoomNo = 1350, ChoreMonthId = 14 },
                new UserChore { AssignedRoomNo = 1351, ChoreMonthId = 14 },
                new UserChore { AssignedRoomNo = 1353, ChoreMonthId = 3 },
                new UserChore { AssignedRoomNo = 1343, ChoreMonthId = 4 },
                new UserChore { AssignedRoomNo = 1353, ChoreMonthId = 26 },
                new UserChore { AssignedRoomNo = 1340, ChoreMonthId = 38 },
                new UserChore { AssignedRoomNo = 1341, ChoreMonthId = 50 },
                new UserChore { AssignedRoomNo = 1343, ChoreMonthId = 62 },
                new UserChore { AssignedRoomNo = 1344, ChoreMonthId = 74 },
                new UserChore { AssignedRoomNo = 1345, ChoreMonthId = 86 },
                new UserChore { AssignedRoomNo = 1346, ChoreMonthId = 98 }
                );
        }
    }
}