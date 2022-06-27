using DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DataAccessObjects.Contexts;

public class MemberDAO : BaseDAO
{
    private static MemberDAO instance = null;
    private static readonly object instanceLock = new object();
    private MemberDAO() { }
    public static MemberDAO Instance
    {
        get {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new MemberDAO();
                }
            }
            return instance;
        }
    }
    
    public IEnumerable<Member> GetMemberList()
    {
        IDataReader dataReader = null;
        var memberList = new List<Member>();
        // CONTINUE CODE HERE
        string sql = "select * from Member";
        try
        {
            dataReader = dataAccessProvider.GetDataReader(
                sql,
                CommandType.Text,
                out connection);
            while (dataReader.Read())
            {
                memberList.Add(new Member
                {
                    MemberID = dataReader.GetInt32(0),
                    MemberName = dataReader.GetString(1),
                    Email = dataReader.GetString(2),
                    Password = dataReader.GetString(3),
                    City = dataReader.GetString(4),
                    Country = dataReader.GetString(5),  
                });
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            dataReader.Close();
            CloseConnection();
        }
        return memberList;
    }
    public Member GetMemberById(int memberId)
    {
        Member member = null;
        // CONTINUE CODE HERE
        IDataReader dataReader = null;
        string sql = "select * from Member where MemberId=@MemberId";
        try
        {
            var param = dataAccessProvider.CreateParameter(
                "@MemberId",
                4,
                memberId,
                DbType.Int32);
            dataReader = dataAccessProvider.GetDataReader(
                sql,
                CommandType.Text,
                out connection,
                param);
            if (dataReader.Read())
            {
                member = new Member
                {
                    MemberID = dataReader.GetInt32(0),
                    MemberName = dataReader.GetString(1),
                    Email = dataReader.GetString(2),
                    Password = dataReader.GetString(3),
                    City = dataReader.GetString(4),
                    Country = dataReader.GetString(5),
                };
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return member;
    }
    public void InsertMember(Member member)
    {
        // CODE HERE
        string sql = "insert Member(MemberName, Email, Password, City, Country) " +
            "values (@MemberName, @Email, @Password, @City, @Country)";
        try
        {
            Member checkMember = GetMemberById(member.MemberID);
            if (checkMember == null)
            {
                var param = new List<SqlParameter>();
                param.Add(dataAccessProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@City", 20, member.City, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Country", 20, member.Country, DbType.String));
                dataAccessProvider.Insert(sql, CommandType.Text, param.ToArray());
            }
            else
            {
                throw new Exception("Member already exist!");
            }
        } 
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }
    public void UpdateMember(Member member)
    {
        // CODE HERE
        string sql = "update Member set MemberName=@MemberName, Email=@Email, " +
            "Password=@Password, City=@City, Country=@Country where MemberId=@MemberId";
        try
        {
            Member checkMember = GetMemberById(member.MemberID);
            if (checkMember != null)
            {
                var param = new List<SqlParameter>();
                param.Add(dataAccessProvider.CreateParameter("@MemberId", 4, member.MemberID, DbType.Int32));
                param.Add(dataAccessProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@City", 20, member.City, DbType.String));
                param.Add(dataAccessProvider.CreateParameter("@Country", 20, member.Country, DbType.String));
                dataAccessProvider.Update(sql, CommandType.Text, param.ToArray());
            }
            else
            {
                throw new Exception("Member does not exist!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }
    public void RemoveMember(int memberId)
    {
        // CODE HERE
        string sql = "delete Member where MemberId=@MemberId";
        try
        {
            Member checkMember = GetMemberById(memberId);
            if (checkMember != null)
            {
                var param = new List<SqlParameter>();
                param.Add(dataAccessProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32));
                dataAccessProvider.Update(sql, CommandType.Text, param.ToArray());
            }
            else
            {
                throw new Exception("Member does not exist!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }
}
