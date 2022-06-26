using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessObjects.Contexts;

public class MemberDAO
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
        return memberList;
    }
    public Member GetMemberById(int memberId)
    {
        Member member = null;
        // CONTINUE CODE HERE
        return member;
    }
    public void InsertMember(Member member)
    {
        // CODE HERE
    }
    public void UpdateMember(Member member)
    {
        // CODE HERE
    }
    public void RemoveMember(int memberId)
    {
        // CODE HERE
    }
}
