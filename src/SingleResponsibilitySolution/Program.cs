using SingleResponsibilitySolution;

var student = StudentAuthenticationService.Register("John Doe", "john@domain.com", "1234");

StudentEmailNotificationService.SendEmailVerificationToken(student);

StudentAuthenticationService.Logout(student);

Console.ReadKey();
