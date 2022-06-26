using DataAccess.Entities;

namespace DataAccess.Repositories;

public interface IMemberRepository
{
    public Member GetMember(int id);
    public IEnumerable<Member> GetMemberList();
    public void CreateMember(Member member);
    public void UpdateMember(Member member);
    public void DeleteMember(int id);

}
