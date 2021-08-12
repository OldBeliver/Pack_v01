using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pack_v01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseTeam =
             {
                "Бабаев", "Бабенин", "Бабкин", "Багров", "Бадьянов", "Бакулин", "Балакаев",
                "Жаворонков", "Жданов", "Жарков", "Жуковец", "Милованов", "Милютин", "Мизинов"
             };

            string[] vacctinationTeam =
            {
                "Баев", "Бялко", "Быстрых"
            };

            Console.WriteLine($"Отряд! На перекличку становись!");

            Console.WriteLine($"\nнажмите ENTER для начала переклички\n");
            Console.ReadKey();
            
            ShowInfo(baseTeam);
            
            Console.WriteLine($"нажмите ENTER для продолжения");
            Console.ReadKey();

            Console.WriteLine($"\nОтряд, слушай приказ командира полка!\nБойцы, чья фамилия начинается на букву \"Б\" выйти из строя");
            IEnumerable<string> firstLetter = baseTeam.Where(soldier => soldier.ToUpper().StartsWith("Б"));

            Console.WriteLine($"\nнажмите ENTER для продолжения\n");
            Console.ReadKey();
            
            ShowInfo(firstLetter.ToArray());
            
            Console.WriteLine($"\nнажмите ENTER для продолжения");
            Console.ReadKey();

            Console.WriteLine($"\nВы переходите в состав группы Бэ из {vacctinationTeam.Length} человек");

            vacctinationTeam = vacctinationTeam.Union(firstLetter).ToArray();

            Console.WriteLine($"\nГруппа Бэ, на вакцинацию шагом марш!");
            
            ShowInfo(vacctinationTeam);
            
            Console.WriteLine($"\nнажмите ENTER, чтобы повернуться к оставшимся бойцам");
            Console.ReadKey();
            Console.WriteLine($"\nОстальным: ");
            var rest = baseTeam.Except(firstLetter.ToArray());
            baseTeam = rest.ToArray();
            
            ShowInfo(baseTeam);
            Console.WriteLine($"Вольно! Разойтись!");
        }

        static void ShowInfo(string[] surnames)
        {
            for (int i = 0; i < surnames.Length; i++)
            {
                Console.WriteLine($"{i+1:d2}. Рядовой {surnames[i]}");
            }
        }
    }
}
