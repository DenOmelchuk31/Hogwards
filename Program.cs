
//using HogwardsApp.Models;
//using System.Text;

//namespace HogwardsApp
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;
//            var context = new HogwartsDbContext();
//            var activeWizard = context.ActiveWizards
//                 .OrderBy(w => w.Name)
//                 .Select(w => w.Name)
//                 .ToList();

//            Console.WriteLine("Active Wizards:");
//            foreach (var wizard in activeWizard)
//            {
//                Console.WriteLine($"- {wizard}");
//            }

//        }
//    }
//}

