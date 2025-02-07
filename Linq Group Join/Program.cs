using Linq_Group_Join;

List<Students> studentsList = new List<Students>
{
    new Students { StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new Students { StudentId=2, StudentName="Ayşe", ClassId=2 },
    new Students { StudentId=3, StudentName="Mehmet", ClassId=1 },
    new Students { StudentId=4, StudentName="Fatma", ClassId=3 },
    new Students { StudentId=5, StudentName="Ahmet", ClassId=2 },
};

List<Classes> classList = new List<Classes>
{
    new Classes { ClassId = 1 , ClassName="Matematik" },
    new Classes { ClassId = 2 , ClassName="Türkçe" },
    new Classes { ClassId = 3 , ClassName="Kimya" }
};

var result = classList.GroupJoin(
             studentsList,
             c => c.ClassId,
             s => s.ClassId,
             (classObj, StudentGroup) => new
             {
                 ClassName = classObj.ClassName,
                 Students = StudentGroup.Select(s => s.StudentName).ToList()
             });

        foreach(var group in result)
{
    Console.WriteLine($"Sınıf : {group.ClassName}");
    foreach(var student in group.Students)
    {
        Console.WriteLine($" - Öğrenci Adı: {student}");
    }
    Console.WriteLine();
}


