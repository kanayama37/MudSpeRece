namespace MudSpeRece.Server.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reception>().HasData(
                new Reception
                {
                    Id = 1,
                    Userid = 3,
                    RecDate = DateTime.Now,
                    RegName = "タイガー",
                    RecName = "金山昌弘",
                    CusName = "得意先商事",
                    Body = "いい仕事してますね",
                    Containa = "2M",
                    WorkDivisionId =   1,
                    Checkbox    =   0,
                    Checkbox1   =   0,
                    Checkbox2   =   0,
                    Checkbox3   =   0,
                    CreatedAt   = DateTime.Now,
                    UpdatedAt   = DateTime.Now
                },
                new Reception
                {
                    Id = 2,
                    Userid = 4,
                    RecDate = DateTime.Now,
                    RegName = "タイガー2",
                    RecName = "金山昌弘2",
                    CusName = "得意先商事2",
                    Body = "いい仕事してますね2",
                    Containa = "3M",
                    WorkDivisionId = 2,
                    Checkbox = 0,
                    Checkbox1 = 0,
                    Checkbox2 = 0,
                    Checkbox3 = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }

        public DbSet<Reception> Receptions { get; set; }

        // public DbSet<WorkDivision> WorkDivisions { get; set; }

    }
}
