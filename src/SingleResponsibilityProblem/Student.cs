namespace SingleResponsibilityProblem;

public class Student
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string VerificationCode { get; set; } = string.Empty;


    public void Register(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;

        VerificationCode = "85412";

        Console.WriteLine("New student registered.");
    }

    public void Login(string email, string password)
    {
        if (email == Email && password == Password)
        {
            Console.WriteLine("Student logged in.");
        }
        else
        {
            Console.WriteLine("Wrong email or password!");
        }
    }

    public void Logout()
    {
        Console.WriteLine("Student logged out.");
    }

    public void SendEmailVerificationToken()
    {
        Console.WriteLine($"{VerificationCode} has been sent to {Email}.");
    }

    public IEnumerable<Student> GetStudents()
    {
        var students = new List<Student>
        {
            new Student
            { 
                Name = "John Doe",
                Email = "John@Domain.com",
                Password = "1234"
            },
            new Student
            {
                Name = "Jane Doe",
                Email = "Jane@Domain.com",
                Password = "4321"
            },
            new Student
            {
                Name = "Peter Jackson",
                Email = "Peter@Domain.com",
                Password = "12345"
            },
        };

        return students;
    }
}
