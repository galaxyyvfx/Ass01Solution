using DataAccess.DataAccessObjects.Contexts;
using DataAccess.Entities;

namespace DataAccess.Repositories;

public class MemberRepository : IMemberRepository
{
    public void CreateMember(Member member) => MemberDAO.Instance.InsertMember(member);
    public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    public void DeleteMember(int id) => MemberDAO.Instance.RemoveMember(id);
    public Member GetMember(int id) => MemberDAO.Instance.GetMemberById(id);
    public IEnumerable<Member> GetMemberList() => MemberDAO.Instance.GetMemberList();

}
