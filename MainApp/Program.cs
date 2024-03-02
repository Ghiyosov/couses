


using Domein.Models;
using Infrastructure.Services;

var spser = new StudentServices();

// var st = new Student();
// st.FullName="mumtozsho";
// st.Age=20;
// st.GroupId=8;
// spser.AddStudent(st);

// var st1 = new Student();
// st1.Id=8;
// st1.FullName="mumtozsho";
// st1.Age=20;
// st1.GroupId=8;
// spser.UpdateStudent(st1);
// foreach (var item in spser.GetStudents())
// {
//     System.Console.WriteLine(item.Id+" "+ item.FullName+" "+item.Age);
// spser.DeleteStudent(1);--6savol



// } crud
// foreach (var item in spser.GetGroupStudents())
// {
//     System.Console.WriteLine($"grops : {item.GroupName}  student : {item.FullName}");
// } --3savol

// foreach (var item in spser.GetStudentsByGroup(1))
// {
//     System.Console.WriteLine($"{item.Id}.  {item.FullName} {item.Age}");
// }--2savol
// foreach(var item in spser.GetGroupCourse())
// {
//     System.Console.WriteLine($"grops : {item.GroupName}  student : {item.FullName}");
// } --4savol