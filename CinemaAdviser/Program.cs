// Программа для подбора фильма

namespace CinemaAdviser
{
    class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет вам подобрать фильм для вечернего просмотра");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, боевик или триллер ?");
            String genre = Console.ReadLine();

            
            if (genre == "комедия")
            {
                Console.WriteLine("какой фильм вам бы сейчас хотелось посмотреть больше: оттечественный или зарубежный?");
                String country = Console.ReadLine();
                if (country =="отечественный")
                {     
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                    Console.WriteLine("* Иван Васильевич меняет профессию");
                    Console.WriteLine("* Операция «Ы» и другие приключения Шурика");
                    Console.WriteLine("* Ёлки");
                    Console.WriteLine("* Ёлки 2");
                }
                else 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                    Console.WriteLine("* Назад в будущее");
            }
            else if (genre == "фантастика")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                Console.WriteLine("* Люди икс");
                Console.WriteLine("* Черепашки ниндзя");
                Console.WriteLine("* Звездные войны");
            }
            else if (genre == "боевик")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                Console.WriteLine("* Терминатор 2");
                Console.WriteLine("* Призрачная шестёрка");
                Console.WriteLine("* Миссия не выполнима");

            }
            else if (genre == "триллер")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                Console.WriteLine("* Джокер");
                Console.WriteLine("* Молчание ягнят");
                Console.WriteLine("* Семь");
            }    
            else     
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы: ");
                Console.WriteLine("* Зелёная миля");
                Console.WriteLine("* Побег из Шоушенка");
                Console.WriteLine("* Пианист");
                Console.WriteLine("* Книжный вор");
                Console.WriteLine("* Остров");
            }
            Console.ReadLine();
        }
    }
}