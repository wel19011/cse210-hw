using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
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

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();

        // Console.WriteLine(job1.Display(_company, _jobTitle, ));
    }
}