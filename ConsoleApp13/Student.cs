using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GroupNum { get; set; }
        public double Mark { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}  номер группы: {GroupNum} средняя оценка: {GroupNum}");
        }
    }
}
