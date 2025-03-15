using Prototype;

Teacher teacher = new("Mehrjoo", "Math");
var teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher wa cloned: {teacherClone.Name} who teaches '{teacher.Course}'");


Student student = new("Mahdi", teacherClone);
var studentClone = (Student)student.Clone();
Console.WriteLine($"Student wa cloned: {student.Name} who is enrolled in {student.Teacher.Name}'s course.");

teacherClone.Name = "Davoodi";

Console.WriteLine($"Student wa cloned: {student.Name} who is enrolled in {student.Teacher.Name}'s course.");



