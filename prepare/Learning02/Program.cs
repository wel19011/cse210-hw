using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job(); // create instance of the object Job and add attributes the instance
        job1._company = "Microsoft"; // use the dot operator to call a method from the Job class
        job1._jobTitle = "Software Engineer"; // stores the data... where? 
        job1._startYear = 1996;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._jobTitle = "Runner";
        job3._company = "NN Running Team";
        job3._startYear = 2016;
        job3._endYear = 2020;

        Resume myResume = new Resume();
        myResume._personName = "Jared Ward";

        myResume._jobs.Add(job1); // call the _jobs list from the Resume Class 
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display(); // call the Display method from the Job Class

    }
}