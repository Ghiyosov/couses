using Dapper;
using Domein.Models;
using Infrastructure.DataContext;
namespace Infrastructure.Services;

public class StudentServices
{
    readonly DapperContext _context;
    public StudentServices()
    {
        _context = new DapperContext();
    }

    public List<Student> GetStudents()
    {
        var sql = _context.Connection().Query<Student>("select * from student").ToList();
        return sql;
    }
    public void AddStudent(Student student)
    {
        var sql = "insert into student(fullname,age,groupid)values(@fullname,@age,@groupid)";
        _context.Connection().Execute(sql, student);
    }
    public void UpdateStudent(Student student)
    {
        _context.Connection().Execute("update student set fullname=@fullname, groupid=@groupid where id=@id", student);
    }
    public void DeleteStudent(int id)
    {
        _context.Connection().Execute("delete from groups as cr where cr.id=@id", new { Id = id });
    }
    public List<GroupStudent> GetGroupStudents()
    {
        var sql = _context.Connection().Query<GroupStudent>(@"select g.name as groupname, st.fullname as fullname
                                                              from student as st
                                                              join groups as g on st.groupid=g.id").ToList();
        return sql;
    }
    public List<GroupStudent> GetGroupCourse()
    {
        var sql = _context.Connection().Query<GroupStudent>(@"select g.name as groupname, st.name as fullname
                                                              from groups as st
                                                              join courses as g on st.courseid=g.id").ToList();
        return sql;
    }
    public List<Student> GetStudentsByGroup(int id)
    {
        var sql = _context.Connection().Query<Student>("select * from student as st where st.groupid=@id", new { Id = id }).ToList();
        return sql;
    }
}
