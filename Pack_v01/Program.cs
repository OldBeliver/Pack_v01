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
            for (int i = 0; i < baseTeam.Length; i++)
            {
                Console.WriteLine($"{i+1:d2}. Рядовой {baseTeam[i]}");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"\nОтряд, слушай приказ командира полка!\nБойцы, чья фамилия начинается на букву \"Б\" выйти из строя\n");
            IEnumerable<string> firstLetter = baseTeam.Where(soldier => soldier.ToUpper().StartsWith("Б"));

            foreach (string soldier in firstLetter)
            {
                Console.WriteLine($"{soldier}");
            }

            Console.WriteLine($"\nВы переходите в состав группы Бэ из {vacctinationTeam.Length} человек");

            vacctinationTeam = vacctinationTeam.Union(firstLetter).ToArray();

            Console.WriteLine($"\nГруппа Бэ, на вакцинацию шагом марш!");
            for (int i = 0; i < vacctinationTeam.Length; i++)
            {
                Console.WriteLine($"{i + 1:d2}. Рядовой {vacctinationTeam[i]}");                
            }

            Console.WriteLine($"\nнажмите ENTER, чтобы повернуться к оставшимся бойцам");
            Console.ReadKey();
            Console.WriteLine($"\nОстальным: ");
            var rest = baseTeam.Except(firstLetter.ToArray());
            foreach (string soldier in rest)
            {
                Console.WriteLine($"{soldier}");
            }
            Console.WriteLine($"Вольно! Разойтись!");
        }
    }
}
