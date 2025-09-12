using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Mojang";
        job1._startYear = "2001";
        job1._endYear = "20025";

        Job job2 = new Job();
        job2._jobTitle = "WorkerDude";
        job2._company = "IdkTheCompany";
        job2._startYear = "1";
        job2._endYear = "2";

        job1.Display();
        job2.Display();


        Resume newresum = new Resume();
        newresum._name = "Ethan Haws";
        newresum._job.Add(job1);
        newresum._job.Add(job2);
        newresum.Display();
    }
}