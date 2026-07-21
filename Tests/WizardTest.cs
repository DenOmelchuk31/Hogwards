using HogwardsApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HogwardsApp.Test
{
    public class WizardTest
    {
        [Fact]
        public void AddingWizardWithDuplicateName_ThrowsDbUpdateException()
        {
            using var context = new HogwartsDbContext();

            var wizard1 = new Wizard
            {
                Name = "Невіл Довгопупс",
                House = "Грифіндор",
                Year = 1991
            };

            var wizard2 = new Wizard
            {
                Name = "Невіл Довгопупс",
                House = "Слизерин",
                Year = 1992
            };

            context.Wizards.Add(wizard1);
            context.SaveChanges();

            context.Wizards.Add(wizard2);

            Assert.Throws<DbUpdateException>(() => context.SaveChanges());

            context.Wizards.Remove(wizard1);
            context.SaveChanges();
        }


        //[Fact]
        //public void GetRWizards_ShouldReturnOnlyRStudents()
        //{
        //    var options = new DbContextOptionsBuilder<HogwartsDbContext>()
        //        .UseInMemoryDatabase(databaseName: "TestDatabase")
        //        .Options;

        //    using (var context = new HogwartsDbContext(options))
        //    {
        //        context.Wizards.AddRange
        //            (
        //                new Wizard { WizardId = 1, Name = "Harry Potter", House = "Gryffindor", BloodStatus = "sime" },
        //                new Wizard { WizardId = 2, Name = "Ron Weasley", House = "Gryffindor", BloodStatus = "clear" },
        //                new Wizard { WizardId = 3, Name = "Hermione Grenger", House = "Rawenclaw", BloodStatus = "clear" }
        //            );
        //        context.SaveChanges();
        //    }

        //    using (var context = new HogwartsDbContext(options))
        //    {
        //        var rStudents = context.Wizards
        //            .Where(w => w.House == "Rawenclaw")
        //            .ToList();

        //        var singleStudent = Assert.Single(rStudents);
        //        Assert.Equal("Hermione Grenger", rStudents[0].Name);
        //        Assert.Equal(1, rStudents.Count);
        //    }
        //}
    }
}
