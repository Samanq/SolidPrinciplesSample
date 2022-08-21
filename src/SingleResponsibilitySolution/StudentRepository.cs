namespace SingleResponsibilitySolution;

public class StudentRepository
{
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
