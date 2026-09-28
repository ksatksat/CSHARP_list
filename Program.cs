using System;
using System.Collections.Generic;

namespace ListExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>();
            
            // Adding elements to the list
            numbers.Add(1);//0
            numbers.Add(2);//1
            numbers.Add(3);//2
            numbers.Add(4);//3
            numbers.Add(5);//4
            /*
            // Displaying the list elements
            Console.WriteLine("List after adding elements:");
            DisplayList(numbers);
            */
            
            // Inserting an element at a specific index
            numbers.Insert(2, 99);
            Console.WriteLine("\nList after inserting 99 at index 2:");
            DisplayList(numbers);
            
            
            // Removing an element by value
            numbers.Remove(99);
            Console.WriteLine("\nList after removing the element 99:");
            DisplayList(numbers);

            
            // Removing an element by index
            numbers.RemoveAt(3);
            Console.WriteLine("\nList after removing the element at index 3:");
            DisplayList(numbers);
            
            // Checking if an element exists in the list
            bool containsThree = numbers.Contains(3);
            Console.WriteLine($"\nDoes the list contain the number 3? : {containsThree}");

            

            // Finding the index of an element
            int indexOfFour = numbers.IndexOf(4);
            Console.WriteLine($"\nThe index of the number 4 in the list: {indexOfFour}");

            int indexOfTwo = numbers.IndexOf(2);
            Console.WriteLine($"\nThe index of the number 2 in the list: {indexOfTwo}");
            
            numbers.Insert(0, 777);
            Console.WriteLine("\nList after inserting 777:");
            DisplayList(numbers);

            // Sorting the list
            numbers.Sort();
            Console.WriteLine("\nList after sorting:");
            DisplayList(numbers);
            
            // Reversing the list
            numbers.Reverse();
            Console.WriteLine("\nList after reversing:");
            DisplayList(numbers);
            
            // Getting the number of elements in the list
            int count = numbers.Count;
            Console.WriteLine($"\nNumber of elements in the list: {count}");
            
            // Clearing the list
            numbers.Clear();
            Console.WriteLine("\nList after clearing all elements:");
            DisplayList(numbers);
            
            // Ending the program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            /*Создать список работников на каком-то проекте - Ваня, Петя, Борис, Настя, Лена, Юля
            (инициализация списка - Add())
            уволить Бориса.(Remove(99) - RemoveAt(3)) Бакыта взяли на работу. (Insert(2, "Бакыт")) 
            Лена уволить. Дашу взять на работу. 
            Проверка работает ли Настя.(Contains(3)) проект закончился уволить всех (Clear())
            */
            Console.WriteLine("=============================================================");

            List<string> workers = new List<string>();

            workers.Add("Vania");//0
            workers.Add("Petia");//1
            workers.Add("Boris");//2
            workers.Add("Nastia");//3
            workers.Add("Lena");//4
            workers.Add("Yulia");//5

            DisplayWorkers(workers);

            workers.Remove("Boris");
            Console.WriteLine("Boris was fired");
            DisplayWorkers(workers);

            workers.Insert(2, "Bakyt");
            Console.WriteLine("Bakyt was hired");
            DisplayWorkers(workers);

            bool isNastiaWorking = workers.Contains("Nastia");
            if (isNastiaWorking)
            {
                Console.WriteLine("Nastia is working!");
            }

            DisplayWorkers(workers);
            workers.Clear();
            DisplayWorkers(workers);

            Console.WriteLine("=============================================================");

        }
        static void DisplayWorkers(List<string> workers)
        {
            foreach(string worker in workers){
                Console.Write(worker + ", ");
            }
            Console.WriteLine();
        }

        static void DisplayList(List<int> list)
        {
            foreach(int number in list)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine();
        }
    }
}
