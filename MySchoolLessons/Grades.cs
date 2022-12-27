public class Grades
{
    public double WholeAverage {get;set;}
    public double AverageGradeInBiology {get;set;}
    public double AverageGradeInCitizenship {get;set;}
    public double AverageGradeInChemistry {get;set;}
    public double AverageGradeInEnglishMath {get;set;}
    public double AverageGradeInEnglish {get;set;}
    public double AverageGradeInGeography {get;set;}
    public double AverageGradeInGeorgian {get;set;}
    public double AverageGradeInGeorgianHistory {get;set;}
    public double AverageGradeInGermany {get;set;}
    public double AverageGradeInMathematics {get;set;}
    public double AverageGradeInPhysics {get;set;}
    public double AverageGradeInWorldHistory {get;set;}
    string pathBiology = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\BiologyGrades.txt";
    string pathChemistry = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\ChemistryGrades.txt";
    string pathCitizenship = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\CitizenshipGrades.txt";
    string pathEnglishMath = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\EnglishMathsGrades.txt";
    string pathEnglish = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\EnglishGrades.txt"; 
    string pathGeography = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\GeographyGrades.txt";
    string pathGeorgian = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\GeorgianGrades.txt";
    string pathGeorgianHistory = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\georgianHistoryGrades.txt";
    string pathGermany = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\GermanGrades.txt";
    string pathMathematics = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\MathematicsGrades.txt";
    string pathPhysiques = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\PhysiquesGrades.txt";
    string pathWorldHistory = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\school Grades\WorldHistoryGrades.txt";
    public Grades()
    {
        AverageGradeInBiology = AverageGradeInSubject(pathBiology);
        AverageGradeInCitizenship = AverageGradeInSubject(pathCitizenship);
        AverageGradeInChemistry = AverageGradeInSubject(pathChemistry);
        AverageGradeInEnglishMath = AverageGradeInSubject(pathEnglishMath);
        AverageGradeInEnglish  = AverageGradeInSubject(pathEnglish);
        AverageGradeInGeography = AverageGradeInSubject(pathGeography);
        AverageGradeInGeorgian = AverageGradeInSubject(pathGeorgian);
        AverageGradeInGeorgianHistory = AverageGradeInSubject(pathGeorgianHistory);
        AverageGradeInGermany = AverageGradeInSubject(pathGermany);
        AverageGradeInMathematics = AverageGradeInSubject(pathMathematics);
        AverageGradeInPhysics = AverageGradeInSubject(pathPhysiques);
        AverageGradeInWorldHistory = AverageGradeInSubject(pathWorldHistory);
        WholeAverage = (Math.Round(AverageGradeInBiology) + Math.Round(AverageGradeInCitizenship) + Math.Round(AverageGradeInChemistry)
                        + Math.Round(AverageGradeInEnglishMath) + Math.Round(AverageGradeInEnglishMath) + Math.Round(AverageGradeInGeography)
                        + Math.Round(AverageGradeInGeorgian) + Math.Round(AverageGradeInGeorgianHistory) + Math.Round(AverageGradeInGermany)
                        + Math.Round(AverageGradeInMathematics) + Math.Round(AverageGradeInPhysics) + Math.Round(AverageGradeInWorldHistory)) / 12.0;
    }
    private double AverageGradeInSubject(string pathToFile)
    {
        using (StreamReader reader = new StreamReader(pathToFile))
        {
            string line;
            List<double> grades = new List<double>();
            while((line = reader.ReadLine()) != null)
            {
                grades.Add(Convert.ToDouble(line));
            }
            double sum = 0;
            for(int i =0; i < grades.Count(); i++)
            {
                sum+=grades[i];
            }
            return sum/grades.Count();
        }
    }
    public void AverageGrades()
    {
        System.Console.WriteLine($"Biology: {AverageGradeInBiology}");
        System.Console.WriteLine($"Citizenship: {AverageGradeInCitizenship}");
        System.Console.WriteLine($"Chemistry: {AverageGradeInChemistry}");
        System.Console.WriteLine($"English Math: {AverageGradeInEnglishMath}");
        System.Console.WriteLine($"English Language : {AverageGradeInEnglish}");
        System.Console.WriteLine($"Geography: {AverageGradeInGeography}");
        System.Console.WriteLine($"Georgian language: {AverageGradeInGeorgian}");
        System.Console.WriteLine($"Georgian history: {AverageGradeInGeorgianHistory}");
        System.Console.WriteLine($"German Language {AverageGradeInGermany}");
        System.Console.WriteLine($"Maths: {AverageGradeInMathematics}");
        System.Console.WriteLine($"Physics: {AverageGradeInPhysics}");
        System.Console.WriteLine($"World History: {AverageGradeInWorldHistory}");
    }
}