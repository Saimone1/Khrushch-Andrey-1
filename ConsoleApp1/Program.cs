using System;
using Newtonsoft.Json;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Андрiй", "Андрiєнко", 600, 20);
            Employee employee2 = new Employee("Iван", "Iваненко", 355, 14);
            Employee employee3 = new Employee("Степан", "Степаненко", 200, 18);

            employee1.Print();

            employee1.FileToJson();

            employee2.FileToJson();

            employee3.FileToJson();

            employee1.FileFromJson();
        }
    }   
}
