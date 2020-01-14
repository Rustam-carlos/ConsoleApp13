using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        public static List<Student> students = new List<Student>();
        public static string name;
        public static int groupNum;
        public static double mark;
        public static double maxMark = 0.0;
        public static double minMark = 0.0;

        static void Main(string[] args)
        {
            AddStudent();
            //ShowStudents();
            do
            {
                Console.WriteLine("1 Ввод данных\n2 имя лучшего студента по успеваемости\n3 имя худшего студента по успеваемости\n4 Общаяя средняя оценка по группе\n5 Show \n6 выход");
                int i = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Ввод данных Запись студента в коллекцию");
                        Init();
                        break;
                    case 2:
                        Console.WriteLine("имя лучшего студента по успеваемости");
                        MaxMark();                        
                        break;
                    case 3:
                        Console.WriteLine("имя худшего студента по успеваемости");
                        MinMark();
                        break;
                    case 4:
                        Console.WriteLine("Общаяя средняя оценка по группе");
                        SMark();
                        break;
                    case 5:
                        Console.WriteLine("Show");
                        ShowStudents();
                        break;
                    case 6:
                        Console.WriteLine("выход");
                        Process.GetCurrentProcess().Kill();
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);

            Console.WriteLine("Hello World!");
        }
        private static void MaxMark()
        {
            var sortedUsers = students.OrderBy(u => u.Mark);
            string n = "xx";
            double m = 0.0;

            foreach (Student u in sortedUsers)
            {
                n = u.Name;
                m = u.Mark;
            }
            Console.WriteLine(n);
            Console.WriteLine(m);
        }

        private static void MinMark()
        {
            var sortedUsers = students.OrderByDescending(u => u.Mark);
            string n = "xx";
            double m = 0.0;

            foreach (Student u in sortedUsers)
            {
                n = u.Name;
                m = u.Mark;
            }
            Console.WriteLine(n);
            Console.WriteLine(m);
        }
        private static void SMark()
        {
            int count = 0;
            double sum = 0;
            foreach (Student u in students)
            {
                sum += u.Mark;
                count++;                
            }
            Console.WriteLine(sum/count);

        }

        private static void Write()
        {
            students.Add(new Student() { Name = name, GroupNum = groupNum, Mark = mark });
        }

        private static void ShowStudents()
        {
            foreach (Student p in students)
            {
                Console.WriteLine(p.Name, p.GroupNum, p.Mark);
            }
        }

        private static void AddStudent()
        {
            students.Add(new Student() { Name = "Федор Сумкин", GroupNum = 1, Mark = 4.5 });
            students.Add(new Student() { Name = "Пендальф Серый", GroupNum = 1, Mark = 4.7 });
            students.Add(new Student() { Name = "Сеня Ганжа", GroupNum = 1, Mark = 3.9 });
            students.Add(new Student() { Name = "Баралгин Гондурасский", GroupNum = 1, Mark = 3.5 });
        }

        private static void Init()
        {
            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();
            Console.Write("Введите номер группы: ");
            groupNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите среднюю оценку: ");
            mark = Convert.ToDouble(Console.ReadLine());
            Write();
            Console.Write("Ввод данных успешно завершен ");
            //Student student = new Student {Name = name, GroupNum = groupNum, Mark = mark };
        }
    }
}
