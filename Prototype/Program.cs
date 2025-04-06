using Prototype;

// Prototype Pattern:
// A creational design pattern that allows you to create new objects by copying an existing object,
// known as the prototype, rather than creating a new instance from scratch.
// It is useful when the cost of creating a new object is more expensive than copying an existing one,
// or when you need to create a large number of similar objects with slight variations.


Teacher teacher = new("Mehrjoo", "Math");
var teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher wa cloned: {teacherClone.Name} who teaches '{teacher.Course}'");


Student student = new("Mahdi", teacherClone);
var studentClone = (Student)student.Clone();
Console.WriteLine($"Student wa cloned: {student.Name} who is enrolled in {student.Teacher.Name}'s course.");

teacherClone.Name = "Davoodi";

Console.WriteLine($"Student wa cloned: {student.Name} who is enrolled in {student.Teacher.Name}'s course.");



