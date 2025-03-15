namespace Prototype;

public class Student : Person
{
    public Student(string name, Teacher teacher) : base(name)
    {
        // Cloning the teacher object to prevent external modifications from affecting this instance.
        Teacher = (Teacher)teacher.Clone();
    }
    
    public Teacher Teacher { get; set; }
    
    public override Person Clone()
    {
        return (Person)MemberwiseClone();
    }
}