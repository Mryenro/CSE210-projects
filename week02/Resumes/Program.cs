using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job(); //first job
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2027;
        job1._endYear = 2029;




        Job job2 = new Job(); //second job
        job2._company = "Apple";
        job2._jobTitle = "Accountant";
        job2._startYear = 2029;
        job2._endYear = 2031;

        Resume resume1 = new Resume(); //create the first and only resume
        resume1._name = "Hamza Bouhou";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
    }
}