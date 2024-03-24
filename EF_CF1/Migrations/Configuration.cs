namespace EF_CF1.Migrations
{
    using EF_CF1.models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_CF1.models.StudentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EF_CF1.models.StudentDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Trainer t1 = new Trainer() { Name = "vikul", City = "pune", Experience = 14 };
            context.trainers.Add(t1);

            Studnet t2 = new Studnet() { Name = "NAJIM" ,City = "DHULE" ,Email = "NAJIM@123" };
            context.students.Add(t2);
        }
    }
}
