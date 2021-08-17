using System;

namespace IndexerExtensionsStructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nullable value types

            int? a = 10;
            a = null;

            //if (a == null)
            //{
            //    Console.WriteLine("Ana sehife");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} id-li element");
            //}

            bool? b = null;

            #endregion

            #region Enum

            //int weekDay = 2;
            //switch (weekDay)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        break;
            //}

            //WeekDay day = WeekDay.Tuesday;
            //switch (day)
            //{
            //    case WeekDay.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case WeekDay.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case WeekDay.Wednesday:
            //        break;
            //    case WeekDay.Thursday:
            //        break;
            //    case WeekDay.Friday:
            //        break;
            //    case WeekDay.Saturday:
            //        break;
            //    case WeekDay.Sunday:
            //        break;
            //    default:
            //        break;
            //}

            //int weekDay = 1;
            //switch (weekDay)
            //{
            //    case (int)WeekDay.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case (int)WeekDay.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case (int)WeekDay.Wednesday:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        break;
            //}

            //Console.WriteLine((int)ErrorStatus.InternalError);

            //foreach (var item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Indexer

            //string word = "Salam";
            //Console.WriteLine(word[0]);

            //Book book1 = new Book("Sefiller", 150);
            //Book book2 = new Book("Ali & Nino", 100);

            //Library libraff = new Library("Libraff");
            //libraff[0] = book1;
            //libraff[1] = book2;
            //Console.WriteLine(libraff[101]);

            #endregion

            #region Struct - value type

            //int c = 10;
            //Area area1 = new Area(10, 20);
            //Console.WriteLine(area1.Length);
            //Console.WriteLine(area1.Width);
            //Area area2;
            //area2.Height = 10;
            //Console.WriteLine(area2.Height);

            #endregion

            #region Extensions

            //string word = "salam";
            //Console.WriteLine(word.IsFirstCharUpper());

            //double number = 3;
            //Console.WriteLine(number.GetPower(4));

            //int[] arr = { 5, 6, 3, 7, 8, 1, 2 };
            //int[] newArray = arr.AddElement(10);
            //foreach (int item in newArray)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Homework

            //int[] arr = Homework.ArraySort();
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Person[] result = Homework.ArraySort2();
            foreach (Person item in result)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }

    #region Homework

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static bool operator > (Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }

    #endregion

    #region Struct

    //value type-dir
    //parametrless constructor override etmek olmur
    //constructor-da mutleq property ve field-ler set olmalidir
    //inheritance almaq olmur

    interface ITest
    {

    }

    struct Area : ITest
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public int Height;

        public Area(int length, int width)
        {
            Length = length;
            Width = width;
            Height = 5;
        }
    }

    #endregion

    #region Indexer

    class Library
    {
        public string Name { get; set; }

        private Book[] _books;

        public Library(string name)
        {
            Name = name;
            _books = new Book[100];
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }
    }

    class Book
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + "-" + Price + " AZN";
        }
    }

    #endregion

    #region Enum

    enum WeekDay
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    #endregion
}
