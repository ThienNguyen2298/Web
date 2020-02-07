namespace Web.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Models.WebDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web.Models.WebDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<Subject> defaultSubjects = new List<Subject>();

            defaultSubjects.Add(new Subject() { name = "Toán"});
            defaultSubjects.Add(new Subject() { name = "Lý" });
            defaultSubjects.Add(new Subject() { name = "Hóa" });
            defaultSubjects.Add(new Subject() { name = "Tiếng Anh" });
            defaultSubjects.Add(new Subject() { name = "Ngữ Văn" });


            context.Subjects.AddRange(defaultSubjects);

            base.Seed(context);
        }
    }
}
