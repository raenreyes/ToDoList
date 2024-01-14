using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoList
    {
        public List<string> ListOfThings { get; set; }

        public ToDoList(List<string> list)
        {
            this.ListOfThings = list;
        }
        public List<string> Add()
        {
            Console.Write($"Add a Todo: ");
            string userToDo = Console.ReadLine();
            ListOfThings.Add(userToDo);

            return ListOfThings;
        }
        public List<string> Remove()
        {
            Console.Write($"Remove which Todo is already completed: ");
            string remove = Console.ReadLine();
            int number = int.Parse(remove);
            ListOfThings.RemoveAt(number - 1);

            return ListOfThings;
        }
    }
}
