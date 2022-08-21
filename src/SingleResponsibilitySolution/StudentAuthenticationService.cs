namespace SingleResponsibilitySolution;

public static class StudentAuthenticationService
{
    public static Student Register(string name, string email, string password)
    {
        Student student = new Student
        {
            Name = name,
            Email = email,
            Password = password,
            VerificationCode = "85412"
        };

        return student;
    }

    public static bool Login(string email, string password, Student student)
    {
        return email == student.Email && password == student.Password;
    }

    public static void Logout(Student student)
    {
        Console.WriteLine("Student logged out.");
    }
}
