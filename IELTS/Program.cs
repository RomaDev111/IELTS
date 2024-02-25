using System;

class IELTS
{
    static void Main(string[] args)
    {
        Console.WriteLine("IELTS score calculator");
        Console.WriteLine("Enter your scores for each section (Listening, Reading, Writing, Speaking) ");

        Console.WriteLine("Listening: ");
        double listeningScore = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Reading: ");
        double readingScore = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Writing ");
        double writingScore = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Speaking ");
        double speakingScore = Convert.ToDouble(Console.ReadLine());

         double sum = listeningScore + readingScore + writingScore + speakingScore;
        double overAllScore = sum / 4;
        overAllScore = Math.Round(overAllScore, MidpointRounding.AwayFromZero);
        Console.WriteLine("Your overall score is " + overAllScore);
        Console.WriteLine("Thank you for using our applications");
      
    }
}
