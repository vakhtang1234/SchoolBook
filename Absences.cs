public class Absences
{
    public int Percentage {get;set;}
    public Absences()
    {
        string pathAbsences = @"C:\Users\gogia\OneDrive\Desktop\projects\Schoolbook\absences.txt";
        Percentage = AbsencePercentage(pathAbsences);
    }
    public int AbsencePercentage(string pathFile)
    {
        using(StreamReader reader = new StreamReader(pathFile))
        {
            string? line;
            int lineCounter = 0;
            int AbsenceCounter = 0;
            while((line = reader.ReadLine()) != null)
            {
                if(line == "no")
                {
                    AbsenceCounter++;
                }
                lineCounter++;
            }
            return AbsenceCounter * 100/lineCounter;
        }

    }
}