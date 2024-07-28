namespace Ice_Task_1__Linked_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("ST10040040", "Jada", "Computer Science");
            //stud[1] = "Charlene";
            //Console.WriteLine(stud[0]);
            //Console.WriteLine(stud[1]);
            //Console.WriteLine(stud[2]);
            stud["studentname"] = "Jada";
            Console.WriteLine("Student Number: " + stud["studentnumber"]);
            Console.WriteLine("Student Name: " + stud["studentname"]);
            Console.WriteLine("Student Course: " + stud["studentcourse"]);
        }
    }
}
