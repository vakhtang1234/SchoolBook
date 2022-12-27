public class Homework
{
    public string BiologyHomework {get ; set;} 
    public string ChemistryHomework {get;set;}
    public string CitizenshipHomework {get;set;}
    public string EnglishHomework {get;set;}
    public string EnglishMathHomework {get;set;}
    public string GeographyHomework {get;set;}
    public string GeorgianHistoryHomework {get;set;}
    public string GermanHomework {get;set;}
    public string GeorgianHomework {get;set;}
    public string MathematicsHomework {get;set;}
    public string PhysicsHomework {get;set;}
    public string WorldHistoryHomework {get;set;}
    public Homework ()
    {
        string pathBIologyHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\BiologyHomework.txt";
        string pathChemistryHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\ChemistryHomework.txt";
        string pathCitizenshipHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\CitizenshipHomework.txt";
        string pathEnglishHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\EnglishHomework.txt";
        string pathEnglishMathsHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\EnglishMathsHomework.txt";
        string pathGeographyHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\GeographyHomework.txt";
        string pathGeorgianHistoryHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\georgianHistoryHomework.txt";
        string pathGeorgianHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\GeorgianHomework.txt";
        string pathGermanHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\GermanHomework.txt";
        string pathMathematicsHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\MathematicsHomework.txt";
        string pathPhysicsHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\PhysiquesHomework.txt";
        string pathWorldHistoryHomework = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\Homework\WorldHistoryHomework.txt";
        BiologyHomework = homeworks(pathBIologyHomework);
        ChemistryHomework = homeworks(pathChemistryHomework);
        CitizenshipHomework = homeworks(pathCitizenshipHomework);
        EnglishHomework = homeworks(pathEnglishHomework);
        EnglishMathHomework = homeworks(pathEnglishMathsHomework);
        GeographyHomework = homeworks(pathGeographyHomework);
        GeorgianHistoryHomework = homeworks(pathGeorgianHistoryHomework);
        GeorgianHomework = homeworks(pathGeorgianHomework);
        GermanHomework = homeworks(pathGermanHomework);
        MathematicsHomework = homeworks(pathMathematicsHomework);
        PhysicsHomework = homeworks(pathPhysicsHomework);
        WorldHistoryHomework = homeworks(pathWorldHistoryHomework);


    }
    public string homeworks(string pathFile)
    {
        using (StreamReader reader = new StreamReader(pathFile))
        {
            string? line = "", l;
            while((l = reader.ReadLine()) != null)
            {
                line = l;
            }
            return line;
        }
    }
}