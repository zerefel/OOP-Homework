using System;
using System.Collections.Generic;
using System.Linq;

namespace _02HumanStudentWorker
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Petur", "Sashov", "Z121556A");
            Student student2 = new Student("Ivan", "Toshov", "AAAAAbbb");
            Student student3 = new Student("Dimitur", "Tudjarov", "532521");
            Student student4 = new Student("Georgi", "Asenov", "57423");
            Student student5 = new Student("Djamal", "Djarov", "569421");
            Student student6 = new Student("Hasan", "Strahov", "64316");
            Student student7 = new Student("John", "Idiotov", "676436");
            Student student8 = new Student("Aslan", "Aslanov", "532678");
            Student student9 = new Student("Krasi", "Stavrov", "951267");
            Student student10 = new Student("Niki", "Hristiqnovich", "995225");

            List<Student> studentsList = new List<Student>();
            studentsList.Add(student1);
            studentsList.Add(student2);
            studentsList.Add(student3);
            studentsList.Add(student4);
            studentsList.Add(student5);
            studentsList.Add(student6);
            studentsList.Add(student7);
            studentsList.Add(student8);
            studentsList.Add(student9);
            studentsList.Add(student10);
           
            Worker worker1 = new Worker("Georgi", "Peshov", 200, 8);
            Worker worker2 = new Worker("Tosho", "Mahovikov", 300, 8);
            Worker worker3 = new Worker("Samuil", "Kurbelov", 200, 5);
            Worker worker4 = new Worker("Strahil", "Kolonov", 100, 8);
            Worker worker5 = new Worker("Svetlin", "Debelqnov", 2200, 8);
            Worker worker6 = new Worker("Bok", "Qvorov", 90, 2);
            Worker worker7 = new Worker("Slavqn", "Vapcarov", 500, 12);
            Worker worker8 = new Worker("Trak", "Bagrqnov", 260, 8);
            Worker worker9 = new Worker("Gruk", "Vazov", 150, 8);
            Worker worker10 = new Worker("Turk", "Botev", 200, 3);

            List<Worker> workersList = new List<Worker>() 
            {
                worker1, 
                worker2, 
                worker3, 
                worker4, 
                worker5, 
                worker6, 
                worker7, 
                worker8, 
                worker9, 
                worker10
            };

            // Using OrderBy
            var sortedWorkers = workersList.OrderByDescending(worker => worker.MoneyPerHour());

            //Using Lambda
            studentsList.Sort((x, y) => x.FacultyNumber.CompareTo(y.FacultyNumber));

            List<Human> mergedHumans = new List<Human>();
            mergedHumans.AddRange(sortedWorkers);
            mergedHumans.AddRange(studentsList);
            var sortedMergedList = mergedHumans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            foreach (var human in sortedMergedList)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
