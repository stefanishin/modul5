using System;
using ConsoleAppTask1;
    /*
Задание 1.
    Разработайте приложение «7 чудес света», где каждое чудо будет представлено отдельным классом. 
    Создайте дополнительный класс, содержащий точку входа. 
    Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность взаимодействия классов.
*/
namespace ConsoleAppTask1
{
    class Program
    {

        static void Main(string[] args)
        {
              
            Pyramid_of_Cheops.ShowWonder();
            Hanging_Gardens_of_Babylon.ShowWonder();
            Temple_of_Artemis_at_Ephesus.ShowWonder();
            Zeus_statue_in_Olympia.ShowWonder();
            Mausoleum_at_Halicarnassus.ShowWonder();
            Colossus_of_Rhodes.ShowWonder();
            Lighthouse_of_Alexandria.ShowWonder();

            Console.ReadKey();

        }
    }
    
}
/*

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Wonders wonder = new Wonders();
            wonder.ShowAll();
        }
    }
    //Разработайте приложение «7 чудес света», где каждое чудо будет 
    //представлено отдельным классом.Создайте дополнительный класс, содержащий 
    //точку входа.Распределите приложение по файлам проекта и с помощью 
    //пространства имён обеспечьте возможность взаимодействия классов.
    public abstract class Miracle
    {
        public string Name { get; set; }
        public Miracle (string name)
        {
            Name = name;
        }
    }
    public class PyramidOfCheops: Miracle
    {
        public PyramidOfCheops() : base("Пирамида Хеопса") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class HangingGardensOfBabylon : Miracle
    {
        public HangingGardensOfBabylon() : base("Висячие сады Семирамиды") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class StatueOfZeusAtOlympia : Miracle
    {
        public StatueOfZeusAtOlympia() : base("Статуя Зевса в Олимпии") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class TempleOfArtemisOfEphesus : Miracle
    {
        public TempleOfArtemisOfEphesus() : base("Храм Артемиды Эфесской") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class MausoleumAtHalicarnassus : Miracle
    {
        public MausoleumAtHalicarnassus() : base("Мавзолей в Галикарнасе") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class ColossusOfRhodes : Miracle
    {
        public ColossusOfRhodes() : base("Колосс Родосский") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class LighthouseOfAlexandria : Miracle
    {
        public LighthouseOfAlexandria() : base("Александрийский маяк") { }
        public override string ToString()
        {
            return $"Чудо света \"{Name}\"";
        }
    }
    public class Wonders
    {
        private Miracle[] miracles;
        public Wonders()
        {
            miracles = new Miracle[] { new PyramidOfCheops(), 
                                       new HangingGardensOfBabylon(), 
                                       new StatueOfZeusAtOlympia(), 
                                       new TempleOfArtemisOfEphesus(), 
                                       new MausoleumAtHalicarnassus(), 
                                       new ColossusOfRhodes(), 
                                       new LighthouseOfAlexandria() };
        }
        public void ShowAll()
        {
            foreach (Miracle item in miracles)
            {
                Console.WriteLine(item);
            }
        }
    }
}

 */
