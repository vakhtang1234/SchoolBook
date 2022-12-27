using System.IO;
public class SchoolLessons
{
    public void Lessons()
    {
        Grades grades = new Grades();
        Homework homework = new Homework();
        Absences absences = new Absences();
        TimeSpan currentTime = DateTime.Now.TimeOfDay;
        TimeSpan start1Lesson = TimeSpan.FromMinutes(9*60);
        TimeSpan end1Lesson = TimeSpan.FromMinutes(9*60+40);
        TimeSpan start2Lesson = TimeSpan.FromMinutes(9*60+40+5);
        TimeSpan end2Lesson = TimeSpan.FromMinutes(9*60+80+5);
        TimeSpan start3Lesson = TimeSpan.FromMinutes(9*60+80+10);
        TimeSpan end3Lesson = TimeSpan.FromMinutes(11*60+10);
        TimeSpan start4Lesson = TimeSpan.FromMinutes(11*60+30);
        TimeSpan end4Lesson = TimeSpan.FromMinutes(11*60+40+30);
        TimeSpan start5Lesson = TimeSpan.FromMinutes(11*60+40+45);
        TimeSpan end5Lesson = TimeSpan.FromMinutes(11*60+80+45);
        TimeSpan start6Lesson = TimeSpan.FromMinutes(11*60+80+50);
        TimeSpan end6Lesson = TimeSpan.FromMinutes(13*60+50);
        TimeSpan start7Lesson = TimeSpan.FromMinutes(13*60+55);
        TimeSpan end7Lesson = TimeSpan.FromMinutes(13*60+40+55);
        TimeSpan start8Lesson = TimeSpan.FromMinutes(13*60+40+60);
        TimeSpan end8Lesson = TimeSpan.FromMinutes(13*60+80+60);
        DayOfWeek wk = DateTime.Today.DayOfWeek;
        System.Console.WriteLine($"Today is : {wk}");
        System.Console.WriteLine($"your whole average is: {grades.WholeAverage}");
        System.Console.WriteLine($"your absence percentage is: {absences.Percentage}");
        System.Console.WriteLine(" ");

        string weekDay = Convert.ToString(wk);
        string pathMOnday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Monday.txt";
        string pathTuesday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Tuesday.txt";
        string pathWednesday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Wednesday.txt";
        string pathThursday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Thursday.txt";
        string pathFriday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Friday.txt";
        string pathSaturday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Saturday.txt";
        string pathSunday = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\MySchoolLessons\Sunday'.txt";

        DateTime date = DateTime.Now;
        switch (weekDay)
        {
            case "Monday":
                using(StreamReader reader = new StreamReader(pathMOnday))
                {
                    if(currentTime <= end8Lesson)
                    {
                        System.Console.WriteLine($"{weekDay}s lessons are :");
                        string? line;
                        List<string>Lesson = new List<string>();
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            Lesson.Add(line);
                        }
                        System.Console.WriteLine(" ");
                        if(currentTime >= start1Lesson && currentTime <= end1Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[0]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglishMath);
                        }
                        else if(currentTime >=start2Lesson && currentTime <=end2Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[1]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInChemistry);
                        }
                        else if(currentTime>= start3Lesson && currentTime <= end3Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[2]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else if(currentTime >= start4Lesson && currentTime <= end4Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[3]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else if(currentTime >= start5Lesson && currentTime <= end5Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[4]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGermany);
                        }
                        else if(currentTime >= start6Lesson && currentTime <= end6Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[5]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgianHistory);
                        }
                        else if(currentTime >= start7Lesson && currentTime <= end7Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[6]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start8Lesson && currentTime <= end8Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[7]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else
                        {
                            System.Console.WriteLine("you now have a break");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("you have to do your homework");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("tommorow you have to do");
                        System.Console.WriteLine("German, Georgian history, english, maths, biology, georgian language, chemistry and Physics");
                        System.Console.WriteLine($"homework for german language : {homework.GermanHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for Georgian history : {homework.GeorgianHistoryHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for English language : {homework.EnglishHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for maths : {homework.MathematicsHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for biology : {homework.BiologyHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for georgian Language : {homework.GeorgianHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for chemistry : {homework.ChemistryHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"homework for physics : {homework.PhysicsHomework}");
                    }
                }
                break;
            case "Tuesday":
                using(StreamReader reader = new StreamReader(pathTuesday))
                {
                    if(currentTime < end8Lesson)
                    {
                        System.Console.WriteLine($"{weekDay}s lessons are :");
                        string? line;
                        List<string>Lesson = new List<string>();
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            Lesson.Add(line);
                        }
                        System.Console.WriteLine(" ");
                        if(currentTime >= start1Lesson && currentTime <= end1Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[0]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGermany);
                        }
                        else if(currentTime >=start2Lesson && currentTime <=end2Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[1]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgianHistory);
                        }
                        else if(currentTime>= start3Lesson && currentTime <= end3Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[2]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start4Lesson && currentTime <= end4Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[3]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);
                        }
                        else if(currentTime >= start5Lesson && currentTime <= end5Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[4]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInBiology);
                        }
                        else if(currentTime >= start6Lesson && currentTime <= end6Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[5]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else if(currentTime >= start7Lesson && currentTime <= end7Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[6]}");
                            System.Console.WriteLine("your average in that subject is :");
                            Console.WriteLine(grades.AverageGradeInChemistry);
                        }
                        else if(currentTime >= start8Lesson && currentTime <= end8Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[7]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInPhysics);
                        }
                        else
                        {
                            System.Console.WriteLine("your now have a break");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("your have to do your homework");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("tommorow you have to do");
                        System.Console.WriteLine("Biology, Georgian, English, Maths,World History");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"homework in Biology: {homework.BiologyHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"Homework in Georgian Language: {homework.GeorgianHomework}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"Homework in English Lesson: {homework.EnglishHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Maths: {homework.MathematicsHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in World History: {homework.WorldHistoryHomework}");
                    }
                }
                break;
            case "Wednesday":
                using(StreamReader reader = new StreamReader(pathWednesday))
                {
                    if(currentTime < end8Lesson)
                    {
                        System.Console.WriteLine($"{weekDay}s lessons are :");
                        string? line;
                        List<string>Lesson = new List<string>();

                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            Lesson.Add(line);
                        }
                        System.Console.WriteLine(" ");
                        if(currentTime >= start1Lesson && currentTime <= end1Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[0]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInBiology);
                        }
                        else if(currentTime >=start2Lesson && currentTime <=end2Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[1]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else if(currentTime>= start3Lesson && currentTime <= end3Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[2]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start4Lesson && currentTime <= end4Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[3]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);
                        }
                        else if(currentTime >= start5Lesson && currentTime <= end5Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[4]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);
                        }
                        else if(currentTime >= start6Lesson && currentTime <= end6Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[5]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeorgianHistory);
                        }
                        else if(currentTime >= start7Lesson && currentTime <= end7Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[6]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start8Lesson && currentTime <= end8Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[7]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeography);
                        }
                        else
                        {
                            System.Console.WriteLine("you now have a break");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("you have to do your homework");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("you have to do");
                        System.Console.WriteLine("Math, World History, Geography, EnglishMath, English");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Math: {homework.MathematicsHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in World history: {homework.WorldHistoryHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in geography: {homework.GeographyHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in English Math {homework.EnglishMathHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in English {homework.EnglishHomework}");
                    }

                }
                break;
            case "Thursday":
                using(StreamReader reader = new StreamReader(pathThursday))
                {
                    if(currentTime < end8Lesson)
                    {
                        System.Console.WriteLine($"{weekDay}s lessons are :");
                        string? line;
                        List<string>Lesson = new List<string>();
                        while ((line = reader.ReadLine()) != null)
                        {
                            Lesson.Add(line);
                            Console.WriteLine(line);
                        }
                        System.Console.WriteLine(" ");
                        if(currentTime >= start1Lesson && currentTime <= end1Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[0]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);
                        }
                        else if(currentTime >=start2Lesson && currentTime <=end2Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[1]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);
                        }
                        else if(currentTime>= start3Lesson && currentTime <= end3Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[2]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start4Lesson && currentTime <= end4Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[3]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInWorldHistory);
                        }
                        else if(currentTime >= start5Lesson && currentTime <= end5Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[4]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInGeography);
                        }
                        else if(currentTime >= start6Lesson && currentTime <= end6Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[5]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglishMath);
                        }
                        else if(currentTime >= start7Lesson && currentTime <= end7Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[6]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start8Lesson && currentTime <= end8Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[7]}");
                            System.Console.WriteLine("your average in that subject is :");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else
                        {
                            System.Console.WriteLine("you now have a break");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("you have to do your homework");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("Today you have to do ");
                        System.Console.WriteLine("Geography, Physics,Georgian Language, Mathematics, Citizenship,English language");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Geography: {homework.GeographyHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Physics: {homework.PhysicsHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Georgian language: {homework.GeorgianHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Maths: {homework.MathematicsHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Citizenship: {homework.CitizenshipHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in English language: {homework.EnglishHomework}");
                    }
                }
                break;
            default:
            using(StreamReader reader = new StreamReader(pathFriday))
                {
                    if(currentTime < end8Lesson)
                    {
                        System.Console.WriteLine($"{weekDay}s lessons are :");
                        string? line;
                        List<string>Lesson = new List<string>();
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                        System.Console.WriteLine(" ");
                        if(currentTime >= start1Lesson && currentTime <= end1Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[0]}");
                            System.Console.WriteLine(grades.AverageGradeInGeography);
                        }
                        else if(currentTime >=start2Lesson && currentTime <=end2Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[1]}");
                            System.Console.WriteLine(grades.AverageGradeInPhysics);
                        }
                        else if(currentTime>= start3Lesson && currentTime <= end3Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[2]}");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else if(currentTime >= start4Lesson && currentTime <= end4Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[3]}");
                            System.Console.WriteLine("get a breather");
                        }
                        else if(currentTime >= start5Lesson && currentTime <= end5Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[4]}");
                            System.Console.WriteLine(grades.AverageGradeInMathematics);

                        }
                        else if(currentTime >= start6Lesson && currentTime <= end6Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[5]}");
                            System.Console.WriteLine(grades.AverageGradeInCitizenship);
                        }
                        else if(currentTime >= start7Lesson && currentTime <= end7Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[6]}");
                            System.Console.WriteLine(grades.AverageGradeInEnglish);
                        }
                        else if(currentTime >= start8Lesson && currentTime <= end8Lesson)
                        {
                            System.Console.WriteLine($"you now have {Lesson[7]}");
                            System.Console.WriteLine(grades.AverageGradeInGeorgian);
                        }
                        else
                        {
                            System.Console.WriteLine("you now have a break");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("you have to do your homework");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine("you have to do");
                        System.Console.WriteLine("English math, Chemistry, Georgian Language, German Language");
                        System.Console.WriteLine("Georgian History, English language");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in english math: {homework.EnglishMathHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Chemistry: {homework.ChemistryHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in Georgian language: {homework.GeorgianHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in German Language: {homework.GermanHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"homework in georgian history: {homework.GeorgianHistoryHomework}");
                        System.Console.WriteLine(" ");
                        System.Console.WriteLine($"Homework in English Language: {homework.EnglishHomework}");
                    }
                }  
            break;
        }
    }
}
