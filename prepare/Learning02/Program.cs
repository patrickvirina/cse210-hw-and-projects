using System;

class Program
{
    static void Main(string[] args)
    {
     Job job1 = new Job();
        job1._jobTitle = "SEO Specialist";
        job1._company = "No Joke Marketing";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "SEO and Content Specialist";
        job2._company = "Clean Marketing";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Patrick Viriña";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}