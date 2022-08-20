namespace SingleResponsibilityProblem;

public class Student
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string VerificationCode { get; set; } = string.Empty;


    public void Register()
    {
        Console.WriteLine("New student registered.");
    }

    public void Login(string email, string password)
    {
        Console.WriteLine("Student logged in");
    }

    public void Logout(string email, string password)
    {
        Console.WriteLine("Student logged in");
    }

    public void SendEmailVerificationToken()
    {
        Console.WriteLine($"{VerificationCode} has been sent to {Email}");
    }

    public IEnumerable<Student> GetStudents()
    {
        var students = new List<Student>
        {
            new Student
            { 
                FirstName = "John",
                LastName = "Doe",
                Email = "John@Domain.com",
                Password = "1234"
            },
            new Student
            {
                FirstName = "Jane",
                LastName = "Doe",
                Email = "Jane@Domain.com",
                Password = "4321"
            },
            new Student
            {
                FirstName = "Peter",
                LastName = "Jackson",
                Email = "Peter@Domain.com",
                Password = "12345"
            },
        };

        return students;
    }
}
