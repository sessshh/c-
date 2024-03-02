using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public System.DateTime btday;
        string name;
        public string lastName;

        public void SetName(string newName)
        {
            //проверка
            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("error!");
            }
            else { 
                name = newName;
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}
