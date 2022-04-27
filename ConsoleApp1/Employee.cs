using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {  
        public Employee(string name, string surname, double price, int days)
        {
            Name = name;
            Surname = surname;
            Price = price;
            Days = days;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public double Price { get; set; }

        public int Days { get; set; }

        private string js { set; get; }

        public void Print()
        {
            Console.Write("Зарплата " + this.Name + " " + this.Surname + " становить - " + this.Salary + " грн");
            Console.WriteLine();
        }
        public double Salary
        {
            get
            {
                return Price * Days;
            }
        }
        public void FileToJson()
        {
            js = JsonConvert.SerializeObject(this);
            var pathout = Path.Combine(Environment.CurrentDirectory, "FileToJson.json");
            File.AppendAllText(pathout, js);
            Console.WriteLine("\nДанi " + this.GetType() + " скопiйованi у файл FileToJson.json"); 
        }
        public void FileFromJson()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "FileFromJson.json");
            var json2 = File.ReadAllText(path);
            Employee employee4 = JsonConvert.DeserializeObject<Employee>(json2);
            Console.WriteLine($"Працiвник з файлу FileFromJson.json:  ");
            employee4.Print();
        }
        ~Employee() { }
    }
}

