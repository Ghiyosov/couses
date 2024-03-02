using Dapper;
using Domein.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class CourseServices
{
    readonly DapperContext _context;
    public CourseServices()
    {
        _context = new DapperContext();
    }

    public List<Courses> GetCourses()
    {
        var sql = _context.Connection().Query<Courses>("select * from courses").ToList();
        return sql;
    } 
    public void AddCorse(Courses courses)
    {
        var sql = "insert into courses(name)values(@name)";
        _context.Connection().Execute(sql,courses);
    }
    public void UpdateCourse(Courses courses)
    {
        _context.Connection().Execute("update courses set name=@name where id=@id",courses);
    }
    public void DeleteCourse(int id)
    {
        _context.Connection().Execute("delete from course as cr where cr.id=@id",new{Id=id});
    }
}
