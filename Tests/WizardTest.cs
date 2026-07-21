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
        public void GetRWizards_ShouldReturnOnlyRStudents()
        {
            var options = new DbContextOptionsBuilder<HogwartsDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new HogwartsDbContext(options))
            {
                context.Wizards.AddRange
                    (
                        new Wizard { WizardId = 1, Name = "Harry Potter", House = "Gryffindor", BloodStatus = "sime" },
                        new Wizard { WizardId = 2, Name = "Ron Weasley", House = "Gryffindor", BloodStatus = "clear" },
                        new Wizard { WizardId = 3, Name = "Hermione Grenger", House = "Rawenclaw", BloodStatus = "clear" }
                    );
                context.SaveChanges();
            }

            using (var context = new HogwartsDbContext(options))
            {
                var rStudents = context.Wizards
                    .Where(w => w.House == "Rawenclaw")
                    .ToList();

                var singleStudent = Assert.Single(rStudents);
                Assert.Equal("Hermione Grenger", rStudents[0].Name);
                Assert.Equal(1, rStudents.Count);
            }
        }
    }
}
