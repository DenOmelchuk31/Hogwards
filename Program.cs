using System.Text;
using Microsoft.EntityFrameworkCore;
using HogwardsApp.Models;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

using var context = new HogwartsDbContext();

string house = "Грифіндор";

var gryffindorWizards = context.Wizards
    .FromSqlRaw("EXEC sp_GetWizardsByHouse @House = {0}", house)
    .ToList();

Console.WriteLine($"=== Чарівники факультету {house} (через sp_GetWizardsByHouse) ===");
foreach (var w in gryffindorWizards)
{
    Console.WriteLine($"{w.Name} — рік вступу: {w.Year}");
}


//var wizardWands = context.WizardWandViews.ToList();

//Console.WriteLine("=== Чарівники та їхні палички (vw_WizardWands) ===");
//foreach (var item in wizardWands)
//{
//    Console.WriteLine($"{item.WizardName} ({item.House}) — паличка: {item.WandMaterial}");
//}

//var context = new HogwartsDbContext();

//Console.WriteLine("===================================");

//var wizards = context.Wizards
//    .Include(w => w.Wand)
//    .ToList();

//foreach (var wizard in wizards)
//{
//    Console.WriteLine($"Wizard: {wizard.Name}, House: {wizard.House}, " +
//        $"Wand: {wizard.Wand?.CoreMaterial}");
//}

//Console.WriteLine("\n==================================");

//if (!context.Wizards.Any(w => w.Name == "Гаррі Поттер"))
//{
//    var newWizards = new List<Wizard>
//    {
//        new Wizard { Name = "Гаррі Поттер", House = "Грифіндор", Year = 1991 },
//        new Wizard { Name = "Герміона Ґрейнджер", House = "Грифіндор", Year = 1991 },
//        new Wizard { Name = "Рон Візлі", House = "Грифіндор", Year = 1991 },
//        new Wizard { Name = "Драко Мелфой", House = "Слизерин", Year = 1991 },
//        new Wizard { Name = "Луна Лавґуд", House = "Рейвенклов", Year = 1992 }
//    };

//    context.Wizards.AddRange(newWizards);
//    context.SaveChanges();

//    foreach (var wizard in newWizards)
//    {
//        Console.WriteLine($"- {wizard.Name}, {wizard.House}, {wizard.Year}");
//    }
//}
//else
//{
//    Console.WriteLine("Чарівники вже додані раніше, пропускаємо.");
//}

//Console.WriteLine("\n================================");

//var gryffindorWizards = context.Wizards
//    .Where(w => w.House == "Грифіндор")
//    .ToList();

//foreach (var wizard in gryffindorWizards)
//{
//    Console.WriteLine($"- {wizard.Name}, рік вступу: {wizard.Year}");
//}

//var ron = context.Wizards.FirstOrDefault(w => w.Name == "Рон Візлі");
//if (ron != null)
//{
//    ron.Year = 1992;
//    context.SaveChanges();
//    Console.WriteLine($"\nОновлено: {ron.Name} тепер має рік вступу {ron.Year}");
//}