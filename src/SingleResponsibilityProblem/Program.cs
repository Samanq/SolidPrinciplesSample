using SingleResponsibilityProblem;

Student student = new Student();

student.Register("John","john@domain.com","1234");
student.SendEmailVerificationToken();
student.Login("john@domain.com", "1234");

Console.ReadKey();
