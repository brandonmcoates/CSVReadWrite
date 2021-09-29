using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IssueTracker
{
    class ReadWrite
    {
        public void ReadFile()
        {

            var lines = File.ReadAllLines(@"C:\Users\brand\OneDrive\Documents\BillionsSampleCSV.txt");
            var list = new List<Task>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                var task = new Task() { TaskName = values[0], Person = values[1], Completed = values[2] };
                list.Add(task);
            }
            list.ForEach(x => Console.WriteLine($"{x.TaskName}\t\t\t{x.Person}\t\t\t\t{x.Completed}"));
        }
    }
    public class Task
    { 
        public string TaskName { get; set; }
        public string Person { get; set; }
        public string Completed { get; set; }
    }
}