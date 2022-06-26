using DataAccess.Entities;

namespace BusinessObject;

public interface IMemberServices
{
    public Member Login(string email, string password);
    public void CreateMember(Member member);
    public void UpdateMember(Member member);
    public void DeleteMember(int memberId);
    public Member SearchMemberById(int memberId);
    public IEnumerable<Member> SearchMemberByName(string name);
    public IEnumerable<Member> FilterMemberByCity(string City);
    public IEnumerable<Member> FilterMemberByCountry(string Country);

}
