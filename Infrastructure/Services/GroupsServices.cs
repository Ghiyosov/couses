using Dapper;
using Domein.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class GroupsServices
{
    readonly DapperContext _context;
    public GroupsServices()
    {
        _context = new DapperContext();
    }

    public List<Groups> GetGroups()
    {
        var sql = _context.Connection().Query<Groups>("select * from groups").ToList();
        return sql;
    } 
    public void AddGroup(Groups groups)
    {
        var sql = "insert into grops(name,courseid)values(@name,courseid)";
        _context.Connection().Execute(sql,groups);
    }
    public void UpdateGroup(Groups groups)
    {
        _context.Connection().Execute("update courses set name=@name, courseid=@courseid where id=@id",groups);
    }
    public void DeleteGroups(int id)
    {
        _context.Connection().Execute("delete from groups as cr where cr.id=@id",new{Id=id});
    }
}
