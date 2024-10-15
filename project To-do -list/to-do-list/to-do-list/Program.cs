//to-do-list
//add remove and view items from the list
Console.WriteLine("welcome to the to-do list program");
List<string> tasklist = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("what would you like to do?");
    Console.WriteLine("enter 1 to add a task to the list");
    Console.WriteLine("enter 2 to remove a task from the list");
    Console.WriteLine("enter 3 to view the list");
    Console.WriteLine("enter e to exit the program");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            {
                Console.WriteLine("please enter the name of the task to add to the list");
                string task = Console.ReadLine();
                tasklist.Add(task);
                Console.WriteLine("the task was sucessfully added to the list");
                break;
            }
        case "2":
            {
                for (int i = 0; i < tasklist.Count; i++)
                {
                    Console.WriteLine($"{i}:{tasklist[i]}");
                }
                Console.WriteLine("enter the number of the task you want to remove ");
                int tasknumber = Convert.ToInt32(Console.ReadLine());
                tasklist.RemoveAt(tasknumber);
                break;
            }
        case "3":
            {
                for (int i = 0; i < tasklist.Count; i++)
                {
                    Console.WriteLine(tasklist[i]);
                }
                break;
            }
        case "e":
            {
                Console.WriteLine("exeting program");
                Console.WriteLine("thank you for using it!!!");
                break;
                
            }
        default:
            {
                Console.WriteLine("Invalid option please try again");
                break;
            }
    }
}
