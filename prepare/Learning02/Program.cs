using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Rainfocus";
        job1._jobTitle = "Junior Logistics and Shipping";
        job1._startYear = 2023;
        job1._endYear = 2023;
        

        Job job2 = new Job();
        job2._company = "Mesa Solutions";
        job2._jobTitle = "Warehouse Manager";
        job2._startYear = 2021;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "LaMond Lamoreaux";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
        
    }

    

}