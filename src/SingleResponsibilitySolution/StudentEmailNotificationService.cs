namespace SingleResponsibilitySolution;

public static class StudentEmailNotificationService
{
    public static void SendEmailVerificationToken(Student student)
    {
        Console.WriteLine($"{student.VerificationCode} has been sent to {student.Email}.");
    }
}
