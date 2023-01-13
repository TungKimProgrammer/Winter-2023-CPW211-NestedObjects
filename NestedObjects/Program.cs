using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "JoeOrtiz@cptc.edu",
    FullName = "Joe Ortiz",
    OfficeLocation = "B11 Rm 110"
};

Student stu1 = new Student()
{
    FirstName = "Tung",
    LastName = "Kim",
    DateOfBirth = new DateOnly(1984, 6, 3),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "8008889999",
    SchoolEmail = "kim9999@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} as the computer scient advisor!");
Console.WriteLine($"Student {stu1.FirstName}'s advisor, {stu1.AssignedAdvisor.FullName}, can be reached at {stu1.AssignedAdvisor.Email} or {stu1.AssignedAdvisor.OfficeLocation}");