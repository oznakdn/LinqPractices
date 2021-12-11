// See https://aka.ms/new-console-template for more information
using LinqPractices.DbOperations;

DataGenerator.Initialize();
LinqDbContext _context = new LinqDbContext();
var students = _context.Students.ToList();

Console.WriteLine("********ToList()*********");

var StudentList = _context.Students.Where(x => x.ClassId == 2).ToList(); // ClassId'si 2 olanları listele
foreach (var item1 in StudentList)
{
    Console.WriteLine(item1.Name + " " + item1.Surname);
}

foreach (var item in students)
{
    Console.WriteLine("***********");
    Console.WriteLine(item.StudentId+"\n"+item.Name+"\n"+item.Surname+"\n"+item.ClassId);
}

// Find Metodu
Console.WriteLine("********Find()*******");
Console.WriteLine("Id giriniz");
int id = int.Parse(Console.ReadLine());
var student = _context.Students.Find(id);
Console.WriteLine(student.Name+" "+student.Surname+" "+student.ClassId);

// FirsOrDefault
Console.WriteLine("********FirstOrDefault()*******");
student = _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
Console.WriteLine(student.Name);

student = _context.Students.FirstOrDefault(x => x.StudentId == id);
Console.WriteLine(student.Surname);

// SingleOrDefault
Console.WriteLine("********SingleOrDefault()*******");
student = _context.Students.SingleOrDefault(x => x.StudentId == id);
Console.WriteLine(student.Name);

// OrderBy
Console.WriteLine("********OrderBy()*******");
students = _context.Students.OrderBy(x => x.StudentId).ToList(); // Id ye göre sıralar
foreach (var item2 in students)
{
    Console.WriteLine(item2.Name+" "+item2.Surname);
}

// OrderByDescending
Console.WriteLine("********OrderByDescending()*******");
students = _context.Students.OrderByDescending(x => x.StudentId).ToList(); // Id ye göre tersten sıralar
foreach (var item3 in students)
{
    Console.WriteLine(item3.Name + " " + item3.Surname);

}

// Anonymous Object Result
Console.WriteLine("********Anonymous Object Result*******");
var anonymousObject = _context.Students.Where(x => x.ClassId == 2).Select(x => new
{
    Id=x.StudentId,
    FullName=x.Name+" "+x.Surname
});
foreach (var item4 in anonymousObject)
{
    Console.WriteLine(item4.Id + "-" + item4.FullName);
}











