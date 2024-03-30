

internal class Student
{
    public int id { get; set; }
    public string? fio { get; set; }
    public string? date { get; set; }
    public string? special { get; set; }
    public int course { get; set; }

}

internal class Program
{
    static Student student()
    {
        Student student = new Student();

        student.id = 1;
        student.fio = "Адушев Никита Сергеевич";
        student.date = "17.07.2004";
        student.special = "ИСП-411";
        student.course = 4;

        return student;
    }

    public static void PrintStudent(Student student)
    {
        Console.WriteLine("Id студента: " + student.id);
        Console.WriteLine("ФИО студента: " + student.fio);
        Console.WriteLine("Дата рождения студента: " + student.date);
        Console.WriteLine("Специальность студента: " + student.special);
        Console.WriteLine("Курс студента: " + student.course);
    }

    private static void Main(string[] args)
    {
        var dataStudent = student();
        PrintStudent(dataStudent);
    }
}