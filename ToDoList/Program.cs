namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            List<string> toDoList = new List<string>();

            ToDoList MiniAppliacation = new ToDoList(toDoList);

            while (keepGoing)
            {
                Console.Write("Would you like to Add or Remove a List Item (A) or (R) enter 99 to end: ");
                string userAddOrRemove = Console.ReadLine();

                if (userAddOrRemove == "a" || userAddOrRemove == "A")
                {
                    MiniAppliacation.Add();
                    for (int i = 0; i < toDoList.Count; i++)
                    {

                        Console.WriteLine(i + 1 + ": " + toDoList[i]);

                    }

                }

                else if ((userAddOrRemove == "r" || userAddOrRemove == "R") && toDoList.Count > 0)
                {
                    MiniAppliacation.Remove();
                    for (int i = 0; i < toDoList.Count; i++)
                    {

                        Console.WriteLine(i + 1 + ": " + toDoList[i]);
                    }
                }
                else if (userAddOrRemove == "99")
                {
                    keepGoing = false;
                }

            }
            Console.WriteLine();
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine(i + 1 + ": " + toDoList[i]);
            }

        }
    }
}